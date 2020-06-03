using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FHIRGenomicsImporter.Model;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace FHIRGenomicsImporter
{
	public class AgsFhirLoader
	{
		private string FhirBaseUrl { get; set; }
		private string AgsDbConnection { get; set; }

		// Cache the attribute IDs and descriptions so that we have easy access to them as
		// we build
		private static Dictionary<int, string> Attributes = null;

		private static readonly List<string> PgxObservationProfiles = new List<string>() {
								Constants.GenomicsProfile.MedicationMetabolism,
								Constants.GenomicsProfile.MedicationTransporter,
								Constants.GenomicsProfile.MedicationEfficacy
		};

		public AgsFhirLoader(string fhirBaseUrl, string agsDbConnection)
		{
			this.FhirBaseUrl = fhirBaseUrl;
			// Add trailing backslash in URL if it is missing
			if (!string.IsNullOrWhiteSpace(this.FhirBaseUrl)
				&& !this.FhirBaseUrl.EndsWith("/")) {
				this.FhirBaseUrl += "/";
			}
			this.AgsDbConnection = agsDbConnection;
		}

		public async Task ProcessBundles()
		{
			var optionsBuilder = new DbContextOptionsBuilder<AgsContext>();
			optionsBuilder.UseSqlServer(AgsDbConnection);
			using (var context = new AgsContext(optionsBuilder.Options)) {
				if (Attributes == null) {
					var attributeList = await context.Agsattributes.ToListAsync();
					Attributes = new Dictionary<int, string>(attributeList.Count);
					attributeList.ForEach(x => Attributes.Add(x.AttributeId, x.Name));
				}

				ProcessDiagnosticReports(context);
			}
		}

		private static bool ResourceHasProfile(Resource resource, List<string> profileUris)
		{
			if (resource == null || resource.Meta == null || resource.Meta.Profile == null
				|| profileUris == null || profileUris.Count == 0) {
				return false;
			}

			bool correctProfile = false;
			foreach (var profile in resource.Meta.Profile) {
				if (profileUris.Exists(x => x.Equals(profile, StringComparison.CurrentCultureIgnoreCase))) {
					correctProfile = true;
					break;
				}
			}

			return correctProfile;
		}

		private static bool ResourceHasProfile(Resource resource, string profileUri)
		{
			return ResourceHasProfile(resource, new List<string>() { profileUri });
		}

		private void ProcessDiagnosticReports(AgsContext context)
		{
			var client = new FhirClient(this.FhirBaseUrl);
			var reports = (Bundle)client.Get("DiagnosticReport");

			int reportCounter = 0;
			while (reports != null) {
				if (reports.Entry == null || reports.Entry.Count == 0) {
					Console.WriteLine("Null or empty list of DiagnosticReport resources returned by FHIR server");
					return;
				}

				Console.WriteLine("Processing bundle of {0} reports", reports.Entry.Count);

				foreach (var entry in reports.Entry) {
					var resource = entry.Resource;
					var reportResource = resource as DiagnosticReport;
					if (resource.ResourceType != ResourceType.DiagnosticReport) {
						throw new FHIRGenomicsException(string.Format("We received a {0} resource where we expected a DiagnosticReport", resource.ResourceType));
					} else if (reportResource == null) {
						throw new FHIRGenomicsException(string.Format("Unable to cast resource ID {0} as a DiagnosticReport", resource.Id));
					}

					if (!ResourceHasProfile(reportResource, Constants.GenomicsProfile.DiagnosticReport)) {
						throw new FHIRGenomicsException("The expected FHIR profile was not specified for the DiagnosticReport");
					}
					ProcessDiagnosticReport(reportResource, context);
					reportCounter++;
				}

				reports = (Bundle)client.Continue(reports);
			}

			context.SaveChanges();
			Console.WriteLine("Processed {0} reports", reportCounter);
		}

		private void ProcessDiagnosticReport(DiagnosticReport report, AgsContext context)
		{
			var client = new FhirClient(this.FhirBaseUrl);

			// The result collection contains observations, including a Grouper type observation that will hold PGx results.
			// There can be >1 Grouper, so we need to do a little more investigation (peeking at the first observation type)
			// to see if it's really the one we want.
			var pgxObservations = new List<Observation>();
			foreach (var result in report.Result) {
				var observation = client.Read<Observation>(result.Url);
				if (!ResourceHasProfile(observation, Constants.GenomicsProfile.Grouper)) {
					continue;
				}

				foreach (var member in observation.HasMember) {
					var memberResource = client.Read<Observation>(member.Url);
					if (memberResource == null
						|| !ResourceHasProfile(memberResource, PgxObservationProfiles)) {
						pgxObservations.Clear();
						break;
					}
					pgxObservations.Add(memberResource);
				}

				// If we have any PGx observations at this point, we must have found the right grouper.  We can stop
				// processing since we have found what we're looking for.
				if (pgxObservations.Count > 0) {
					break;
				}
			}

			// Now that we're out of the loop, confirm or refute the assumption that all of our results should have
			// a PGx grouper that contains PGx results.  If we didn't find one, halt the program.
			if (pgxObservations.Count == 0) {
				throw new FHIRGenomicsException("No grouper containing PGx-related Observation resources was found");
			}

			// Get the patient
			Patient patient = client.Read<Patient>(report.Subject.Url);
			if (patient == null) {
				throw new FHIRGenomicsException("Unable to find the patient associated with this DiagnosticReport");
			}
			ProcessPatient(patient, context);

			AgsresultMessages message = new AgsresultMessages {
				Sender = "HGSC",
				Format = "FHIR",
				ReceivedOn = DateTime.Now,
				ProcessedOn = DateTime.Now,
				Status = "Processed"
			};
			context.AgsresultMessages.Add(message);

			AgsresultAttributes sample = NewResultAttribute(Constants.Attribute.Sample);
			sample.Value = string.Empty;
			message.AgsresultAttributes.Add(sample);
			context.SaveChanges();

			if (report.Status.HasValue) {
				AgsresultAttributes status = NewResultAttribute(Constants.Attribute.Status, sample.ResultAttributeId);
				status.Value = report.Status.Value.ToString();
				message.AgsresultAttributes.Add(status);
			}

			AgsresultAttributes createdOn = NewResultAttribute(Constants.Attribute.CreatedOn, sample.ResultAttributeId);
			createdOn.Value = DateTime.Now.ToShortDateString();
			message.AgsresultAttributes.Add(createdOn);

			var specimens = report.Specimen;
			if (specimens == null || specimens.Count == 0) {
				throw new FHIRGenomicsException("No specimen was found for this DiagnosticReport");
			} else if (specimens.Count != 1) {
				throw new FHIRGenomicsException(string.Format("We are expecting exactly 1 specimen for this DiagnosticReport, but found {0}", specimens.Count));
			}
			var specimen = (Specimen)client.Get(specimens[0].Url);

			AgsresultAttributes sampleType = NewResultAttribute(Constants.Attribute.SampleType, sample.ResultAttributeId);
			sampleType.Value = specimen.Type.Coding[0].Display;
			message.AgsresultAttributes.Add(sampleType);

			AgsresultAttributes accession = NewResultAttribute(Constants.Attribute.LabAccession, sample.ResultAttributeId);
			accession.Value = report.Identifier.Find(x => x.System.Equals(Constants.CodeSystem.HGSC)).Value;
			message.AgsresultAttributes.Add(accession);

			var interpreters = report.ResultsInterpreter;
			if (interpreters == null || interpreters.Count == 0) {
				throw new FHIRGenomicsException("We expected at least one signer (ResultsInterpreter) for this DiagnosticReport, but found 0");
			}

			foreach (var interpreter in interpreters) {
				AgsresultAttributes interpreterAttr = NewResultAttribute(Constants.Attribute.SignedBy, sample.ResultAttributeId);
				var role = (PractitionerRole)client.Get(interpreter.Url);
				var practitioner = (Practitioner)client.Get(role.Practitioner.Url);
				interpreterAttr.Value = FormatName(practitioner.Name);
				message.AgsresultAttributes.Add(interpreterAttr);
			}

			var serviceRequest = (ServiceRequest)client.Get(report.BasedOn[0].Url);
			if (!ResourceHasProfile(serviceRequest, Constants.GenomicsProfile.ServiceRequest)) {
				throw new FHIRGenomicsException("The ServiceRequest profile did not match the Genomics IG profile");
			}
			Coding indicationCoding = null;
			foreach (var reasonCode in serviceRequest.ReasonCode) {
				indicationCoding = reasonCode.Coding.Find(x => x.System.Equals(Constants.CodeSystem.GeneInsight));
				if (indicationCoding != null) {
					break;
				}
			}
			if (indicationCoding == null) {
				throw new FHIRGenomicsException("Unable to find a valid reason for testing within the ServiceRequest");
			}
			AgsresultAttributes testIndication = NewResultAttribute(Constants.Attribute.TestIndication, sample.ResultAttributeId);
			testIndication.Value = indicationCoding.Display;
			message.AgsresultAttributes.Add(testIndication);

			Coding requestCoding = serviceRequest.Code.Coding.Find(x => x.System.Equals(Constants.CodeSystem.BaylorLabTestCodes));
			if (requestCoding == null) {
				throw new FHIRGenomicsException("Unable to find a valid code for the ServiceRequest");
			}
			AgsresultAttributes assayTest = NewResultAttribute(Constants.Attribute.AssayTestCode, sample.ResultAttributeId);
			assayTest.Value = requestCoding.Display;
			message.AgsresultAttributes.Add(assayTest);

			AgsresultAttributes observedOn = NewResultAttribute(Constants.Attribute.ObservedOn, sample.ResultAttributeId);
			observedOn.Value = serviceRequest.AuthoredOn;
			message.AgsresultAttributes.Add(observedOn);

			AgsresultAttributes receivedOn = NewResultAttribute(Constants.Attribute.ReceivedOn, sample.ResultAttributeId);
			receivedOn.Value = specimen.ReceivedTime;
			message.AgsresultAttributes.Add(receivedOn);

			AgsresultAttributes collectedOn = NewResultAttribute(Constants.Attribute.CollectionDate, sample.ResultAttributeId);
			collectedOn.Value = ((FhirDateTime)specimen.Collection.Collected).ToString();
			message.AgsresultAttributes.Add(collectedOn);

			//var tmp = client.SearchById("PlanDefinition", serviceRequest.InstantiatesCanonical.First());
			//var tmp2 = client.SearchById("PlanDefinition", serviceRequest.InstantiatesCanonical.First().Replace("urn:uuid:", ""));
			//var planDefinition = (PlanDefinition)client.Get(serviceRequest.InstantiatesCanonical.First());
			//if (planDefinition == null) {
			//	throw new FHIRGenomicsException("Failed to retrieve a PlanDefinition resource from the ServiceRequest");
			//}

			//var methodBuilder = new StringBuilder();
			//foreach (var action in planDefinition.Action) {
			//	methodBuilder.AppendLine(action.Description);
			//}

			//AgsresultAttributes method = NewResultAttribute(Constants.Attribute.MethodDescription, sample.ResultAttributeId);
			//method.Value = methodBuilder.ToString();
			//message.AgsresultAttributes.Add(method);

			context.SaveChanges();

			foreach (var pgxObservation in pgxObservations) {
				AgsresultAttributes pgxResult = NewResultAttribute(Constants.Attribute.PGxResult, sample.ResultAttributeId);
				pgxResult.Value = string.Empty;
				message.AgsresultAttributes.Add(pgxResult);
				context.SaveChanges();

				if (pgxObservation.DerivedFrom == null) {
					throw new FHIRGenomicsException("Expected exactly one DerivedFrom entry, but none were found");
				}

				foreach (var geneDerivation in pgxObservation.DerivedFrom) {
					var geneObservation = (Observation)client.Get(geneDerivation.Url);

					AgsresultAttributes gene = NewResultAttribute(Constants.Attribute.GeneSymbol, pgxResult.ResultAttributeId);
					gene.Value = ((CodeableConcept)geneObservation.Component[0].Value).Coding[0].Display;
					message.AgsresultAttributes.Add(gene);

					AgsresultAttributes diplotype = NewResultAttribute(Constants.Attribute.PGxDiplotype, pgxResult.ResultAttributeId);
					diplotype.Value = ((CodeableConcept)geneObservation.Value).Text;
					message.AgsresultAttributes.Add(diplotype);
				}

				AgsresultAttributes phenotype = NewResultAttribute(Constants.Attribute.PGxPhenotype, pgxResult.ResultAttributeId);
				var pgxPhenotypeConcept = ((CodeableConcept)pgxObservation.Value);
				if (((CodeableConcept)pgxObservation.Value).Coding.Count == 0) {
					phenotype.Value = pgxPhenotypeConcept.Text;
				} else {
					phenotype.Value = pgxPhenotypeConcept.Coding[0].Display;
				}
				message.AgsresultAttributes.Add(phenotype);

				AgsresultAttributes variantInterpretation = NewResultAttribute(Constants.Attribute.VariantInterpretation, pgxResult.ResultAttributeId);
				variantInterpretation.Value = pgxObservation.GetExtensionValue<Element>(Constants.HGSCExtension.InterpretationSummaryText).ToString();
				message.AgsresultAttributes.Add(variantInterpretation);

				foreach (var pgxMed in pgxObservation.Component) {
					AgsresultAttributes pgxMedication = NewResultAttribute(Constants.Attribute.PGxAssociatedMedication, pgxResult.ResultAttributeId);
					pgxMedication.Value = ((CodeableConcept)pgxMed.Value).Coding[0].Display;
					message.AgsresultAttributes.Add(pgxMedication);
					context.SaveChanges();

					AgsresultAttributes pgxRecommendation = NewResultAttribute(Constants.Attribute.PGxAssociatedRecommendation, pgxMedication.ResultAttributeId);
					pgxRecommendation.Value = pgxMed.GetExtensionValue<RelatedArtifact>(Constants.HGSCExtension.RelatedArtifact).Url;
					message.AgsresultAttributes.Add(pgxRecommendation);
				}
				context.SaveChanges();
			}
		}

		private string FormatName(List<HumanName> names)
		{
			if (names == null || names.Count == 0) {
				return string.Empty;
			}

			foreach (var name in names) {
				// We want the first official or usual name entry
				if (name.Use.Equals(HumanName.NameUse.Usual) | name.Use.Equals(HumanName.NameUse.Official)) {
					var nameBuilder = new StringBuilder();
					if (name.Given != null) {
						nameBuilder.AppendFormat("{0} ", string.Join(' ', name.Given));
					}
					if (!string.IsNullOrWhiteSpace(name.Family)) {
						nameBuilder.AppendFormat("{0} ", name.Family);
					}
					if (name.Suffix != null) {
						nameBuilder.AppendFormat(string.Join(' ', name.Suffix));
					}

					return nameBuilder.ToString().Trim();
				}
			}

			return string.Empty;
		}

		private AgsresultAttributes NewResultAttribute(int attributeId, int? parentAttributeId = null)
		{
			return new AgsresultAttributes() {
				AttributeId = attributeId,
				AttributeName = Attributes[attributeId],
				ParentResultAttributeId = parentAttributeId
			};
		}

		//private async Task ProcessPatients(AgsContext context)
		//{
		//	var patients = await GetAllResources("Patient");
		//	if (patients == null || patients.Entry == null || patients.Entry.Count == 0) {
		//		Console.WriteLine("Null or empty list of Patient resources returned by FHIR server");
		//		return;
		//	}

		//	Console.WriteLine("PROCESSING {0} PATIENTS", patients.Entry.Count);
		//	Console.WriteLine("-----------------------");

		//	foreach (var entry in patients.Entry) {
		//		var resource = entry.Resource;
		//		var patientResource = resource as Patient;
		//		if (resource.ResourceType != ResourceType.Patient) {
		//			throw new FHIRGenomicsException(string.Format("We received a {0} resource where we expected a Patient", resource.ResourceType));
		//		} else if (patientResource == null) {
		//			throw new FHIRGenomicsException(string.Format("Unable to cast resource ID {0} as a Patient", resource.Id));
		//		}
		//		ProcessPatient(patientResource, context);
		//	}
		//}

		private void ProcessPatient(Patient patientResource, AgsContext context)
		{
			var firstName = "";
			var lastName = "";
			if (patientResource.Name == null || patientResource.Name.Count == 0) {
				Console.WriteLine("{0} has no Name entries - using default of 'Patient {0}'",
					patientResource.Id);
				firstName = "Patient";
				lastName = patientResource.Id;
			} else {
				if (patientResource.Name.Count > 1) {
					Console.WriteLine("{0} has {1} Name entries - using the first entry only",
						patientResource.Id, patientResource.Name.Count);
				}

				HumanName name = patientResource.Name[0];
				firstName = string.Join(" ", name.Given);
				lastName = name.Family;
			}

			var gender = "U";
			var genderElement = patientResource.Extension.Find(x => x.Url.Equals("http://hl7.org/fhir/us/core/StructureDefinition/us-core-birthsex", StringComparison.CurrentCultureIgnoreCase));
			if (genderElement != null) {
				gender = genderElement.Value.ToString();
			}

			DateTime? dateOfBirth = null;
			if (patientResource.BirthDateElement == null) {
				Console.WriteLine("No DOB for Patient {0}", patientResource.Id);
			} else {
#pragma warning disable CS0618 // Type or member is obsolete
				dateOfBirth = patientResource.BirthDateElement.ToDateTime();
#pragma warning restore CS0618 // Type or member is obsolete
			}

			var mrn = "";
			if (patientResource.Identifier == null || patientResource.Identifier.Count == 0) {
				Console.WriteLine("Patinet {0} has no identifier entries", patientResource.Id);
			} else {
				Identifier id = patientResource.Identifier.Find(x => x.System.Equals("https://emerge.mc.vanderbilt.edu/", StringComparison.CurrentCultureIgnoreCase));
				if (patientResource.Identifier.Count > 1) {
					Console.WriteLine("Patient {0} had {1} identifiers. We will use the first eMERGE associated entry of {2}",
						patientResource.Id, patientResource.Identifier.Count, id.Value);
				}
				mrn = id.Value;
			}

			var patient = new Agspatients();
			patient.FirstName = firstName;
			patient.LastName = lastName;
			patient.BirthDate = dateOfBirth;
			patient.Gender = gender;
			patient.Mrn = mrn;
			context.Agspatients.Add(patient);
		}

		private string FhirUrl(string resource)
		{
			return string.Format("{0}{1}", this.FhirBaseUrl, resource);
		}

		private async Task<Bundle> GetAllResources(string resource)
		{
			using (HttpClient client = new HttpClient()) {
				var response = await client.GetAsync(FhirUrl(resource), HttpCompletionOption.ResponseContentRead);

				response.EnsureSuccessStatusCode();

				var content = await response.Content.ReadAsStringAsync();

				var parser = new FhirJsonParser();
				var bundle = parser.Parse<Bundle>(content);
				return bundle;
			}
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FHIRGenomicsImporter.Model
{
    public static class Constants
    {
        public static class Attribute
        {
            public const int ValueDerivation = 1;
            public const int Sample = 20;
            public const int Unassigned = 21;
            public const int SampleType = 22;
            public const int SignedBy = 23;
            public const int CreatedOn = 24;
            public const int ObservedOn = 25;
            public const int PatientID = 26;
            public const int Status = 27;
            public const int Comments = 28;
            public const int ReceivedOn = 29;
            public const int GeneticResult = 100;
            public const int CYP2C9Result = 101;
            public const int CYP2C9Haplotype1 = 102;
            public const int CYP2C9Haplotype2 = 103;
            public const int CYP2C9Diplotype = 104;
            public const int CYP2C9Fail = 105;
            public const int VKORC1Result = 106;
            public const int VKORC1Allele1 = 107;
            public const int VKORC1Allele2 = 108;
            public const int VKORC1Genotype = 109;
            public const int VKORC1Fail = 110;
            public const int CYP2C19Result = 111;
            public const int CYP2C19Haplotype1 = 112;
            public const int CYP2C19Haplotype2 = 113;
            public const int CYP2C19Diplotype = 114;
            public const int CYP2C19Fail = 115;
            public const int CYP2C19SNP = 116;
            public const int rs12248560 = 117;
            public const int rs28399504 = 118;
            public const int rs41291556 = 119;
            public const int SLCO1B1Result = 120;
            public const int SLCO1B1Allele1 = 121;
            public const int SLCO1B1Allele2 = 122;
            public const int SLCO1B1Genotype = 123;
            public const int SLCO1B1Fail = 124;
            //New
            public const int rs72552267 = 125;
            public const int rs4986893 = 126;
            public const int rs4244285 = 127;
            public const int rs72558186 = 128;
            public const int rs56337013 = 129;
            public const int CYP2C9SNP = 130;
            public const int rs1799853 = 131;
            public const int rs9332131 = 132;
            public const int rs1057910 = 133;
            public const int rs28371686 = 134;
            public const int VKORC1SNP = 135;
            public const int rs9923231 = 136;
            public const int rs7294 = 137;
            public const int rs9934438 = 138;
            public const int TPMTResult = 139;
            public const int TPMTSNP = 140;
            public const int rs1142345 = 141;
            public const int rs1800462 = 142;
            public const int CYP3A5Result = 143;
            public const int CYP3A5SNP = 144;
            public const int rs776746 = 145;
            public const int GenotypeMethod = 146;
            public const int MethodDescription = 147;
            public const int AnalyticSensitivity = 148;
            public const int rs4149056 = 149;
            public const int Institution = 150;
            public const int LabIdentifier = 151;
            public const int TestedOn = 152;
            public const int TurnAroundFromDateReceived = 153;
            public const int TurnAroundFromTestInitiation = 154;

            // Created for eMERGE III results from Baylor (although reusable for future results too).
            public const int LabAccession = 155;
            public const int TestIndication = 156;
            public const int OverallInterpretation = 157;
            public const int ReportedVariant = 158;
            public const int GeneRegion = 159;
            public const int DNAChange = 160;
            public const int AminoAcidChange = 161;
            public const int GeneSymbol = 162;
            public const int AlleleState = 163;
            public const int ClinicalSignificance = 164;
            public const int TranscriptID = 165;
            public const int Chromosome = 166;
            public const int ConfirmedBySanger = 167;
            public const int CategoryType = 168;
            public const int Inheritance = 169;
            public const int InterpretationText = 170;
            public const int AssociatedDiseases = 171;
            public const int ReferenceAlignment = 172;
            public const int GenomeBuild = 173;
            public const int StartPosition = 174;
            public const int WildtypeSequence = 175;
            public const int VariantSequence = 176;
            public const int Addendum = 177;
            public const int AddendumText = 178;
            public const int AddendumDate = 179;
            public const int eMERGE3ParticipantData = 180;
            public const int ReturnOfResultID = 181;
            public const int StudyStatus = 182;
            public const int IndicationForTesting = 183;
            public const int DiseaseStatus = 184;
            public const int HasKnownMutation = 185;
            public const int KnownMutations = 186;
            public const int RecruitmentClinic = 187;
            public const int eMERGE3OptionsArm = 188;
            public const int OptionTreatmentIsAvailable = 189;
            public const int OptionTreatmentIsNotAvailable = 190;
            public const int OptionDementia = 191;
            public const int OptionCancer = 192;
            public const int OptionBehaviorLearningConditions = 193;
            public const int OptionCarrier = 194;
            public const int OptionUncertainResults = 195;
            public const int CodeValue = 196;
            public const int CodeSystem = 197;
            public const int HGSCVIPFile = 198;
            public const int GeneCoverageEntry = 199;
            public const int GeneCoverageValue = 200;
            public const int AssayVersion = 201;
            public const int AssayTestCode = 202;
            public const int CollectionDate = 203;
            public const int ParticipantAddress = 204;
            public const int AppointmentLocation = 205;
            public const int ParticipantNotes = 206;
            public const int CNVAnalysisFailed = 207;
            public const int VariantInterpretation = 208;
            public const int ReportDNAChange = 209;

            //PGx Attributes
            public const int PGxComments = 210;
            public const int PGxResult = 211;
            public const int PGxAssociatedMedication = 212;
            public const int PGxAssociatedRecommendation = 213;
            public const int PGxDiplotype = 214;
            public const int PGxPhenotype = 215;
        }

        public static class AttributeType
        {
            public const int AbstractEntity = 1;
            public const int HaplotypeStarVariant = 2;
            public const int DiplotypeStarVariant = 3;
            public const int AlleleValue = 4;
            public const int GenotypeSNPValue = 5;
            public const int ValueObservation = 6;
            public const int LaboratorySample = 7;
            public const int ControlledVocabularyCode = 8;
            public const int FormResponse = 9;
        }

        public static class ObservationStatus
        {
            public const int ApprovalNeeded = 0;
            public const int Approved = 1;
            public const int Processed = 2;
            public const int Deleted = 3;
            public const int Replaced = 4;
            public const int Released = 5;
            public const int Suppressed = 9;
        }

        public static class MessageFileType
        {
            public const int Xml = 1;
            public const int Pdf = 2;
            public const int Excel = 3;
            public const int Html = 4;
            public const int BaylorJson = 5; 
        }

        public static class ObservationDetailStatus
        {
            public const int Active = 1;
            public const int Deleted = 2;
        }

        public static class InterpretationTemplateStatus
        {
            public const int Active = 1;
            public const int Deleted = 2;
        }

        public static class ObservationGroupCategory
        {
            public const int Replacement = 1;
            public const int Panel = 2;
        }

        public static class ObservationGroupStatus
        {
            public const int Active = 1;
            public const int Deleted = 2;
        }

        public static class VariantType
        {
            public const int NoVariants = 1;
            public const int SingleVariant = 2;
            public const int Gene = 3;
        }

        public static class VariantStatus
        {
            public const int Active = 1;
            public const int Deleted = 2;
        }

        public static class VariantAttributeStatus
        {
            public const int Active = 1;
            public const int Deleted = 2;
        }

        public static class MappingStatus
        {
            public const int Active = 1;
            public const int Deleted = 2;
        }

        public static class MappingContext
        {
            public const string ReportSection = "ReportSection";
            public const string OBXIdentifier = "OBX";
            public const string EpicLRRID = "Epic-LRR-ID";
            public const string EpicAlternateCode = "Epic-LRR-AltCode";
            public const string EpicLRRBaseName = "Epic-LRR-BaseName";
        }

        public static class GenomicsProfile
        {
            public const string DiagnosticReport = "http://hl7.org/fhir/uv/genomics-reporting/StructureDefinition/diagnosticreport";
            public const string Grouper = "http://hl7.org/fhir/uv/genomics-reporting/StructureDefinition/grouper";
            public const string MedicationMetabolism = "http://hl7.org/fhir/uv/genomics-reporting/StructureDefinition/medication-metabolism";
            public const string MedicationTransporter = "http://hl7.org/fhir/uv/genomics-reporting/StructureDefinition/medication-transporter";
            public const string MedicationEfficacy = "http://hl7.org/fhir/uv/genomics-reporting/StructureDefinition/medication-efficacy";
            public const string ServiceRequest = "http://hl7.org/fhir/uv/genomics-reporting/StructureDefinition/servicerequest";
        }

		public static class HGSCExtension
		{
            public const string InterpretationSummaryText = "https://emerge.hgsc.bcm.edu/fhir/StructureDefinition/interpretation-summary-text";
			public const string RelatedArtifact = "http://hl7.org/fhir/uv/genomics-reporting/StructureDefinition/RelatedArtifact";
        }

		public static class CodeSystem
		{
            public const string HGSC = "https://emerge.hgsc.bcm.edu/";
            public const string GeneInsight = "https://emerge.geneinsight.com";
            public const string BaylorLabTestCodes = "https://hgsc.bcm.edu/lab-test-codes/";

        }
    }
}
using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class VwObservationGroups
    {
        public int GroupId { get; set; }
        public int ObservationId { get; set; }
        public int PatientId { get; set; }
        public string GroupName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public DateTime? ReleasedOn { get; set; }
        public byte Status { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Mrn { get; set; }
        public string Comments { get; set; }
        public string DisplayVarients { get; set; }
        public short? DisplayOrder { get; set; }
        public string ClinicalComments { get; set; }
        public string StudyId { get; set; }
        public string IndicationForTesting { get; set; }
        public string DiseaseStatus { get; set; }
        public string HasPreviouslyKnownMutations { get; set; }
        public string PreviouslyKnownMutations { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class VwObservations
    {
        public int ObservationId { get; set; }
        public int PatientId { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Mrn { get; set; }
        public string CodeValue { get; set; }
        public string DisplayVarients { get; set; }
        public string Comments { get; set; }
        public string CodeSystem { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string ClinicalComments { get; set; }
        public string InternalComments { get; set; }
        public int ModuleId { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ReleasedOn { get; set; }
        public string ReleasedBy { get; set; }
        public string AccessionNumber { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public short? DisplayOrder { get; set; }
    }
}

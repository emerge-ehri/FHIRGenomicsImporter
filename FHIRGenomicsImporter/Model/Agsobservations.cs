using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class Agsobservations
    {
        public Agsobservations()
        {
            AgsobservationDetails = new HashSet<AgsobservationDetails>();
            AgsobservationExportHistory = new HashSet<AgsobservationExportHistory>();
            AgsobservationGroupMembers = new HashSet<AgsobservationGroupMembers>();
            AgsobservationResultAttributes = new HashSet<AgsobservationResultAttributes>();
        }

        public int ObservationId { get; set; }
        public int PatientId { get; set; }
        public string CodeValue { get; set; }
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
        public string CodeName { get; set; }
        public string AbnormalFlag { get; set; }

        public virtual Agspatients Patient { get; set; }
        public virtual ICollection<AgsobservationDetails> AgsobservationDetails { get; set; }
        public virtual ICollection<AgsobservationExportHistory> AgsobservationExportHistory { get; set; }
        public virtual ICollection<AgsobservationGroupMembers> AgsobservationGroupMembers { get; set; }
        public virtual ICollection<AgsobservationResultAttributes> AgsobservationResultAttributes { get; set; }
    }
}

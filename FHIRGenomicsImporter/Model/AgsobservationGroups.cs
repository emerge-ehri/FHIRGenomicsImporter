using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsobservationGroups
    {
        public AgsobservationGroups()
        {
            Agscommunications = new HashSet<Agscommunications>();
            AgsobservationExportHistory = new HashSet<AgsobservationExportHistory>();
            AgsobservationGroupMembers = new HashSet<AgsobservationGroupMembers>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? Category { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
        public short? DisplayOrder { get; set; }
        public int? PatientId { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ReleasedOn { get; set; }
        public string ReleasedBy { get; set; }
        public string CodeValue { get; set; }
        public string CodeSystem { get; set; }
        public string CodeName { get; set; }

        public virtual ICollection<Agscommunications> Agscommunications { get; set; }
        public virtual ICollection<AgsobservationExportHistory> AgsobservationExportHistory { get; set; }
        public virtual ICollection<AgsobservationGroupMembers> AgsobservationGroupMembers { get; set; }
    }
}

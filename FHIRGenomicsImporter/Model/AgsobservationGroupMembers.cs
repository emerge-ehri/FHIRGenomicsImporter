using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsobservationGroupMembers
    {
        public int MemberId { get; set; }
        public int GroupId { get; set; }
        public int ObservationId { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
        public short? DisplayOrder { get; set; }
        public string CodeSystem { get; set; }
        public string CodeValue { get; set; }
        public string CodeName { get; set; }

        public virtual AgsobservationGroups Group { get; set; }
        public virtual Agsobservations Observation { get; set; }
    }
}

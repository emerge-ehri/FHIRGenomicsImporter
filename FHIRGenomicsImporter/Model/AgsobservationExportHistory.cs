using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsobservationExportHistory
    {
        public int ExportId { get; set; }
        public int ObservationId { get; set; }
        public int? GroupId { get; set; }
        public int ReleasedTo { get; set; }
        public byte Status { get; set; }
        public DateTime ReleasedOn { get; set; }
        public string ReleasedBy { get; set; }

        public virtual AgsobservationGroups Group { get; set; }
        public virtual Agsobservations Observation { get; set; }
    }
}

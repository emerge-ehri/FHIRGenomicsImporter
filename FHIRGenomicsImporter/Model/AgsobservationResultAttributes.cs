using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsobservationResultAttributes
    {
        public int Id { get; set; }
        public int ObservationId { get; set; }
        public int ResultAttributeId { get; set; }

        public virtual Agsobservations Observation { get; set; }
        public virtual AgsresultAttributes ResultAttribute { get; set; }
    }
}

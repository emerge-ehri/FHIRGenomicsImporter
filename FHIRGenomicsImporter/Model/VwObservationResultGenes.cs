using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class VwObservationResultGenes
    {
        public int ObservationId { get; set; }
        public int MessageId { get; set; }
        public int PatientId { get; set; }
        public int ResultAttributeId { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }
        public string SampleType { get; set; }
        public string SignedBy { get; set; }
    }
}

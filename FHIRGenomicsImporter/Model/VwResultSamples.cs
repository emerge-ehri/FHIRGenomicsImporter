using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class VwResultSamples
    {
        public int MessageId { get; set; }
        public int PatientId { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }
    }
}

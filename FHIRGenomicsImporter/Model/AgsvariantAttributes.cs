using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsvariantAttributes
    {
        public int VariantAttributeId { get; set; }
        public int VariantId { get; set; }
        public string CodeSystem { get; set; }
        public string CodeName { get; set; }
        public string CodeValue { get; set; }
        public byte Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Agsvariants Variant { get; set; }
    }
}

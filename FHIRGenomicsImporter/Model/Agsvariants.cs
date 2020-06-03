using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class Agsvariants
    {
        public Agsvariants()
        {
            AgsvariantAttributes = new HashSet<AgsvariantAttributes>();
        }

        public int VariantId { get; set; }
        public string Context { get; set; }
        public byte Type { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<AgsvariantAttributes> AgsvariantAttributes { get; set; }
    }
}

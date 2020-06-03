using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsattributeTypes
    {
        public AgsattributeTypes()
        {
            Agsattributes = new HashSet<Agsattributes>();
        }

        public int AttributeTypeId { get; set; }
        public string Name { get; set; }
        public int DataTypeId { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
        public string JoinTable { get; set; }
        public string JoinColumn { get; set; }
        public byte ValuePosition { get; set; }

        public virtual AgsattributeDataTypes DataType { get; set; }
        public virtual ICollection<Agsattributes> Agsattributes { get; set; }
    }
}

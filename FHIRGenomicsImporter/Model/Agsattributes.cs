using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class Agsattributes
    {
        public Agsattributes()
        {
            AgsresultAttributes = new HashSet<AgsresultAttributes>();
        }

        public int AttributeId { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string Description { get; set; }
        public int AttributeTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte Status { get; set; }
        public DateTime? DeletedOn { get; set; }

        public virtual AgsattributeTypes AttributeType { get; set; }
        public virtual ICollection<AgsresultAttributes> AgsresultAttributes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsresultAttributes
    {
        public AgsresultAttributes()
        {
            AgsobservationResultAttributes = new HashSet<AgsobservationResultAttributes>();
        }

        public int ResultAttributeId { get; set; }
        public int MessageId { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public int? ParentResultAttributeId { get; set; }
        public string Value { get; set; }
        public string Lineage { get; set; }

        public virtual Agsattributes Attribute { get; set; }
        public virtual AgsresultMessages Message { get; set; }
        public virtual ICollection<AgsobservationResultAttributes> AgsobservationResultAttributes { get; set; }
    }
}

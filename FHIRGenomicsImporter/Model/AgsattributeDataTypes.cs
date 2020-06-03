using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsattributeDataTypes
    {
        public AgsattributeDataTypes()
        {
            AgsattributeTypes = new HashSet<AgsattributeTypes>();
        }

        public int DataTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AgsattributeTypes> AgsattributeTypes { get; set; }
    }
}

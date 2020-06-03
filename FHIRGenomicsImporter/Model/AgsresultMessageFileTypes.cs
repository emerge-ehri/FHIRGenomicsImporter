using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsresultMessageFileTypes
    {
        public AgsresultMessageFileTypes()
        {
            AgsresultMessageFiles = new HashSet<AgsresultMessageFiles>();
        }

        public int MessageFileTypeId { get; set; }
        public string Name { get; set; }
        public string ViewAction { get; set; }
        public byte[] Data { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<AgsresultMessageFiles> AgsresultMessageFiles { get; set; }
    }
}

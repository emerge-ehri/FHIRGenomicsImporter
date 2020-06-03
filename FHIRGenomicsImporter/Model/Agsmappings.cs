using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class Agsmappings
    {
        public int MappingId { get; set; }
        public string FromContext { get; set; }
        public string FromId { get; set; }
        public string ToContext { get; set; }
        public string ToId { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

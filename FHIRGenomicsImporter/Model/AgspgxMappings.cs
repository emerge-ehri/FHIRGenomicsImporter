using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgspgxMappings
    {
        public int Id { get; set; }
        public string Gene { get; set; }
        public string Drugs { get; set; }
        public string DisplayDrugsLong { get; set; }
        public string DisplayDrugsShort { get; set; }
        public string CodeValue { get; set; }
        public string CodeName { get; set; }
    }
}

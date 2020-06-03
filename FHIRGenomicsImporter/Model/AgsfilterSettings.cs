using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsfilterSettings
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int DataType { get; set; }
    }
}

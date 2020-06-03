using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsnuEMergeSeq
    {
        public int Id { get; set; }
        public string ComponentDisplayedInEpic { get; set; }
        public int? DisplayOrder { get; set; }
        public string MeetsEpicGuidelines { get; set; }
        public string GeneSnp { get; set; }
        public string Category { get; set; }
        public string AllowedValues { get; set; }
        public bool? IsActive { get; set; }
    }
}

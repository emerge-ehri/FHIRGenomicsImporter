using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsinterpretationTemplates
    {
        public int TemplateId { get; set; }
        public string TemplateKey { get; set; }
        public string Name { get; set; }
        public string TemplateText { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
    }
}

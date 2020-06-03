using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgscommunicationTemplates
    {
        public AgscommunicationTemplates()
        {
            Agscommunications = new HashSet<Agscommunications>();
        }

        public int TemplateId { get; set; }
        public string Name { get; set; }
        public byte TemplateType { get; set; }
        public string TemplateContent { get; set; }
        public byte ContentType { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Agscommunications> Agscommunications { get; set; }
    }
}

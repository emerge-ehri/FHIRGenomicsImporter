using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class Agsdocumentation
    {
        public Agsdocumentation()
        {
            AgsdocumentationAudits = new HashSet<AgsdocumentationAudits>();
        }

        public int DocumentationId { get; set; }
        public int ParentId { get; set; }
        public byte ParentType { get; set; }
        public string OriginalFileName { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string Mimetype { get; set; }

        public virtual ICollection<AgsdocumentationAudits> AgsdocumentationAudits { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsdocumentationAudits
    {
        public int ResultMessageDocumentationAuditId { get; set; }
        public int DocumentationId { get; set; }
        public string UserName { get; set; }
        public DateTime AuditDate { get; set; }
        public string AuditType { get; set; }
        public string Field { get; set; }
        public string FromValue { get; set; }
        public string ToValue { get; set; }

        public virtual Agsdocumentation Documentation { get; set; }
    }
}

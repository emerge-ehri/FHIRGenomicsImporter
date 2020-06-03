using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsauditLogs
    {
        public int AuditLogId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string ActionBy { get; set; }
        public DateTime ActionOn { get; set; }
    }
}

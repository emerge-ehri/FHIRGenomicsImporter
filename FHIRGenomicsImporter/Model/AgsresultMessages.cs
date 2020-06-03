using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsresultMessages
    {
        public AgsresultMessages()
        {
            AgsresultAttributes = new HashSet<AgsresultAttributes>();
            AgsresultMessageAudits = new HashSet<AgsresultMessageAudits>();
            AgsresultMessageFiles = new HashSet<AgsresultMessageFiles>();
            AgsresultPatients = new HashSet<AgsresultPatients>();
        }

        public int MessageId { get; set; }
        public string Sender { get; set; }
        public string Format { get; set; }
        public DateTime ReceivedOn { get; set; }
        public DateTime ProcessedOn { get; set; }
        public string Status { get; set; }

        public virtual ICollection<AgsresultAttributes> AgsresultAttributes { get; set; }
        public virtual ICollection<AgsresultMessageAudits> AgsresultMessageAudits { get; set; }
        public virtual ICollection<AgsresultMessageFiles> AgsresultMessageFiles { get; set; }
        public virtual ICollection<AgsresultPatients> AgsresultPatients { get; set; }
    }
}

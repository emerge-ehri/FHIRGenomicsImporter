using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class VwLabResults
    {
        public int GroupId { get; set; }
        public string Mrn { get; set; }
        public int? PatientId { get; set; }
        public int MessageId { get; set; }
        public string Sender { get; set; }
        public DateTime ReceivedOn { get; set; }
        public DateTime ProcessedOn { get; set; }
        public string Status { get; set; }
        public string Format { get; set; }
        public string OriginalFileName { get; set; }
        public string FileName { get; set; }
        public byte[] XmlData { get; set; }
        public string Name { get; set; }
        public string ViewAction { get; set; }
        public byte[] XsltData { get; set; }
    }
}

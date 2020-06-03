using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class Agscommunications
    {
        public int CommunicationId { get; set; }
        public int ObservationGroupId { get; set; }
        public byte CommunicationType { get; set; }
        public byte Status { get; set; }
        public string Message { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public DateTime SentOn { get; set; }
        public string SentBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
        public int? TemplateId { get; set; }
        public string ContentData { get; set; }
        public byte[] UploadedData { get; set; }

        public virtual AgsobservationGroups ObservationGroup { get; set; }
        public virtual AgscommunicationTemplates Template { get; set; }
    }
}

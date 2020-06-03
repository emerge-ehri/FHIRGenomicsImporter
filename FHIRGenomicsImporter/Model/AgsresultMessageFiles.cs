using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsresultMessageFiles
    {
        public int MessageId { get; set; }
        public string FileName { get; set; }
        public string OriginalFileName { get; set; }
        public int? MessageFileTypeId { get; set; }
        public byte[] Data { get; set; }

        public virtual AgsresultMessages Message { get; set; }
        public virtual AgsresultMessageFileTypes MessageFileType { get; set; }
    }
}

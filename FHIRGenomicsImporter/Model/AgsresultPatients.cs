using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsresultPatients
    {
        public int MessageId { get; set; }
        public int PatientId { get; set; }

        public virtual AgsresultMessages Message { get; set; }
        public virtual Agspatients Patient { get; set; }
    }
}

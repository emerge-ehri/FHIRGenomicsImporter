using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgspatientCtmsdata
    {
        public int PatientId { get; set; }
        public int MessageId { get; set; }
        public string StudyId { get; set; }
        public string IndicationForTesting { get; set; }
        public string DiseaseStatus { get; set; }
        public string HasPreviouslyKnownMutations { get; set; }
        public string PreviouslyKnownMutations { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class VwPgxSummaryReport
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int ObservationId { get; set; }
        public int MessageId { get; set; }
        public int PatientId { get; set; }
        public string ObservationName { get; set; }
        public string NuSummaryDrugGeneInteraction { get; set; }
        public string Gene { get; set; }
        public string DisplayDiplotype { get; set; }
        public string NuReportDrugResponse { get; set; }
        public string NuReportRecommendation { get; set; }
        public string Recommendations { get; set; }
        public string Value { get; set; }
        public string ClinicalComments { get; set; }
        public string InternalComments { get; set; }
        public string CodeValue { get; set; }
        public string CodeName { get; set; }
        public string AbnormalFlag { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgspgxReportLogic
    {
        public int Id { get; set; }
        public string Gene { get; set; }
        public string Drugs { get; set; }
        public string DisplayDrugs { get; set; }
        public string Diplotype { get; set; }
        public string PhenotypeClinicalImplication { get; set; }
        public string Recommendations { get; set; }
        public string LabInterpretation { get; set; }
        public string DisplayDiplotype { get; set; }
        public string NuReportDrugResponse { get; set; }
        public string NuReportRecommendation { get; set; }
        public string NuSummaryDrugGeneInteraction { get; set; }
        public string NuSummaryDrugGeneInteractionPrinted { get; set; }
        public bool? IsActive { get; set; }
        public byte? SortOrder { get; set; }
    }
}

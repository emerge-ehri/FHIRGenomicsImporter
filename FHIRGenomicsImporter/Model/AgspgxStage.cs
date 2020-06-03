using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgspgxStage
    {
        public int Id { get; set; }
        public string DisplayDrugsLong { get; set; }
        public int PatientId { get; set; }
        public string Mrn { get; set; }
        public int ResultAttributeId { get; set; }
        public int MessageId { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public int? ParentResultAttributeId { get; set; }
        public string Drug { get; set; }
        public string Gene { get; set; }
        public string DiplotypeValue { get; set; }
        public string LogicGene { get; set; }
        public string Drugs { get; set; }
        public string GeneSnp { get; set; }
        public string ComponentDisplayedInEpic { get; set; }
        public string Diplotype { get; set; }
        public string DisplayDiplotype { get; set; }
        public string PhenotypeClinicalImplication { get; set; }
        public string Recommendations { get; set; }
        public string LabInterpretation { get; set; }
        public string NuReportDrugResponse { get; set; }
        public string NuReportRecommendation { get; set; }
        public string NuSummaryDrugGeneInteraction { get; set; }
        public int? DisplayOrder { get; set; }
    }
}

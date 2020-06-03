using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHIRGenomicsImporter.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AGSAttributeDataTypes",
                columns: table => new
                {
                    DataTypeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSAttributeDataTypes", x => x.DataTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AGSAuditLogs",
                columns: table => new
                {
                    AuditLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Details = table.Column<string>(maxLength: 1000, nullable: true),
                    ActionBy = table.Column<string>(maxLength: 255, nullable: false),
                    ActionOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSAuditLogs", x => x.AuditLogID);
                });

            migrationBuilder.CreateTable(
                name: "AGSClinics",
                columns: table => new
                {
                    ClinicID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clinic = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AGSCommunicationTemplates",
                columns: table => new
                {
                    TemplateId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TemplateType = table.Column<byte>(nullable: false),
                    TemplateContent = table.Column<string>(nullable: false),
                    ContentType = table.Column<byte>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSCommunicationTemplates", x => x.TemplateId);
                });

            migrationBuilder.CreateTable(
                name: "AGSDocumentation",
                columns: table => new
                {
                    DocumentationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: false),
                    ParentType = table.Column<byte>(nullable: false),
                    OriginalFileName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    FilePath = table.Column<string>(unicode: false, maxLength: 260, nullable: false),
                    FileName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Mimetype = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSDocumentation", x => x.DocumentationID);
                });

            migrationBuilder.CreateTable(
                name: "AGSFilterSettings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Value = table.Column<string>(nullable: true),
                    DataType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSFilterSettings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AGSInterpretationTemplates",
                columns: table => new
                {
                    TemplateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateKey = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TemplateText = table.Column<string>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSInterpretationTemplate", x => x.TemplateID);
                });

            migrationBuilder.CreateTable(
                name: "AGSLogicModules",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Version = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Path = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSLogicModules", x => x.ModuleID);
                });

            migrationBuilder.CreateTable(
                name: "AGSMappings",
                columns: table => new
                {
                    MappingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromContext = table.Column<string>(maxLength: 255, nullable: false),
                    FromID = table.Column<string>(maxLength: 255, nullable: false),
                    ToContext = table.Column<string>(maxLength: 255, nullable: false),
                    ToID = table.Column<string>(maxLength: 255, nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSMappings", x => x.MappingID);
                });

            migrationBuilder.CreateTable(
                name: "AGSNU_eMERGE_Seq",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Component_Displayed_in_Epic = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    Display_Order = table.Column<int>(nullable: true),
                    Meets_Epic_Guidelines = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Gene_SNP = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    Category = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Allowed_Values = table.Column<string>(unicode: false, maxLength: 23, nullable: true),
                    IsActive = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSNU_eMERGE_Seq", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AGSObservation_Audits",
                columns: table => new
                {
                    ObservationAuditID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservationID = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    AuditDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AuditType = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Field = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    FromValue = table.Column<string>(nullable: true),
                    ToValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSObservation_Audits", x => x.ObservationAuditID);
                });

            migrationBuilder.CreateTable(
                name: "AGSObservationGroups",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Category = table.Column<byte>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DisplayOrder = table.Column<short>(nullable: true),
                    PatientID = table.Column<int>(nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ReleasedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReleasedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CodeValue = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CodeSystem = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CodeName = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSObservationGroups", x => x.GroupID);
                });

            migrationBuilder.CreateTable(
                name: "AGSPatientCTMSData",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false),
                    MessageID = table.Column<int>(nullable: false),
                    StudyID = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    IndicationForTesting = table.Column<string>(unicode: false, maxLength: 5000, nullable: true),
                    DiseaseStatus = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    HasPreviouslyKnownMutations = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    PreviouslyKnownMutations = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSPatientCTMSData", x => new { x.PatientID, x.MessageID, x.StudyID });
                });

            migrationBuilder.CreateTable(
                name: "AGSPatients",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MRN = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Gender = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSPatients", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "AGSPGx_Mappings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gene = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    Drugs = table.Column<string>(unicode: false, maxLength: 21, nullable: true),
                    DisplayDrugsLong = table.Column<string>(unicode: false, maxLength: 53, nullable: true),
                    DisplayDrugsShort = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    CodeValue = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CodeName = table.Column<string>(unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AGSPGx_Report_Logic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gene = table.Column<string>(maxLength: 50, nullable: true),
                    Drugs = table.Column<string>(maxLength: 255, nullable: true),
                    Display_Drugs = table.Column<string>(maxLength: 255, nullable: true),
                    Diplotype = table.Column<string>(maxLength: 255, nullable: true),
                    Phenotype_Clinical_implication = table.Column<string>(maxLength: 255, nullable: true),
                    Recommendations = table.Column<string>(maxLength: 255, nullable: true),
                    Lab_Interpretation = table.Column<string>(maxLength: 2500, nullable: true),
                    Display_Diplotype = table.Column<string>(maxLength: 255, nullable: true),
                    NU_Report_Drug_Response = table.Column<string>(maxLength: 500, nullable: true),
                    NU_Report_Recommendation = table.Column<string>(maxLength: 1000, nullable: true),
                    NU_Summary_Drug_Gene_Interaction = table.Column<string>(maxLength: 255, nullable: true),
                    NU_Summary_Drug_Gene_Interaction_Printed = table.Column<string>(maxLength: 255, nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    SortOrder = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSPGx_Report_Logic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AGSPGxStage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(nullable: false),
                    MRN = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    MessageID = table.Column<int>(nullable: false),
                    DisplayDrugsLong = table.Column<string>(unicode: false, maxLength: 53, nullable: true),
                    ResultAttributeID = table.Column<int>(nullable: false),
                    AttributeID = table.Column<int>(nullable: false),
                    AttributeName = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    ParentResultAttributeID = table.Column<int>(nullable: true),
                    Drug = table.Column<string>(nullable: true),
                    Gene = table.Column<string>(nullable: true),
                    DiplotypeValue = table.Column<string>(nullable: true),
                    Logic_Gene = table.Column<string>(maxLength: 7, nullable: true),
                    Drugs = table.Column<string>(maxLength: 21, nullable: true),
                    Gene_SNP = table.Column<string>(unicode: false, maxLength: 14, nullable: true),
                    Component_Displayed_in_Epic = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    Diplotype = table.Column<string>(maxLength: 25, nullable: true),
                    Display_Diplotype = table.Column<string>(maxLength: 33, nullable: true),
                    Phenotype_Clinical_implication = table.Column<string>(maxLength: 30, nullable: true),
                    Recommendations = table.Column<string>(maxLength: 108, nullable: true),
                    Lab_Interpretation = table.Column<string>(maxLength: 2276, nullable: true),
                    NU_Report_Drug_Response = table.Column<string>(maxLength: 179, nullable: true),
                    NU_Report_Recommendation = table.Column<string>(maxLength: 560, nullable: true),
                    NU_Summary_Drug_Gene_Interaction = table.Column<string>(maxLength: 55, nullable: true),
                    Display_Order = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSPGxStage", x => new { x.ID, x.PatientID, x.MRN, x.MessageID });
                });

            migrationBuilder.CreateTable(
                name: "AGSResultMessageFileTypes",
                columns: table => new
                {
                    MessageFileTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ViewAction = table.Column<string>(maxLength: 50, nullable: false),
                    Data = table.Column<byte[]>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSResultMessageFileTypes", x => x.MessageFileTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AGSResultMessages",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(maxLength: 255, nullable: false),
                    Format = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    ReceivedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProcessedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSResultMessages", x => x.MessageID);
                });

            migrationBuilder.CreateTable(
                name: "AGSResultTypes",
                columns: table => new
                {
                    ResultTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultType = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSResultTypes", x => x.ResultTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AGSVariants",
                columns: table => new
                {
                    VariantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Context = table.Column<string>(maxLength: 50, nullable: true),
                    Type = table.Column<byte>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSVariants", x => x.VariantID);
                });

            migrationBuilder.CreateTable(
                name: "AGSAttributeTypes",
                columns: table => new
                {
                    AttributeTypeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    DataTypeID = table.Column<int>(nullable: false),
                    MaxLength = table.Column<int>(nullable: true),
                    MinLength = table.Column<int>(nullable: true),
                    JoinTable = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    JoinColumn = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ValuePosition = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSAttributeTypes", x => x.AttributeTypeID);
                    table.ForeignKey(
                        name: "FK_AGSAttributeTypes_AGSAttributeDataTypes",
                        column: x => x.DataTypeID,
                        principalTable: "AGSAttributeDataTypes",
                        principalColumn: "DataTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSDocumentation_Audits",
                columns: table => new
                {
                    ResultMessageDocumentationAuditID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentationID = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    AuditDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AuditType = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Field = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    FromValue = table.Column<string>(nullable: true),
                    ToValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSResultMessageDocumentation_Audit", x => x.ResultMessageDocumentationAuditID);
                    table.ForeignKey(
                        name: "FK_AGSDocumentation_Audits_AGSDocumentation",
                        column: x => x.DocumentationID,
                        principalTable: "AGSDocumentation",
                        principalColumn: "DocumentationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSCommunications",
                columns: table => new
                {
                    CommunicationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservationGroupID = table.Column<int>(nullable: false),
                    CommunicationType = table.Column<byte>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(maxLength: 260, nullable: true),
                    FileName = table.Column<string>(maxLength: 255, nullable: true),
                    MimeType = table.Column<string>(maxLength: 255, nullable: true),
                    SentOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    SentBy = table.Column<string>(maxLength: 255, nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: true),
                    TemplateId = table.Column<int>(nullable: true),
                    ContentData = table.Column<string>(unicode: false, nullable: true),
                    UploadedData = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSCommunications", x => x.CommunicationID);
                    table.ForeignKey(
                        name: "FK_AGSObservationGroups_AGSCommunications",
                        column: x => x.ObservationGroupID,
                        principalTable: "AGSObservationGroups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGSCommunications_AGSCommunicationTemplates",
                        column: x => x.TemplateId,
                        principalTable: "AGSCommunicationTemplates",
                        principalColumn: "TemplateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSObservations",
                columns: table => new
                {
                    ObservationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(nullable: false),
                    CodeValue = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CodeSystem = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Value = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ClinicalComments = table.Column<string>(nullable: true),
                    InternalComments = table.Column<string>(nullable: true),
                    ModuleID = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ReleasedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReleasedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    AccessionNumber = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    CodeName = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    AbnormalFlag = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSObservations", x => x.ObservationID);
                    table.ForeignKey(
                        name: "FK_AGSObservations_AGSPatients",
                        column: x => x.PatientID,
                        principalTable: "AGSPatients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSPatient_Audits",
                columns: table => new
                {
                    PatientAuditID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    AuditDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AuditType = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Field = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    FromValue = table.Column<string>(nullable: true),
                    ToValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSResultPatient_Audits", x => x.PatientAuditID);
                    table.ForeignKey(
                        name: "FK_AGSPatient_Audits_AGSPatients",
                        column: x => x.PatientID,
                        principalTable: "AGSPatients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSResultMessage_Audits",
                columns: table => new
                {
                    ResultMessageAuditID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageID = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    AuditDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AuditType = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Field = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    FromValue = table.Column<string>(nullable: true),
                    ToValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSResultMessages_Audit", x => x.ResultMessageAuditID);
                    table.ForeignKey(
                        name: "FK_AGSResultMessages_Audit_AGSResultMessages",
                        column: x => x.MessageID,
                        principalTable: "AGSResultMessages",
                        principalColumn: "MessageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSResultMessageFiles",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    OriginalFileName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    MessageFileTypeID = table.Column<int>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSResultMessageFiles", x => new { x.MessageID, x.FileName });
                    table.ForeignKey(
                        name: "FK_AGSResultMessageFiles_AGSResultMessageFileTypes",
                        column: x => x.MessageFileTypeID,
                        principalTable: "AGSResultMessageFileTypes",
                        principalColumn: "MessageFileTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGSResultMessageFiles_AGSResultMessages",
                        column: x => x.MessageID,
                        principalTable: "AGSResultMessages",
                        principalColumn: "MessageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSResultPatients",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSResultPatients", x => new { x.MessageID, x.PatientID });
                    table.ForeignKey(
                        name: "FK_AGSResultPatients_AGSResultMessages",
                        column: x => x.MessageID,
                        principalTable: "AGSResultMessages",
                        principalColumn: "MessageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGSResultPatients_AGSPatients",
                        column: x => x.PatientID,
                        principalTable: "AGSPatients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSVariantAttributes",
                columns: table => new
                {
                    VariantAttributeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariantID = table.Column<int>(nullable: false),
                    CodeSystem = table.Column<string>(maxLength: 255, nullable: false),
                    CodeName = table.Column<string>(maxLength: 255, nullable: false),
                    CodeValue = table.Column<string>(maxLength: 255, nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSVariantAttributes", x => x.VariantAttributeID);
                    table.ForeignKey(
                        name: "FK_AGSVariantAttributes_AGSVariants",
                        column: x => x.VariantID,
                        principalTable: "AGSVariants",
                        principalColumn: "VariantID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSAttributes",
                columns: table => new
                {
                    AttributeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    ParentID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    AttributeTypeID = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Status = table.Column<byte>(nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSAttributes", x => x.AttributeID);
                    table.ForeignKey(
                        name: "FK_AGSAttributes_AGSAttributeTypes",
                        column: x => x.AttributeTypeID,
                        principalTable: "AGSAttributeTypes",
                        principalColumn: "AttributeTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSObservationDetails",
                columns: table => new
                {
                    DetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservationID = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSObservationDetails", x => x.DetailID);
                    table.ForeignKey(
                        name: "FK_AGSObservationDetails_AGSObservations",
                        column: x => x.ObservationID,
                        principalTable: "AGSObservations",
                        principalColumn: "ObservationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSObservationExportHistory",
                columns: table => new
                {
                    ExportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservationID = table.Column<int>(nullable: false),
                    GroupID = table.Column<int>(nullable: true),
                    ReleasedTo = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    ReleasedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReleasedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSObservationExportHistory", x => x.ExportID);
                    table.ForeignKey(
                        name: "FK_AGSObservationExportHistory_AGSObservationGroups",
                        column: x => x.GroupID,
                        principalTable: "AGSObservationGroups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGSObservationExportHistory_AGSObservations",
                        column: x => x.ObservationID,
                        principalTable: "AGSObservations",
                        principalColumn: "ObservationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSObservationGroupMembers",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(nullable: false),
                    ObservationID = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedBy = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DisplayOrder = table.Column<short>(nullable: true),
                    CodeSystem = table.Column<string>(maxLength: 255, nullable: true),
                    CodeValue = table.Column<string>(maxLength: 255, nullable: true),
                    CodeName = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSObservationGroupMembers", x => x.MemberID);
                    table.ForeignKey(
                        name: "FK_AGSObservationGroupMembers_AGSObservationGroups",
                        column: x => x.GroupID,
                        principalTable: "AGSObservationGroups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGSObservationGroupMembers_AGSObservations",
                        column: x => x.ObservationID,
                        principalTable: "AGSObservations",
                        principalColumn: "ObservationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSResultAttributes",
                columns: table => new
                {
                    ResultAttributeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageID = table.Column<int>(nullable: false),
                    AttributeID = table.Column<int>(nullable: false),
                    AttributeName = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    ParentResultAttributeID = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Lineage = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSResultAttributes", x => x.ResultAttributeID);
                    table.ForeignKey(
                        name: "FK_AGSResultAttributes_AGSAttributes",
                        column: x => x.AttributeID,
                        principalTable: "AGSAttributes",
                        principalColumn: "AttributeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGSResultAttributes_AGSResultMessages",
                        column: x => x.MessageID,
                        principalTable: "AGSResultMessages",
                        principalColumn: "MessageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGSObservationResultAttributes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservationID = table.Column<int>(nullable: false),
                    ResultAttributeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGSObservationResultAttributes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AGSObservationResultAttributes_AGSObservations",
                        column: x => x.ObservationID,
                        principalTable: "AGSObservations",
                        principalColumn: "ObservationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGSObservationResultAttributes_AGSResultAttributes",
                        column: x => x.ResultAttributeID,
                        principalTable: "AGSResultAttributes",
                        principalColumn: "ResultAttributeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AGSAttributes_AttributeTypeID",
                table: "AGSAttributes",
                column: "AttributeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSAttributeTypes_DataTypeID",
                table: "AGSAttributeTypes",
                column: "DataTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSCommunications_ObservationGroupID",
                table: "AGSCommunications",
                column: "ObservationGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSCommunications_TemplateId",
                table: "AGSCommunications",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_AGSDocumentation_Audits_DocumentationID",
                table: "AGSDocumentation_Audits",
                column: "DocumentationID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSInterpretationTemplates_TemplateKeyAndStatus",
                table: "AGSInterpretationTemplates",
                columns: new[] { "TemplateKey", "Status" });

            migrationBuilder.CreateIndex(
                name: "IX_AGSObservationDetails_ObservationID",
                table: "AGSObservationDetails",
                column: "ObservationID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSObservationExportHistory_GroupID",
                table: "AGSObservationExportHistory",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSObservationExportHistory_ObservationID",
                table: "AGSObservationExportHistory",
                column: "ObservationID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSObservationGroupMembers_GroupID",
                table: "AGSObservationGroupMembers",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSObservationGroupMembers_ObservationID",
                table: "AGSObservationGroupMembers",
                column: "ObservationID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSObservationResultAttributes_ObservationID",
                table: "AGSObservationResultAttributes",
                column: "ObservationID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSObservationResultAttributes_ResultAttributeID",
                table: "AGSObservationResultAttributes",
                column: "ResultAttributeID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSObservations_PatientID",
                table: "AGSObservations",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSPatient_Audits_PatientID",
                table: "AGSPatient_Audits",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSResultAttributes_AttributeID",
                table: "AGSResultAttributes",
                column: "AttributeID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSResultAttributes_MessageID",
                table: "AGSResultAttributes",
                column: "MessageID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSResultMessage_Audits_MessageID",
                table: "AGSResultMessage_Audits",
                column: "MessageID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSResultMessageFiles_MessageFileTypeID",
                table: "AGSResultMessageFiles",
                column: "MessageFileTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSResultPatients_PatientID",
                table: "AGSResultPatients",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSVariantAttributes_VariantID",
                table: "AGSVariantAttributes",
                column: "VariantID");

            migrationBuilder.CreateIndex(
                name: "IX_AGSVariants_Context_Type_Value",
                table: "AGSVariants",
                columns: new[] { "Context", "Type", "Value" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGSAuditLogs");

            migrationBuilder.DropTable(
                name: "AGSClinics");

            migrationBuilder.DropTable(
                name: "AGSCommunications");

            migrationBuilder.DropTable(
                name: "AGSDocumentation_Audits");

            migrationBuilder.DropTable(
                name: "AGSFilterSettings");

            migrationBuilder.DropTable(
                name: "AGSInterpretationTemplates");

            migrationBuilder.DropTable(
                name: "AGSLogicModules");

            migrationBuilder.DropTable(
                name: "AGSMappings");

            migrationBuilder.DropTable(
                name: "AGSNU_eMERGE_Seq");

            migrationBuilder.DropTable(
                name: "AGSObservation_Audits");

            migrationBuilder.DropTable(
                name: "AGSObservationDetails");

            migrationBuilder.DropTable(
                name: "AGSObservationExportHistory");

            migrationBuilder.DropTable(
                name: "AGSObservationGroupMembers");

            migrationBuilder.DropTable(
                name: "AGSObservationResultAttributes");

            migrationBuilder.DropTable(
                name: "AGSPatient_Audits");

            migrationBuilder.DropTable(
                name: "AGSPatientCTMSData");

            migrationBuilder.DropTable(
                name: "AGSPGx_Mappings");

            migrationBuilder.DropTable(
                name: "AGSPGx_Report_Logic");

            migrationBuilder.DropTable(
                name: "AGSPGxStage");

            migrationBuilder.DropTable(
                name: "AGSResultMessage_Audits");

            migrationBuilder.DropTable(
                name: "AGSResultMessageFiles");

            migrationBuilder.DropTable(
                name: "AGSResultPatients");

            migrationBuilder.DropTable(
                name: "AGSResultTypes");

            migrationBuilder.DropTable(
                name: "AGSVariantAttributes");

            migrationBuilder.DropTable(
                name: "AGSCommunicationTemplates");

            migrationBuilder.DropTable(
                name: "AGSDocumentation");

            migrationBuilder.DropTable(
                name: "AGSObservationGroups");

            migrationBuilder.DropTable(
                name: "AGSObservations");

            migrationBuilder.DropTable(
                name: "AGSResultAttributes");

            migrationBuilder.DropTable(
                name: "AGSResultMessageFileTypes");

            migrationBuilder.DropTable(
                name: "AGSVariants");

            migrationBuilder.DropTable(
                name: "AGSPatients");

            migrationBuilder.DropTable(
                name: "AGSAttributes");

            migrationBuilder.DropTable(
                name: "AGSResultMessages");

            migrationBuilder.DropTable(
                name: "AGSAttributeTypes");

            migrationBuilder.DropTable(
                name: "AGSAttributeDataTypes");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace FHIRGenomicsImporter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"INSERT [dbo].[AGSAttributeDataTypes] ([DataTypeID], [Name]) VALUES (1, N'Generic Value')
GO
INSERT[dbo].[AGSAttributeTypes]([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES(1, N'Abstract Entity', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT[dbo].[AGSAttributeTypes]
        ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES(2, N'Haplotype Star Variant', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT[dbo].[AGSAttributeTypes]
        ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES(3, N'Diplotype Star Variant', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT[dbo].[AGSAttributeTypes]
        ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES(4, N'Allele Value', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT[dbo].[AGSAttributeTypes]
        ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES(5, N'Genotype (SNP) Value', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT[dbo].[AGSAttributeTypes]
        ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES(6, N'Value Observation', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT[dbo].[AGSAttributeTypes]
        ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES(7, N'Laboratory Sample', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT[dbo].[AGSAttributeTypes]
        ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES(8, N'Controlled Vocabulary Code', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT[dbo].[AGSAttributeTypes]
        ([AttributeTypeID], [Name], [DataTypeID], [MaxLength], [MinLength], [JoinTable], [JoinColumn], [ValuePosition]) VALUES(9, N'Form Response', 1, NULL, NULL, NULL, NULL, 1)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(1, N'Value Derivation', 0, N'', 1, CAST(N'2013-08-23T14:22:54.280' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(20, N'Sample', 0, N'Laboratory Sample', 7, CAST(N'2013-08-23T14:22:54.280' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(21, N'Unassigned', 20, N'Unassigned Attribute', 6, CAST(N'2013-08-23T14:22:54.283' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(22, N'Sample Type', 20, N'Type of Laboratory Sample', 1, CAST(N'2013-08-23T14:22:54.283' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(23, N'Signed By', 20, N'Who signed the results', 1, CAST(N'2013-08-23T14:22:54.283' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(24, N'Created On', 20, N'Sample record created on date', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(25, N'Observed On', 20, N'Sample observed on date', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(26, N'Patient ID', 20, N'Patient Id of sample', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(27, N'Status', 20, N'Status of the sample', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(28, N'Comments', 20, N'Sample Comments', 1, CAST(N'2013-08-23T14:22:54.287' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(29, N'RecievedOn', 20, N'Sample is received by the processing laboratory on date', 1, CAST(N'2013-08-23T00:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(100, N'Genetic Result', 0, N'', 1, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(101, N'CYP2C9 Result', 100, N'', 1, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(102, N'CYP2C9 Haplotype #1', 101, N'', 2, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(103, N'CYP2C9 Haplotype #2', 101, N'', 2, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(104, N'CYP2C9 Genotype', 101, N'', 3, CAST(N'2013-08-23T14:22:54.290' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(105, N'CYP2C9 Fail', 101, N'', 1, CAST(N'2013-08-23T14:22:54.293' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(106, N'VKORC1 Result', 100, N'', 1, CAST(N'2013-08-23T14:22:54.293' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(107, N'VKORC1 Allele #1', 106, N'', 4, CAST(N'2013-08-23T14:22:54.293' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(108, N'VKORC1 Allele #2', 106, N'', 4, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(109, N'VKORC1 Genotype', 106, N'', 5, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(110, N'VKORC1 Fail', 106, N'', 1, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(111, N'CYP2C19 Result', 100, N'', 1, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(112, N'CYP2C19 Haplotype #1', 111, N'', 2, CAST(N'2013-08-23T14:22:54.297' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(113, N'CYP2C19 Haplotype #2', 111, N'', 2, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(114, N'CYP2C19 Genotype', 111, N'', 3, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(115, N'CYP2C19 Fail', 111, N'', 1, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(116, N'CYP2C19 SNP', 111, N'', 1, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(117, N'rs12248560', 116, N'', 5, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(118, N'rs28399504', 116, N'', 5, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(119, N'rs41291556', 116, N'', 5, CAST(N'2013-08-23T14:22:54.300' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(120, N'SLCO1B1 Result', 100, N'', 1, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(121, N'SLCO1B1 Allele #1', 120, N'', 4, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(122, N'SLCO1B1 Allele #2', 120, N'', 4, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(123, N'SLCO1B1 Genotype', 120, N'', 5, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(124, N'SLCO1B1 Fail', 120, N'', 1, CAST(N'2013-08-23T14:22:54.303' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(125, N'rs72552267', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(126, N'rs4986893', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(127, N'rs4244285', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(128, N'rs72558186', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(129, N'rs56337013', 116, N'CYP2C19 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(130, N'CYP2C9 SNP', 101, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(131, N'rs1799853', 130, N'CYP2C9 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(132, N'rs9332131', 130, N'CYP2C9 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(133, N'rs1057910', 130, N'CYP2C9 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(134, N'rs28371686', 130, N'CYP2C9 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(135, N'VKORC1 SNP', 106, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(136, N'rs9923231', 135, N'VKORC1 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(137, N'rs7294', 135, N'VKORC1 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(138, N'rs9934438', 135, N'VKORC1 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(139, N'TPMT Result', 100, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(140, N'TPMT SNP', 139, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(141, N'rs1142345', 140, N'TPMT SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(142, N'rs1800462', 140, N'TPMT SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(143, N'CYP3A5 Result', 100, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(144, N'CYP3A5 SNP', 143, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(145, N'rs776746', 144, N'CYP3A5 SNP', 5, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(146, N'Genotype Method', 100, N'How the genotype was derived', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(147, N'Method Description', 100, N'Narrative of the method used', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(148, N'Analytic Sensitivity', 100, N'', 1, CAST(N'2014-09-02T07:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(149, N'rs4149056', 120, N'SLCO1B1 SNP', 5, CAST(N'2014-09-12T13:00:00.000' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(150, N'Institution', 20, N'The institution the results are intended for', 1, CAST(N'2015-05-11T08:54:28.820' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(151, N'Lab Identifier', 20, N'Internal identifier used by the laboratory for the sample', 1, CAST(N'2015-05-11T08:54:28.823' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(152, N'Tested On', 20, N'The date the laboratory performed the test', 1, CAST(N'2015-05-11T08:54:28.823' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(153, N'Turn Around from Date Received', 20, N'The turn around time (in days) from when the sample was received to results', 1, CAST(N'2015-05-11T08:54:28.823' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(154, N'Turn Around from Test Initiation', 20, N'The turn around time (in days) from when the test was initiated to results', 1, CAST(N'2015-05-11T08:54:28.823' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(155, N'Lab Accession', 20, N'', 1, CAST(N'2017-10-11T11:08:36.493' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(156, N'Test Indication', 20, N'', 1, CAST(N'2017-10-11T11:08:36.500' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(157, N'Overall Interpretation', 20, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(158, N'Reported variant', 20, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(159, N'Gene Region', 158, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(160, N'DNA Change', 158, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(161, N'Amino Acid Change', 158, N'', 1, CAST(N'2017-10-11T11:08:36.503' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(162, N'Gene Symbol', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(163, N'Allele State', 158, N'', 8, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(164, N'Clinical Significance', 158, N'', 8, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(165, N'Transcript ID', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(166, N'Chromosome', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(167, N'Confirmed by Sanger', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(168, N'Category Type', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(169, N'Inheritance', 158, N'', 1, CAST(N'2017-10-11T11:08:36.507' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(170, N'Interpretation Text', 158, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(171, N'Associated Disease', 158, N'', 8, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(172, N'Reference Alignment', 158, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(173, N'Genome Build', 172, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(174, N'Start Position', 172, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(175, N'Wildtype Sequence', 172, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(176, N'Variant Sequence', 172, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(177, N'Addendum', 158, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(178, N'Addendum Text', 177, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(179, N'Addendum Date', 177, N'', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(180, N'eMERGE III Participant Data', 0, N'Collection of data for each eMERGE 3 participant', 1, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(181, N'Return of Result ID', 180, N'', 9, CAST(N'2017-10-11T11:08:36.510' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(182, N'Study Status', 180, N'The current status of the participant on the study', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(183, N'Indication for Testing', 180, N'The indication for why the patient was selected to participate in eMERGE III', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(184, N'Disease Status', 180, N'The patient''s affected status of disease related to their indication for testing.', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(185, N'Has Previously Known Mutations', 180, N'Does the patient have one or more previously known mutations?', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(186, N'Previously Known Mutations', 180, N'The previously known mutations (if any)', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(187, N'Recruitment Clinic', 180, N'Where the participant was recruited from for the eMERGE III study', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(188, N'eMERGE III Options Arm', 180, N'Is the participant randomized to the study arm that selects options for return of results?', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(189, N'Option - Treatment IS Available', 180, N'Does the participant want to receive results where treatment is available?', 9, CAST(N'2017-10-11T11:08:36.513' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(190, N'Option - Treatment IS NOT Available', 180, N'Does the participant want to receive results where treatment is not available?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(191, N'Option - Dementia', 180, N'Does the participant want to receive results related to dementia?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(192, N'Option - Cancer', 180, N'Does the participant want to receive results related to cancer?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(193, N'Option - Behavior/Learning Conditions', 180, N'Does the participant want to receive results related to behavior/learning conditions?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(194, N'Option - Carrier', 180, N'Does the participant want to receive results about being a carrier?', 9, CAST(N'2017-10-11T11:08:36.517' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(195, N'Option - Uncertain Results', 180, N'Does the participant want to receive results where our knowledge is uncertain on its interpretation?', 9, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(196, N'Code Value', 0, N'', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(197, N'Code System', 0, N'', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(198, N'HGSC VIP File', 20, N'HGSC (Baylor) VIP file identifier', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(199, N'Gene Coverage Entry', 20, N'Gene coverage result', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(200, N'Gene Coverage Value', 199, N'The coverage value for the gene', 1, CAST(N'2017-10-11T11:08:36.520' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(201, N'Assay Version', 20, N'External identifier of the assay version that produced the results', 1, CAST(N'2017-10-11T11:08:36.523' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(202, N'Assay Test Code', 20, N'Identifier for the assay that produced the results', 1, CAST(N'2017-10-11T11:08:36.523' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(203, N'Collection Date', 20, N'The date the sample was collected', 1, CAST(N'2017-10-11T11:08:36.523' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(204, N'Participant Address', 180, N'The mailing address on record for the participant', 9, CAST(N'2017-10-11T11:08:36.527' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(205, N'Appointment Location', 180, N'The appointment location where the recruitment took place', 9, CAST(N'2017-10-11T11:08:36.527' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(206, N'Participant Notes', 180, N'Free-text notes collected in the process of recruiting and enrolling the participant in the study', 9, CAST(N'2017-10-11T11:08:36.530' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(207, N'CNV Analysis Failed', 20, N'Indication from the sequencing center if the CNV analysis failed', 1, CAST(N'2018-04-05T12:35:18.897' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(208, N'Variant Interpretation', 158, N'An interpretation of a variant, which is associated with a reported variant', 1, CAST(N'2018-04-05T12:35:18.897' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(209, N'Report DNA Change', 158, N'A representation of the DNA change in HGNV format', 1, CAST(N'2018-04-05T12:35:18.900' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(210, N'PGx Comments', 20, N'PGx Comments', 1, CAST(N'2019-04-10T09:31:53.130' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(211, N'PGx Result', 20, N'PGx Result', 1, CAST(N'2019-04-10T09:32:40.427' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(212, N'PGx Associated Medication', 211, N'PGx Associated Medication', 1, CAST(N'2019-04-10T09:33:56.440' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(213, N'PGx Associated Recommendation', 211, N'PGx Associated Recommendation', 1, CAST(N'2019-04-10T09:33:56.440' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(214, N'PGx Diplotype', 211, N'PGx Diplotype', 3, CAST(N'2019-04-10T09:35:16.580' AS DateTime), 1, NULL)
GO
INSERT[dbo].[AGSAttributes] ([AttributeID], [Name], [ParentID], [Description], [AttributeTypeID], [CreatedOn], [Status], [DeletedOn]) VALUES(215, N'PGx Phenotype', 211, N'PGx Phenotype', 1, CAST(N'2019-04-10T09:35:16.580' AS DateTime), 1, NULL)
GO
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

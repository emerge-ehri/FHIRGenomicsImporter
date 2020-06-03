using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FHIRGenomicsImporter.Model
{
    public partial class AgsContext : DbContext
    {
        public AgsContext()
        {
        }

        public AgsContext(DbContextOptions<AgsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AgsattributeDataTypes> AgsattributeDataTypes { get; set; }
        public virtual DbSet<AgsattributeTypes> AgsattributeTypes { get; set; }
        public virtual DbSet<Agsattributes> Agsattributes { get; set; }
        public virtual DbSet<AgsauditLogs> AgsauditLogs { get; set; }
        public virtual DbSet<Agsclinics> Agsclinics { get; set; }
        public virtual DbSet<AgscommunicationTemplates> AgscommunicationTemplates { get; set; }
        public virtual DbSet<Agscommunications> Agscommunications { get; set; }
        public virtual DbSet<Agsdocumentation> Agsdocumentation { get; set; }
        public virtual DbSet<AgsdocumentationAudits> AgsdocumentationAudits { get; set; }
        public virtual DbSet<AgsfilterSettings> AgsfilterSettings { get; set; }
        public virtual DbSet<AgsinterpretationTemplates> AgsinterpretationTemplates { get; set; }
        public virtual DbSet<AgslogicModules> AgslogicModules { get; set; }
        public virtual DbSet<Agsmappings> Agsmappings { get; set; }
        public virtual DbSet<AgsnuEMergeSeq> AgsnuEMergeSeq { get; set; }
        public virtual DbSet<AgsobservationAudits> AgsobservationAudits { get; set; }
        public virtual DbSet<AgsobservationDetails> AgsobservationDetails { get; set; }
        public virtual DbSet<AgsobservationExportHistory> AgsobservationExportHistory { get; set; }
        public virtual DbSet<AgsobservationGroupMembers> AgsobservationGroupMembers { get; set; }
        public virtual DbSet<AgsobservationGroups> AgsobservationGroups { get; set; }
        public virtual DbSet<AgsobservationResultAttributes> AgsobservationResultAttributes { get; set; }
        public virtual DbSet<Agsobservations> Agsobservations { get; set; }
        public virtual DbSet<AgspatientAudits> AgspatientAudits { get; set; }
        public virtual DbSet<AgspatientCtmsdata> AgspatientCtmsdata { get; set; }
        public virtual DbSet<Agspatients> Agspatients { get; set; }
        public virtual DbSet<AgspgxMappings> AgspgxMappings { get; set; }
        public virtual DbSet<AgspgxReportLogic> AgspgxReportLogic { get; set; }
        public virtual DbSet<AgspgxStage> AgspgxStage { get; set; }
        public virtual DbSet<AgsresultAttributes> AgsresultAttributes { get; set; }
        public virtual DbSet<AgsresultMessageAudits> AgsresultMessageAudits { get; set; }
        public virtual DbSet<AgsresultMessageFileTypes> AgsresultMessageFileTypes { get; set; }
        public virtual DbSet<AgsresultMessageFiles> AgsresultMessageFiles { get; set; }
        public virtual DbSet<AgsresultMessages> AgsresultMessages { get; set; }
        public virtual DbSet<AgsresultPatients> AgsresultPatients { get; set; }
        public virtual DbSet<AgsresultTypes> AgsresultTypes { get; set; }
        public virtual DbSet<AgsvariantAttributes> AgsvariantAttributes { get; set; }
        public virtual DbSet<Agsvariants> Agsvariants { get; set; }
        public virtual DbSet<VwCommunications> VwCommunications { get; set; }
        public virtual DbSet<VwLabResults> VwLabResults { get; set; }
        public virtual DbSet<VwObservationGroups> VwObservationGroups { get; set; }
        public virtual DbSet<VwObservationResultGenes> VwObservationResultGenes { get; set; }
        public virtual DbSet<VwObservations> VwObservations { get; set; }
        public virtual DbSet<VwParticipantAttributes> VwParticipantAttributes { get; set; }
        public virtual DbSet<VwPgxSummaryReport> VwPgxSummaryReport { get; set; }
        public virtual DbSet<VwResultGenes> VwResultGenes { get; set; }
        public virtual DbSet<VwResultSamples> VwResultSamples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost,1434;Initial Catalog=AGS;Persist Security Info=False;User Id=SA;Password=tMk%e9?FsE7=tsSz");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgsattributeDataTypes>(entity =>
            {
                entity.HasKey(e => e.DataTypeId);

                entity.ToTable("AGSAttributeDataTypes");

                entity.Property(e => e.DataTypeId)
                    .HasColumnName("DataTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgsattributeTypes>(entity =>
            {
                entity.HasKey(e => e.AttributeTypeId);

                entity.ToTable("AGSAttributeTypes");

                entity.Property(e => e.AttributeTypeId)
                    .HasColumnName("AttributeTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");

                entity.Property(e => e.JoinColumn)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JoinTable)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.DataType)
                    .WithMany(p => p.AgsattributeTypes)
                    .HasForeignKey(d => d.DataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSAttributeTypes_AGSAttributeDataTypes");
            });

            modelBuilder.Entity<Agsattributes>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("AGSAttributes");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("AttributeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeTypeId).HasColumnName("AttributeTypeID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.AttributeType)
                    .WithMany(p => p.Agsattributes)
                    .HasForeignKey(d => d.AttributeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSAttributes_AGSAttributeTypes");
            });

            modelBuilder.Entity<AgsauditLogs>(entity =>
            {
                entity.HasKey(e => e.AuditLogId);

                entity.ToTable("AGSAuditLogs");

                entity.Property(e => e.AuditLogId).HasColumnName("AuditLogID");

                entity.Property(e => e.ActionBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ActionOn).HasColumnType("datetime");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Details).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Agsclinics>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AGSClinics");

                entity.Property(e => e.Clinic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicId)
                    .HasColumnName("ClinicID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AgscommunicationTemplates>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("AGSCommunicationTemplates");

                entity.Property(e => e.TemplateId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TemplateContent).IsRequired();
            });

            modelBuilder.Entity<Agscommunications>(entity =>
            {
                entity.HasKey(e => e.CommunicationId);

                entity.ToTable("AGSCommunications");

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.ContentData).IsUnicode(false);

                entity.Property(e => e.DeletedBy).HasMaxLength(255);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FilePath).HasMaxLength(260);

                entity.Property(e => e.MimeType).HasMaxLength(255);

                entity.Property(e => e.ObservationGroupId).HasColumnName("ObservationGroupID");

                entity.Property(e => e.SentBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SentOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UploadedData).HasColumnType("image");

                entity.HasOne(d => d.ObservationGroup)
                    .WithMany(p => p.Agscommunications)
                    .HasForeignKey(d => d.ObservationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSObservationGroups_AGSCommunications");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.Agscommunications)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_AGSCommunications_AGSCommunicationTemplates");
            });

            modelBuilder.Entity<Agsdocumentation>(entity =>
            {
                entity.HasKey(e => e.DocumentationId);

                entity.ToTable("AGSDocumentation");

                entity.Property(e => e.DocumentationId).HasColumnName("DocumentationID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.Mimetype)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<AgsdocumentationAudits>(entity =>
            {
                entity.HasKey(e => e.ResultMessageDocumentationAuditId)
                    .HasName("PK_AGSResultMessageDocumentation_Audit");

                entity.ToTable("AGSDocumentation_Audits");

                entity.Property(e => e.ResultMessageDocumentationAuditId).HasColumnName("ResultMessageDocumentationAuditID");

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.AuditType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentationId).HasColumnName("DocumentationID");

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Documentation)
                    .WithMany(p => p.AgsdocumentationAudits)
                    .HasForeignKey(d => d.DocumentationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSDocumentation_Audits_AGSDocumentation");
            });

            modelBuilder.Entity<AgsfilterSettings>(entity =>
            {
                entity.ToTable("AGSFilterSettings");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgsinterpretationTemplates>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK_AGSInterpretationTemplate");

                entity.ToTable("AGSInterpretationTemplates");

                entity.HasIndex(e => new { e.TemplateKey, e.Status })
                    .HasName("IX_AGSInterpretationTemplates_TemplateKeyAndStatus");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TemplateKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateText).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgslogicModules>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("AGSLogicModules");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Agsmappings>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("AGSMappings");

                entity.Property(e => e.MappingId).HasColumnName("MappingID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromContext)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FromId)
                    .IsRequired()
                    .HasColumnName("FromID")
                    .HasMaxLength(255);

                entity.Property(e => e.ToContext)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ToId)
                    .IsRequired()
                    .HasColumnName("ToID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AgsnuEMergeSeq>(entity =>
            {
                entity.ToTable("AGSNU_eMERGE_Seq");

                entity.Property(e => e.AllowedValues)
                    .HasColumnName("Allowed_Values")
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentDisplayedInEpic)
                    .HasColumnName("Component_Displayed_in_Epic")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.GeneSnp)
                    .HasColumnName("Gene_SNP")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.MeetsEpicGuidelines)
                    .HasColumnName("Meets_Epic_Guidelines")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgsobservationAudits>(entity =>
            {
                entity.HasKey(e => e.ObservationAuditId);

                entity.ToTable("AGSObservation_Audits");

                entity.Property(e => e.ObservationAuditId).HasColumnName("ObservationAuditID");

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.AuditType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgsobservationDetails>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("AGSObservationDetails");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Details).IsRequired();

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Observation)
                    .WithMany(p => p.AgsobservationDetails)
                    .HasForeignKey(d => d.ObservationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSObservationDetails_AGSObservations");
            });

            modelBuilder.Entity<AgsobservationExportHistory>(entity =>
            {
                entity.HasKey(e => e.ExportId);

                entity.ToTable("AGSObservationExportHistory");

                entity.Property(e => e.ExportId).HasColumnName("ExportID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.ReleasedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReleasedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AgsobservationExportHistory)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_AGSObservationExportHistory_AGSObservationGroups");

                entity.HasOne(d => d.Observation)
                    .WithMany(p => p.AgsobservationExportHistory)
                    .HasForeignKey(d => d.ObservationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSObservationExportHistory_AGSObservations");
            });

            modelBuilder.Entity<AgsobservationGroupMembers>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("AGSObservationGroupMembers");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.CodeName).HasMaxLength(255);

                entity.Property(e => e.CodeSystem).HasMaxLength(255);

                entity.Property(e => e.CodeValue).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AgsobservationGroupMembers)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSObservationGroupMembers_AGSObservationGroups");

                entity.HasOne(d => d.Observation)
                    .WithMany(p => p.AgsobservationGroupMembers)
                    .HasForeignKey(d => d.ObservationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSObservationGroupMembers_AGSObservations");
            });

            modelBuilder.Entity<AgsobservationGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("AGSObservationGroups");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ReleasedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReleasedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgsobservationResultAttributes>(entity =>
            {
                entity.ToTable("AGSObservationResultAttributes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.ResultAttributeId).HasColumnName("ResultAttributeID");

                entity.HasOne(d => d.Observation)
                    .WithMany(p => p.AgsobservationResultAttributes)
                    .HasForeignKey(d => d.ObservationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSObservationResultAttributes_AGSObservations");

                entity.HasOne(d => d.ResultAttribute)
                    .WithMany(p => p.AgsobservationResultAttributes)
                    .HasForeignKey(d => d.ResultAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSObservationResultAttributes_AGSResultAttributes");
            });

            modelBuilder.Entity<Agsobservations>(entity =>
            {
                entity.HasKey(e => e.ObservationId);

                entity.ToTable("AGSObservations");

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.AbnormalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccessionNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ReleasedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReleasedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Agsobservations)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSObservations_AGSPatients");
            });

            modelBuilder.Entity<AgspatientAudits>(entity =>
            {
                entity.HasKey(e => e.PatientAuditId)
                    .HasName("PK_AGSResultPatient_Audits");

                entity.ToTable("AGSPatient_Audits");

                entity.Property(e => e.PatientAuditId).HasColumnName("PatientAuditID");

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.AuditType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AgspatientAudits)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSPatient_Audits_AGSPatients");
            });

            modelBuilder.Entity<AgspatientCtmsdata>(entity =>
            {
                entity.HasKey(e => new { e.PatientId, e.MessageId, e.StudyId });

                entity.ToTable("AGSPatientCTMSData");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.StudyId)
                    .HasColumnName("StudyID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DiseaseStatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HasPreviouslyKnownMutations)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IndicationForTesting)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PreviouslyKnownMutations)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Agspatients>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("AGSPatients");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Mrn)
                    .IsRequired()
                    .HasColumnName("MRN")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgspgxMappings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AGSPGx_Mappings");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayDrugsLong)
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayDrugsShort)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Drugs)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Gene)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AgspgxReportLogic>(entity =>
            {
                entity.ToTable("AGSPGx_Report_Logic");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Diplotype).HasMaxLength(255);

                entity.Property(e => e.DisplayDiplotype)
                    .HasColumnName("Display_Diplotype")
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayDrugs)
                    .HasColumnName("Display_Drugs")
                    .HasMaxLength(255);

                entity.Property(e => e.Drugs).HasMaxLength(255);

                entity.Property(e => e.Gene).HasMaxLength(50);

                entity.Property(e => e.LabInterpretation)
                    .HasColumnName("Lab_Interpretation")
                    .HasMaxLength(2500);

                entity.Property(e => e.NuReportDrugResponse)
                    .HasColumnName("NU_Report_Drug_Response")
                    .HasMaxLength(500);

                entity.Property(e => e.NuReportRecommendation)
                    .HasColumnName("NU_Report_Recommendation")
                    .HasMaxLength(1000);

                entity.Property(e => e.NuSummaryDrugGeneInteraction)
                    .HasColumnName("NU_Summary_Drug_Gene_Interaction")
                    .HasMaxLength(255);

                entity.Property(e => e.NuSummaryDrugGeneInteractionPrinted)
                    .HasColumnName("NU_Summary_Drug_Gene_Interaction_Printed")
                    .HasMaxLength(255);

                entity.Property(e => e.PhenotypeClinicalImplication)
                    .HasColumnName("Phenotype_Clinical_implication")
                    .HasMaxLength(255);

                entity.Property(e => e.Recommendations).HasMaxLength(255);
            });

            modelBuilder.Entity<AgspgxStage>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PatientId, e.Mrn, e.MessageId });

                entity.ToTable("AGSPGxStage");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Mrn)
                    .HasColumnName("MRN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentDisplayedInEpic)
                    .HasColumnName("Component_Displayed_in_Epic")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Diplotype).HasMaxLength(25);

                entity.Property(e => e.DisplayDiplotype)
                    .HasColumnName("Display_Diplotype")
                    .HasMaxLength(33);

                entity.Property(e => e.DisplayDrugsLong)
                    .HasMaxLength(53)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.Drugs).HasMaxLength(21);

                entity.Property(e => e.GeneSnp)
                    .HasColumnName("Gene_SNP")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.LabInterpretation)
                    .HasColumnName("Lab_Interpretation")
                    .HasMaxLength(2276);

                entity.Property(e => e.LogicGene)
                    .HasColumnName("Logic_Gene")
                    .HasMaxLength(7);

                entity.Property(e => e.NuReportDrugResponse)
                    .HasColumnName("NU_Report_Drug_Response")
                    .HasMaxLength(179);

                entity.Property(e => e.NuReportRecommendation)
                    .HasColumnName("NU_Report_Recommendation")
                    .HasMaxLength(560);

                entity.Property(e => e.NuSummaryDrugGeneInteraction)
                    .HasColumnName("NU_Summary_Drug_Gene_Interaction")
                    .HasMaxLength(55);

                entity.Property(e => e.ParentResultAttributeId).HasColumnName("ParentResultAttributeID");

                entity.Property(e => e.PhenotypeClinicalImplication)
                    .HasColumnName("Phenotype_Clinical_implication")
                    .HasMaxLength(30);

                entity.Property(e => e.Recommendations).HasMaxLength(108);

                entity.Property(e => e.ResultAttributeId).HasColumnName("ResultAttributeID");
            });

            modelBuilder.Entity<AgsresultAttributes>(entity =>
            {
                entity.HasKey(e => e.ResultAttributeId);

                entity.ToTable("AGSResultAttributes");

                entity.Property(e => e.ResultAttributeId).HasColumnName("ResultAttributeID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Lineage).IsUnicode(false);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.ParentResultAttributeId).HasColumnName("ParentResultAttributeID");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.AgsresultAttributes)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSResultAttributes_AGSAttributes");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.AgsresultAttributes)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSResultAttributes_AGSResultMessages");
            });

            modelBuilder.Entity<AgsresultMessageAudits>(entity =>
            {
                entity.HasKey(e => e.ResultMessageAuditId)
                    .HasName("PK_AGSResultMessages_Audit");

                entity.ToTable("AGSResultMessage_Audits");

                entity.Property(e => e.ResultMessageAuditId).HasColumnName("ResultMessageAuditID");

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.AuditType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.AgsresultMessageAudits)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSResultMessages_Audit_AGSResultMessages");
            });

            modelBuilder.Entity<AgsresultMessageFileTypes>(entity =>
            {
                entity.HasKey(e => e.MessageFileTypeId);

                entity.ToTable("AGSResultMessageFileTypes");

                entity.Property(e => e.MessageFileTypeId).HasColumnName("MessageFileTypeID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ViewAction)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AgsresultMessageFiles>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.FileName });

                entity.ToTable("AGSResultMessageFiles");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MessageFileTypeId).HasColumnName("MessageFileTypeID");

                entity.Property(e => e.OriginalFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MessageFileType)
                    .WithMany(p => p.AgsresultMessageFiles)
                    .HasForeignKey(d => d.MessageFileTypeId)
                    .HasConstraintName("FK_AGSResultMessageFiles_AGSResultMessageFileTypes");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.AgsresultMessageFiles)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSResultMessageFiles_AGSResultMessages");
            });

            modelBuilder.Entity<AgsresultMessages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("AGSResultMessages");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");

                entity.Property(e => e.ReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.Sender)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgsresultPatients>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.PatientId });

                entity.ToTable("AGSResultPatients");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.AgsresultPatients)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSResultPatients_AGSResultMessages");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AgsresultPatients)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSResultPatients_AGSPatients");
            });

            modelBuilder.Entity<AgsresultTypes>(entity =>
            {
                entity.HasKey(e => e.ResultTypeId);

                entity.ToTable("AGSResultTypes");

                entity.Property(e => e.ResultTypeId).HasColumnName("ResultTypeID");

                entity.Property(e => e.ResultType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgsvariantAttributes>(entity =>
            {
                entity.HasKey(e => e.VariantAttributeId);

                entity.ToTable("AGSVariantAttributes");

                entity.HasIndex(e => e.VariantId);

                entity.Property(e => e.VariantAttributeId).HasColumnName("VariantAttributeID");

                entity.Property(e => e.CodeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CodeSystem)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CodeValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.AgsvariantAttributes)
                    .HasForeignKey(d => d.VariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGSVariantAttributes_AGSVariants");
            });

            modelBuilder.Entity<Agsvariants>(entity =>
            {
                entity.HasKey(e => e.VariantId);

                entity.ToTable("AGSVariants");

                entity.HasIndex(e => new { e.Context, e.Type, e.Value });

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.Context).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<VwCommunications>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Communications");

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.DeletedBy).HasMaxLength(255);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FilePath).HasMaxLength(260);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.MimeType).HasMaxLength(255);

                entity.Property(e => e.ObservationGroupId).HasColumnName("ObservationGroupID");

                entity.Property(e => e.SentBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SentOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwLabResults>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_LabResults");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Mrn)
                    .HasColumnName("MRN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OriginalFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");

                entity.Property(e => e.ReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.Sender)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ViewAction).HasMaxLength(50);
            });

            modelBuilder.Entity<VwObservationGroups>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ObservationGroups");

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiseaseStatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.HasPreviouslyKnownMutations)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IndicationForTesting)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Mrn)
                    .IsRequired()
                    .HasColumnName("MRN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PreviouslyKnownMutations)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReleasedOn).HasColumnType("datetime");

                entity.Property(e => e.StudyId)
                    .HasColumnName("StudyID")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwObservationResultGenes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ObservationResultGenes");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.ResultAttributeId).HasColumnName("ResultAttributeID");
            });

            modelBuilder.Entity<VwObservations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Observations");

                entity.Property(e => e.AccessionNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CodeSystem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Mrn)
                    .IsRequired()
                    .HasColumnName("MRN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ReleasedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReleasedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwParticipantAttributes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ParticipantAttributes");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<VwPgxSummaryReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PGx_SummaryReport");

                entity.Property(e => e.AbnormalFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayDiplotype)
                    .HasColumnName("Display_Diplotype")
                    .HasMaxLength(33);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("groupName")
                    .HasMaxLength(255);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.NuReportDrugResponse)
                    .HasColumnName("NU_Report_Drug_Response")
                    .HasMaxLength(179);

                entity.Property(e => e.NuReportRecommendation)
                    .HasColumnName("NU_Report_Recommendation")
                    .HasMaxLength(560);

                entity.Property(e => e.NuSummaryDrugGeneInteraction)
                    .HasColumnName("NU_Summary_Drug_Gene_Interaction")
                    .HasMaxLength(55);

                entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

                entity.Property(e => e.ObservationName).HasMaxLength(255);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Recommendations).HasMaxLength(108);

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwResultGenes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ResultGenes");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.ResultAttributeId).HasColumnName("ResultAttributeID");
            });

            modelBuilder.Entity<VwResultSamples>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ResultSamples");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

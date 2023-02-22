using System;
using api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace dataswitch.Model
{
    public partial class ecsur_kfafhContext : BaseContext
    {
        public ecsur_kfafhContext(DbContextOptions<ecsur_kfafhContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admission> Admissions { get; set; }
        public virtual DbSet<AdmittedPatientsTable> AdmittedPatientsTables { get; set; }
        public virtual DbSet<AorticSurgery> AorticSurgeries { get; set; }
        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRole> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }
        public virtual DbSet<Cath> Caths { get; set; }
        public virtual DbSet<Cockpit> Cockpits { get; set; }
        public virtual DbSet<Cpb> Cpbs { get; set; }
        public virtual DbSet<Euroscore> Euroscores { get; set; }
        public virtual DbSet<EusurCabg> EusurCabgs { get; set; }
        public virtual DbSet<EusurCpb> EusurCpbs { get; set; }
        public virtual DbSet<EusurFollow> EusurFollows { get; set; }
        public virtual DbSet<EusurHistory> EusurHistories { get; set; }
        public virtual DbSet<EusurOperative> EusurOperatives { get; set; }
        public virtual DbSet<EusurPostop> EusurPostops { get; set; }
        public virtual DbSet<FinalPrint> FinalPrints { get; set; }
        public virtual DbSet<FinalPrintDischarge> FinalPrintDischarges { get; set; }
        public virtual DbSet<MechanicalValf> MechanicalValves { get; set; }
        public virtual DbSet<MinInv> MinInvs { get; set; }
        public virtual DbSet<Operative> Operatives { get; set; }
        public virtual DbSet<PatientDemographic> PatientDemographics { get; set; }
        public virtual DbSet<PatientHistory> PatientHistories { get; set; }
        public virtual DbSet<PostOp> PostOps { get; set; }
        public virtual DbSet<ProcedureInfo> ProcedureInfos { get; set; }
        public virtual DbSet<QueenDischarge> QueenDischarges { get; set; }
        public virtual DbSet<QueenSupport> QueenSupports { get; set; }
        public virtual DbSet<Readmission> Readmissions { get; set; }
        public virtual DbSet<Svr> Svrs { get; set; }
        public virtual DbSet<ValveSurgery> ValveSurgeries { get; set; }
        public virtual DbSet<VladTable> VladTables { get; set; }
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=ecsur_kfafh;Persist Security Info=False;User ID=sa;Password=example@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admission>(entity =>
            {
                entity.ToTable("admission");

                entity.Property(e => e.AdmissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("ADMISSION_ID");

                entity.Property(e => e.AceInhibitorsDischarge)
                    .HasMaxLength(50)
                    .HasColumnName("ACE_INHIBITORS_DISCHARGE");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADMISSION_DATE");

                entity.Property(e => e.BetaBlockersDischarge)
                    .HasMaxLength(50)
                    .HasColumnName("BETA_BLOCKERS_DISCHARGE");

                entity.Property(e => e.CostLink)
                    .HasMaxLength(20)
                    .HasColumnName("COST_LINK");

                entity.Property(e => e.DcMedsAspirin)
                    .HasMaxLength(50)
                    .HasColumnName("DC_MEDS_ASPIRIN");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(50)
                    .HasColumnName("diagnosis");

                entity.Property(e => e.DischargeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DISCHARGE_DATE");

                entity.Property(e => e.DischargeLocation)
                    .HasMaxLength(50)
                    .HasColumnName("DISCHARGE_LOCATION");

                entity.Property(e => e.Hosno)
                    .HasMaxLength(50)
                    .HasColumnName("HOSNO");

                entity.Property(e => e.HospState)
                    .HasMaxLength(2)
                    .HasColumnName("HOSP_STATE");

                entity.Property(e => e.HospZip)
                    .HasMaxLength(10)
                    .HasColumnName("HOSP_ZIP");

                entity.Property(e => e.Hospital).HasMaxLength(100);

                entity.Property(e => e.Insurer)
                    .HasMaxLength(30)
                    .HasColumnName("INSURER");

                entity.Property(e => e.LipidLoweringDischarge)
                    .HasMaxLength(50)
                    .HasColumnName("LIPID_LOWERING_DISCHARGE");

                entity.Property(e => e.LosAdmitDischarge).HasColumnName("LOS_ADMIT_DISCHARGE");

                entity.Property(e => e.OtherAntiplateletsDischarge)
                    .HasMaxLength(50)
                    .HasColumnName("OTHER_ANTIPLATELETS_DISCHARGE");

                entity.Property(e => e.OtherHospPerform)
                    .HasMaxLength(50)
                    .HasColumnName("OTHER_HOSP_PERFORM");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.SameDayElective)
                    .HasMaxLength(50)
                    .HasColumnName("SAME_DAY_ELECTIVE");

                entity.Property(e => e.StsLink)
                    .HasMaxLength(5)
                    .HasColumnName("STS_LINK");

                entity.Property(e => e.TransferFromFac)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSFER_FROM_FAC");
            });

            modelBuilder.Entity<AdmittedPatientsTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("admitted_patients_table");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Mrn)
                    .HasMaxLength(50)
                    .HasColumnName("MRN");

                entity.Property(e => e.Op)
                    .IsUnicode(false)
                    .HasColumnName("op");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .HasColumnName("patient_id");
            });

            modelBuilder.Entity<AorticSurgery>(entity =>
            {
                entity.HasKey(e => e.ProcedureId)
                    .HasName("PK_eusur_non_cardiac_procedures");

                entity.ToTable("aortic_surgery");

                entity.Property(e => e.ProcedureId)
                    .HasColumnName("procedure_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Aneurysm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aneurysm")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.AneurysmType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aneurysm_type")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Coarctation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coarctation")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Dissection)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dissection")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.DissectionOnset)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dissection_onset")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.DissectionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dissection_type")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Indication)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("indication")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OperativeTechnique)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operative_technique")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherCongenital)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("other_congenital")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Pathology)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pathology")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patient_id")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Range)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("range")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.StentGraftTechnique)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stent_graft_technique")
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_Applicati__40306ADC")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_Applicati__41248F15")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_Applicati__4218B34E")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Membershi__552B87C2")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMemberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__561FABFB");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__5713D034");
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_Paths__06C2E356")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__07B7078F");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_Personali__0C7BBCAC");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__0D6FE0E5");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_Personali__0F582957")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId }, "aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__114071C9");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__12349602");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Profile__6A26A4A8");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__6B1AC8E1");
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_Roles__73B00EE2")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__74A4331B");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_SchemaVer__4AADF94F");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_Users__44F51FF9")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate }, "aspnet_Users_Index2");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__45E94432");
            });

            modelBuilder.Entity<AspnetUsersInRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_UsersInRo__77809FC6");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId, "aspnet_UsersInRoles_index");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__7968E838");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__7874C3FF");
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_WebEvent___2176D992");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<Cath>(entity =>
            {
                entity.HasKey(e => e.PatientId)
                    .HasName("PK_cath_1");

                entity.ToTable("cath");

                entity.HasIndex(e => e.PatientId, "IX_cath")
                    .IsUnique();

                entity.Property(e => e.PatientId)
                    .ValueGeneratedNever()
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.AorticDisease).HasColumnName("AORTIC_DISEASE");

                entity.Property(e => e.AorticEtiology).HasColumnName("AORTIC_ETIOLOGY");

                entity.Property(e => e.AorticGradient).HasColumnName("AORTIC_GRADIENT");

                entity.Property(e => e.AorticInsufficiency).HasColumnName("AORTIC_INSUFFICIENCY");

                entity.Property(e => e.AorticStenosis)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("AORTIC_STENOSIS");

                entity.Property(e => e.CathAtSameHospital)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CATH_AT_SAME_HOSPITAL");

                entity.Property(e => e.CathDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CATH_DATE");

                entity.Property(e => e.CathDateString)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cath_date_string");

                entity.Property(e => e.CathDuringAdmission)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CATH_DURING_ADMISSION");

                entity.Property(e => e.Ci).HasColumnName("CI");

                entity.Property(e => e.Co).HasColumnName("CO");

                entity.Property(e => e.CoronariesDone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("coronaries_done");

                entity.Property(e => e.Ef).HasColumnName("EF");

                entity.Property(e => e.EfDone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ef_done");

                entity.Property(e => e.EfMethod).HasColumnName("EF_METHOD");

                entity.Property(e => e.HdpaMeanDone).HasColumnName("HDPA_MEAN_DONE");

                entity.Property(e => e.HemoData)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("HEMO_DATA");

                entity.Property(e => e.HemoDataEfDone).HasColumnName("HEMO_DATA_EF_DONE");

                entity.Property(e => e.HemoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HEMO_DATE");

                entity.Property(e => e.IntvlOr).HasColumnName("INTVL_OR");

                entity.Property(e => e.LeftMain)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("LEFT_MAIN");

                entity.Property(e => e.LvFunction).HasColumnName("LV_FUNCTION");

                entity.Property(e => e.Lvedp).HasColumnName("LVEDP");

                entity.Property(e => e.LvedpDone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("lvedp_done");

                entity.Property(e => e.MitralDisease).HasColumnName("MITRAL_DISEASE");

                entity.Property(e => e.MitralEtiology).HasColumnName("MITRAL_ETIOLOGY");

                entity.Property(e => e.MitralGradient).HasColumnName("MITRAL_GRADIENT");

                entity.Property(e => e.MitralInsufficiency).HasColumnName("MITRAL_INSUFFICIENCY");

                entity.Property(e => e.MitralStenosis)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("MITRAL_STENOSIS");

                entity.Property(e => e.NumDisCoronVess).HasColumnName("NUM_DIS_CORON_VESS");

                entity.Property(e => e.Pa1).HasColumnName("PA_1");

                entity.Property(e => e.Pa2).HasColumnName("PA_2");

                entity.Property(e => e.Pam).HasColumnName("PAM");

                entity.Property(e => e.PameanDone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pamean_done");

                entity.Property(e => e.PasysDone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pasys_done");

                entity.Property(e => e.Paw).HasColumnName("PAW");

                entity.Property(e => e.PawpDone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pawp_done");

                entity.Property(e => e.PulmonicDisease).HasColumnName("PULMONIC_DISEASE");

                entity.Property(e => e.PulmonicEtiology).HasColumnName("PULMONIC_ETIOLOGY");

                entity.Property(e => e.PulmonicGradient).HasColumnName("PULMONIC_GRADIENT");

                entity.Property(e => e.PulmonicInsufficiency).HasColumnName("PULMONIC_INSUFFICIENCY");

                entity.Property(e => e.PulmonicStenosis)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PULMONIC_STENOSIS");

                entity.Property(e => e.RightheartDone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("rightheart_done");

                entity.Property(e => e.TricuspidDisease).HasColumnName("TRICUSPID_DISEASE");

                entity.Property(e => e.TricuspidEtiology).HasColumnName("TRICUSPID_ETIOLOGY");

                entity.Property(e => e.TricuspidGradient).HasColumnName("TRICUSPID_GRADIENT");

                entity.Property(e => e.TricuspidInsufficiency).HasColumnName("TRICUSPID_INSUFFICIENCY");

                entity.Property(e => e.TricuspidStenosis)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("TRICUSPID_STENOSIS");
            });

            modelBuilder.Entity<Cockpit>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("cockpit");

                entity.HasIndex(e => e.PatientId, "IX_cockpit");

                entity.Property(e => e.PatientId)
                    .ValueGeneratedNever()
                    .HasColumnName("patient_id");

                entity.Property(e => e.Anamnese)
                    .HasColumnType("text")
                    .HasColumnName("anamnese");

                entity.Property(e => e.Angio).HasColumnType("text");

                entity.Property(e => e.ButtonString)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("button_string");

                entity.Property(e => e.CarotisSouffle)
                    .HasMaxLength(10)
                    .HasColumnName("carotis_souffle")
                    .IsFixedLength(true);

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("diagnosis");

                entity.Property(e => e.Discussion)
                    .HasColumnType("text")
                    .HasColumnName("discussion");

                entity.Property(e => e.EcgAdditional)
                    .HasMaxLength(50)
                    .HasColumnName("ecg_additional");

                entity.Property(e => e.EcgAxis).HasColumnName("ecg_axis");

                entity.Property(e => e.EcgBpm).HasColumnName("ecg_bpm");

                entity.Property(e => e.EcgCondPr).HasColumnName("ecg_cond_pr");

                entity.Property(e => e.EcgCondQrs).HasColumnName("ecg_cond_qrs");

                entity.Property(e => e.EcgCondQt).HasColumnName("ecg_cond_qt");

                entity.Property(e => e.EcgRhythm)
                    .HasMaxLength(50)
                    .HasColumnName("ecg_rhythm");

                entity.Property(e => e.Echo)
                    .HasColumnType("text")
                    .HasColumnName("echo");

                entity.Property(e => e.Extremities)
                    .HasColumnType("text")
                    .HasColumnName("extremities");

                entity.Property(e => e.HeadNeck)
                    .HasColumnType("text")
                    .HasColumnName("head_neck");

                entity.Property(e => e.LungFunction)
                    .HasColumnType("text")
                    .HasColumnName("lung_function");

                entity.Property(e => e.Onderzoek)
                    .HasColumnType("text")
                    .HasColumnName("onderzoek");

                entity.Property(e => e.PeriphPulse).HasColumnName("periph_pulse");

                entity.Property(e => e.Planning)
                    .HasColumnType("text")
                    .HasColumnName("planning");

                entity.Property(e => e.Pulse).HasColumnName("pulse");

                entity.Property(e => e.Radiology)
                    .HasColumnType("text")
                    .HasColumnName("radiology");

                entity.Property(e => e.Research)
                    .HasColumnType("text")
                    .HasColumnName("research");

                entity.Property(e => e.RrDiast).HasColumnName("rr_diast");

                entity.Property(e => e.RrSys).HasColumnName("rr_sys");

                entity.Property(e => e.StressTest)
                    .HasColumnType("text")
                    .HasColumnName("Stress_test");

                entity.Property(e => e.Todo)
                    .HasColumnType("text")
                    .HasColumnName("todo");

                entity.Property(e => e.TrCirc)
                    .HasColumnType("text")
                    .HasColumnName("tr_circ");

                entity.Property(e => e.TrDig)
                    .HasColumnType("text")
                    .HasColumnName("tr_dig");

                entity.Property(e => e.TrPulm)
                    .HasColumnType("text")
                    .HasColumnName("tr_pulm");

                entity.Property(e => e.VaricesL).HasColumnName("varices_l");

                entity.Property(e => e.VaricesR).HasColumnName("varices_r");

                entity.Property(e => e.XRay)
                    .HasColumnType("text")
                    .HasColumnName("X_Ray");

                entity.HasOne(d => d.Patient)
                    .WithOne(p => p.Cockpit)
                    .HasForeignKey<Cockpit>(d => d.PatientId)
                    .HasConstraintName("FK_cockpit_patient_demographics");
            });

            modelBuilder.Entity<Cpb>(entity =>
            {
                entity.HasKey(e => e.ProcedureId);

                entity.ToTable("cpb");

                entity.Property(e => e.ProcedureId)
                    .HasColumnName("PROCEDURE_ID")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Antiarrhythmics).HasDefaultValueSql("(null)");

                entity.Property(e => e.Bvad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BVAD")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Cardioplegia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARDIOPLEGIA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CardioplegiaBlood)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARDIOPLEGIA_BLOOD")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CardioplegiaCrystalloid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARDIOPLEGIA_CRYSTALLOID")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CardioplegiaO2Crystalloid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARDIOPLEGIA_O2_CRYSTALLOID")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CardioplegiaTempCold)
                    .HasColumnName("CARDIOPLEGIA_TEMP_COLD")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CardioplegiaTempWarm)
                    .HasColumnName("CARDIOPLEGIA_TEMP_WARM")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Cardioversion)
                    .HasColumnName("CARDIOVERSION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CrossClampTime)
                    .HasColumnName("CROSS_CLAMP_TIME")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Iabp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IABP")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.IabpInd)
                    .HasColumnName("IABP_IND")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.IabpOptions)
                    .HasColumnName("IABP_OPTIONS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.InfusionDoseCont)
                    .HasColumnName("INFUSION_DOSE_CONT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.InfusionDoseInt)
                    .HasColumnName("INFUSION_DOSE_INT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.InfusionModeAnte)
                    .HasColumnName("INFUSION_MODE_ANTE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.InfusionModeRetro)
                    .HasColumnName("INFUSION_MODE_RETRO")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Inotropes)
                    .HasColumnName("INOTROPES")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.LowestCoreTemp)
                    .HasColumnName("LOWEST_CORE_TEMP")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Lvad)
                    .HasColumnName("LVAD")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PacingAtrial)
                    .HasColumnName("PACING_ATRIAL")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PacingHarv)
                    .HasColumnName("PACING_HARV")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PacingVentricular)
                    .HasColumnName("PACING_VENTRICULAR")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PatientId)
                    .HasColumnName("PATIENT_ID")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PerfusionTime)
                    .HasColumnName("PERFUSION_TIME")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Rvad)
                    .HasColumnName("RVAD")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.SkinIncisionStartTime)
                    .HasColumnName("SKIN_INCISION_START_TIME")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.SkinIncisionStopTime)
                    .HasColumnName("SKIN_INCISION_STOP_TIME")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Tah)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TAH")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Vad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VAD")
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Euroscore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("euroscore");

                entity.Property(e => e.AddScore)
                    .HasMaxLength(50)
                    .HasColumnName("add_score");

                entity.Property(e => e.LogScore)
                    .HasMaxLength(50)
                    .HasColumnName("log_score");

                entity.Property(e => e.ProcedureId).HasColumnName("procedure_id");
            });

            modelBuilder.Entity<EusurCabg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("eusur_cabg");

                entity.Property(e => e.Angle01)
                    .HasMaxLength(50)
                    .HasColumnName("ANGLE01");

                entity.Property(e => e.Angle02)
                    .HasMaxLength(50)
                    .HasColumnName("ANGLE02");

                entity.Property(e => e.Angle03)
                    .HasMaxLength(50)
                    .HasColumnName("ANGLE03");

                entity.Property(e => e.Angle04)
                    .HasMaxLength(50)
                    .HasColumnName("ANGLE04");

                entity.Property(e => e.Angle05)
                    .HasMaxLength(50)
                    .HasColumnName("ANGLE05");

                entity.Property(e => e.Angle06)
                    .HasMaxLength(50)
                    .HasColumnName("ANGLE06");

                entity.Property(e => e.Art01)
                    .HasMaxLength(50)
                    .HasColumnName("art01");

                entity.Property(e => e.Art02)
                    .HasMaxLength(50)
                    .HasColumnName("art02");

                entity.Property(e => e.Art03)
                    .HasMaxLength(50)
                    .HasColumnName("art03");

                entity.Property(e => e.Art04)
                    .HasMaxLength(50)
                    .HasColumnName("art04");

                entity.Property(e => e.Art05)
                    .HasMaxLength(50)
                    .HasColumnName("art05");

                entity.Property(e => e.Art06)
                    .HasMaxLength(50)
                    .HasColumnName("art06");

                entity.Property(e => e.B1Conduit).HasColumnName("B1_CONDUIT");

                entity.Property(e => e.B1Donor).HasColumnName("B1_DONOR");

                entity.Property(e => e.B1Locproc).HasColumnName("B1_LOCPROC");

                entity.Property(e => e.B1Site).HasColumnName("B1_SITE");

                entity.Property(e => e.B1Sitepa).HasColumnName("B1_SITEPA");

                entity.Property(e => e.B1TypeDa).HasColumnName("B1_TYPE_DA");

                entity.Property(e => e.B2Conduit).HasColumnName("B2_CONDUIT");

                entity.Property(e => e.B2Donor).HasColumnName("B2_DONOR");

                entity.Property(e => e.B2Locproc).HasColumnName("B2_LOCPROC");

                entity.Property(e => e.B2Site).HasColumnName("B2_SITE");

                entity.Property(e => e.B2Sitepa).HasColumnName("B2_SITEPA");

                entity.Property(e => e.B2TypeDa).HasColumnName("B2_TYPE_DA");

                entity.Property(e => e.B3Conduit).HasColumnName("B3_CONDUIT");

                entity.Property(e => e.B3Donor).HasColumnName("B3_DONOR");

                entity.Property(e => e.B3Locproc).HasColumnName("B3_LOCPROC");

                entity.Property(e => e.B3Site).HasColumnName("B3_SITE");

                entity.Property(e => e.B3Sitepa).HasColumnName("B3_SITEPA");

                entity.Property(e => e.B3TypeDa).HasColumnName("B3_TYPE_DA");

                entity.Property(e => e.B4Conduit).HasColumnName("B4_CONDUIT");

                entity.Property(e => e.B4Donor).HasColumnName("B4_DONOR");

                entity.Property(e => e.B4Locproc).HasColumnName("B4_LOCPROC");

                entity.Property(e => e.B4Site).HasColumnName("B4_SITE");

                entity.Property(e => e.B4Sitepa).HasColumnName("B4_SITEPA");

                entity.Property(e => e.B4TypeDa).HasColumnName("B4_TYPE_DA");

                entity.Property(e => e.B5Conduit).HasColumnName("B5_CONDUIT");

                entity.Property(e => e.B5Donor).HasColumnName("B5_DONOR");

                entity.Property(e => e.B5Locproc).HasColumnName("B5_LOCPROC");

                entity.Property(e => e.B5Site).HasColumnName("B5_SITE");

                entity.Property(e => e.B5Sitepa).HasColumnName("B5_SITEPA");

                entity.Property(e => e.B5TypeDa).HasColumnName("B5_TYPE_DA");

                entity.Property(e => e.B6Conduit).HasColumnName("B6_CONDUIT");

                entity.Property(e => e.B6Donor).HasColumnName("B6_DONOR");

                entity.Property(e => e.B6Locproc).HasColumnName("B6_LOCPROC");

                entity.Property(e => e.B6Site).HasColumnName("B6_SITE");

                entity.Property(e => e.B6Sitepa).HasColumnName("B6_SITEPA");

                entity.Property(e => e.B6TypeDa).HasColumnName("B6_TYPE_DA");

                entity.Property(e => e.Cab).HasColumnName("CAB");

                entity.Property(e => e.Course)
                    .HasMaxLength(50)
                    .HasColumnName("course");

                entity.Property(e => e.Diam01)
                    .HasMaxLength(50)
                    .HasColumnName("DIAM01");

                entity.Property(e => e.Diam02)
                    .HasMaxLength(50)
                    .HasColumnName("DIAM02");

                entity.Property(e => e.Diam03)
                    .HasMaxLength(50)
                    .HasColumnName("DIAM03");

                entity.Property(e => e.Diam04)
                    .HasMaxLength(50)
                    .HasColumnName("DIAM04");

                entity.Property(e => e.Diam05)
                    .HasMaxLength(50)
                    .HasColumnName("DIAM05");

                entity.Property(e => e.Diam06)
                    .HasMaxLength(50)
                    .HasColumnName("DIAM06");

                entity.Property(e => e.Leg)
                    .HasMaxLength(50)
                    .HasColumnName("leg");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.ProcedureId).HasColumnName("PROCEDURE_ID");

                entity.Property(e => e.Q01).HasMaxLength(50);

                entity.Property(e => e.Q02).HasMaxLength(50);

                entity.Property(e => e.Q03).HasMaxLength(50);

                entity.Property(e => e.Q04).HasMaxLength(50);

                entity.Property(e => e.Q05).HasMaxLength(50);

                entity.Property(e => e.Q06).HasMaxLength(50);

                entity.Property(e => e.TachtigSwitch).HasColumnName("tachtig_switch");

                entity.Property(e => e.UnplannedCab).HasColumnName("UNPLANNED_CAB");
            });

            modelBuilder.Entity<EusurCpb>(entity =>
            {
                entity.HasKey(e => e.ProcedureId);

                entity.ToTable("eusur_cpb");

                entity.Property(e => e.ProcedureId)
                    .HasColumnName("PROCEDURE_ID")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.A1).HasColumnName("a1");

                entity.Property(e => e.A2).HasColumnName("a2");

                entity.Property(e => e.A3).HasColumnName("a3");

                entity.Property(e => e.A4).HasColumnName("a4");

                entity.Property(e => e.AcpCirc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acp_circ");

                entity.Property(e => e.AoOccl).HasColumnName("aoOCCL");

                entity.Property(e => e.BloodPerfusion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("blood_perfusion");

                entity.Property(e => e.CardiacSupport)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cardiac_support");

                entity.Property(e => e.CardioplTemp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cardiopl_temp");

                entity.Property(e => e.CardioplTiming)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cardiopl_timing");

                entity.Property(e => e.ClampStartHr).HasColumnName("clamp_start_hr");

                entity.Property(e => e.ClampStartMin).HasColumnName("clamp_start_min");

                entity.Property(e => e.ClampStopHr).HasColumnName("clamp_stop_hr");

                entity.Property(e => e.ClampStopMin).HasColumnName("clamp_stop_min");

                entity.Property(e => e.CnsProtect)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cns_protect");

                entity.Property(e => e.CnsTime1).HasColumnName("cns_time_1");

                entity.Property(e => e.CnsTime2).HasColumnName("cns_time_2");

                entity.Property(e => e.CnsTime3).HasColumnName("cns_time_3");

                entity.Property(e => e.CpbStartHr).HasColumnName("cpb_start_hr");

                entity.Property(e => e.CpbStartMin).HasColumnName("cpb_start_min");

                entity.Property(e => e.CpbStopHr).HasColumnName("cpb_stop_hr");

                entity.Property(e => e.CpbStopMin).HasColumnName("cpb_stop_min");

                entity.Property(e => e.CpbUsed).HasColumnName("cpb_used");

                entity.Property(e => e.DeepHypo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deep_hypo");

                entity.Property(e => e.DeepHypoRcp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deep_hypo_rcp");

                entity.Property(e => e.IabpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IABP_DATE");

                entity.Property(e => e.LongIsch).HasColumnName("long_isch");

                entity.Property(e => e.Myoplasty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("myoplasty");

                entity.Property(e => e.NonCmprotect)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nonCMProtect");

                entity.Property(e => e.NonCmprotectType).HasColumnName("nonCMProtect_type");

                entity.Property(e => e.OpcabAttempt).HasColumnName("opcab_attempt");

                entity.Property(e => e.OtherCardiacSupport)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("other_cardiac_support");

                entity.Property(e => e.OtherCnsProtect)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("other_cns_protect");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.V1).HasColumnName("v1");

                entity.Property(e => e.V2).HasColumnName("v2");

                entity.Property(e => e.V3).HasColumnName("v3");

                entity.Property(e => e.V4).HasColumnName("v4");
            });

            modelBuilder.Entity<EusurFollow>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("eusur_follow");

                entity.Property(e => e.PatientId)
                    .HasColumnName("PATIENT_ID")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CauseDeath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAUSE_DEATH");

                entity.Property(e => e.CcsClass).HasColumnName("CCS_CLASS");

                entity.Property(e => e.DateSeen)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_SEEN");

                entity.Property(e => e.DateSeenString)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("date_seen_string");

                entity.Property(e => e.LateDead)
                    .HasColumnType("datetime")
                    .HasColumnName("LATE_DEAD");

                entity.Property(e => e.LateDeadString)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("late_dead_string");

                entity.Property(e => e.LateMortality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LATE_MORTALITY");

                entity.Property(e => e.NyhaClass).HasColumnName("NYHA_CLASS");
            });

            modelBuilder.Entity<EusurHistory>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("eusur_history");

                entity.Property(e => e.PatientId)
                    .ValueGeneratedNever()
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.Asthma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASTHMA");

                entity.Property(e => e.Bloodgroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BLOODGROUP");

                entity.Property(e => e.BronchoUse)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BRONCHO_USE");

                entity.Property(e => e.CarotidPercentage).HasColumnName("CAROTID_PERCENTAGE");

                entity.Property(e => e.CerebrovascularDisease)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CEREBROVASCULAR_DISEASE");

                entity.Property(e => e.CervascDisType).HasColumnName("CERVASC_DIS_TYPE");

                entity.Property(e => e.Chf).HasColumnName("CHF");

                entity.Property(e => e.Copd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COPD");

                entity.Property(e => e.CopdSeverity).HasColumnName("COPD_SEVERITY");

                entity.Property(e => e.CvaMonths).HasColumnName("CVA_MONTHS");

                entity.Property(e => e.CvaWeeks).HasColumnName("CVA_WEEKS");

                entity.Property(e => e.DyspneaNyha).HasColumnName("DYSPNEA_NYHA");

                entity.Property(e => e.FailedIntervention)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAILED_INTERVENTION");

                entity.Property(e => e.FailedInterventionTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAILED_INTERVENTION_TIME");

                entity.Property(e => e.LastCreatinine).HasColumnName("LAST_CREATININE");

                entity.Property(e => e.LastPtt).HasColumnName("LAST_PTT");

                entity.Property(e => e.LastSodium).HasColumnName("LAST_SODIUM");

                entity.Property(e => e.LiverDisease)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIVER_DISEASE");

                entity.Property(e => e.NumberPrevMi).HasColumnName("NUMBER_PREV_MI");

                entity.Property(e => e.OtherCentralNeuro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_CENTRAL_NEURO");

                entity.Property(e => e.OtherNoncardiacType).HasColumnName("OTHER_NONCARDIAC_TYPE");

                entity.Property(e => e.OtherPeriphNeuro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_PERIPH_NEURO");

                entity.Property(e => e.PreopIabp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREOP_IABP");

                entity.Property(e => e.PreopInotropes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREOP_INOTROPES");

                entity.Property(e => e.PreopPm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREOP_PM");

                entity.Property(e => e.PreopPmType).HasColumnName("PREOP_PM_TYPE");

                entity.Property(e => e.PreopVentilated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREOP_VENTILATED");

                entity.Property(e => e.PrevMiDays).HasColumnName("PREV_MI_DAYS");

                entity.Property(e => e.PrevMiHours).HasColumnName("PREV_MI_HOURS");

                entity.Property(e => e.PreviousCard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREVIOUS_CARD");

                entity.Property(e => e.PreviousCs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREVIOUS_CS");

                entity.Property(e => e.RenalFailureType).HasColumnName("RENAL_FAILURE_TYPE");

                entity.Property(e => e.Rhesus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RHESUS");

                entity.Property(e => e.SteroidUse)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STEROID_USE");

                entity.Property(e => e.SymptomStatus).HasColumnName("SYMPTOM_STATUS");

                entity.Property(e => e.TiaMonths).HasColumnName("TIA_MONTHS");

                entity.Property(e => e.TiaWeeks).HasColumnName("TIA_WEEKS");
            });

            modelBuilder.Entity<EusurOperative>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("eusur_operative");

                entity.Property(e => e.Anaesthesist)
                    .HasMaxLength(50)
                    .HasColumnName("anaesthesist");

                entity.Property(e => e.FreeText)
                    .HasColumnType("ntext")
                    .HasColumnName("free_text");

                entity.Property(e => e.Nurse1)
                    .HasMaxLength(50)
                    .HasColumnName("nurse_1");

                entity.Property(e => e.Nurse2)
                    .HasMaxLength(50)
                    .HasColumnName("nurse_2");

                entity.Property(e => e.Perfusionist)
                    .HasMaxLength(50)
                    .HasColumnName("perfusionist");

                entity.Property(e => e.ProcedureId).HasColumnName("Procedure_id");

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.SkinIncisionStartHr).HasColumnName("Skin_incision_start_hr");

                entity.Property(e => e.SkinIncisionStartMin).HasColumnName("Skin_incision_start_min");

                entity.Property(e => e.SkinIncisionStopHr).HasColumnName("Skin_incision_stop_hr");

                entity.Property(e => e.SkinIncisionStopMin).HasColumnName("Skin_incision_stop_min");

                entity.Property(e => e.StatusEl)
                    .HasMaxLength(5)
                    .HasColumnName("status_el");

                entity.Property(e => e.StatusEm)
                    .HasMaxLength(5)
                    .HasColumnName("status_em");

                entity.Property(e => e.StatusSalvage)
                    .HasMaxLength(5)
                    .HasColumnName("status_salvage");

                entity.Property(e => e.StatusUr)
                    .HasMaxLength(5)
                    .HasColumnName("status_ur");

                entity.Property(e => e.SurgeryBeforeNextWorkingDay)
                    .HasMaxLength(50)
                    .HasColumnName("Surgery_before_next_working_day");

                entity.Property(e => e.TotalTime).HasColumnName("Total_time");
            });

            modelBuilder.Entity<EusurPostop>(entity =>
            {
                entity.HasKey(e => e.ProcedureId);

                entity.ToTable("eusur_postop");

                entity.Property(e => e.ProcedureId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROCEDURE_ID");

                entity.Property(e => e.ActivitiesDischarge)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("activities_discharge");

                entity.Property(e => e.Arr1Hr).HasColumnName("ARR_1_HR");

                entity.Property(e => e.Arr1Min).HasColumnName("ARR_1_MIN");

                entity.Property(e => e.ArrTimeHr).HasColumnName("ARR_TIME_HR");

                entity.Property(e => e.ArrTimeMin).HasColumnName("ARR_TIME_MIN");

                entity.Property(e => e.Arrival1Date)
                    .HasColumnType("datetime")
                    .HasColumnName("ARRIVAL_1_DATE");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ARRIVAL_DATE");

                entity.Property(e => e.Arrythmia)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("arrythmia");

                entity.Property(e => e.AutologousBlood)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Autologous_Blood");

                entity.Property(e => e.BloodProducts)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Blood_Products");

                entity.Property(e => e.Dis1Hr).HasColumnName("DIS_1_HR");

                entity.Property(e => e.Dis1Min).HasColumnName("DIS_1_MIN");

                entity.Property(e => e.Discharge1Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DISCHARGE_1_DATE");

                entity.Property(e => e.DischargeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DISCHARGE_DATE");

                entity.Property(e => e.DischargeTimeHr).HasColumnName("DISCHARGE_TIME_HR");

                entity.Property(e => e.DischargeTimeMin).HasColumnName("DISCHARGE_TIME_MIN");

                entity.Property(e => e.Ext1Hr).HasColumnName("EXT_1_HR");

                entity.Property(e => e.Ext1Min).HasColumnName("EXT_1_MIN");

                entity.Property(e => e.ExtTimeHr).HasColumnName("EXT_TIME_HR");

                entity.Property(e => e.ExtTimeMin).HasColumnName("EXT_TIME_MIN");

                entity.Property(e => e.Extubation1Date)
                    .HasColumnType("datetime")
                    .HasColumnName("EXTUBATION_1_DATE");

                entity.Property(e => e.ExtubationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXTUBATION_DATE");

                entity.Property(e => e.Ffp).HasColumnName("FFP");

                entity.Property(e => e.GiChole)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("gi_chole");

                entity.Property(e => e.GiHemorrhage)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("gi_hemorrhage");

                entity.Property(e => e.GiIleus)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("gi_ileus");

                entity.Property(e => e.GiMesenteric)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("gi_mesenteric");

                entity.Property(e => e.HighestCreatinine)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("highest_creatinine");

                entity.Property(e => e.Iabp)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("iabp");

                entity.Property(e => e.IcuStay1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ICU_Stay_1");

                entity.Property(e => e.IcuStay2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ICU_Stay_2");

                entity.Property(e => e.IcuStay3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ICU_Stay_3");

                entity.Property(e => e.Inotropes)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("inotropes");

                entity.Property(e => e.Lowcardiacoutput)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("lowcardiacoutput");

                entity.Property(e => e.MortalityDateString)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mortality_date_string");

                entity.Property(e => e.OtherCauseDeath)
                    .HasColumnType("text")
                    .HasColumnName("other_cause_death");

                entity.Property(e => e.OverledenNaDezeOperatie).HasColumnName("overleden_na_deze_operatie");

                entity.Property(e => e.Paraplegie)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("paraplegie");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.Pc).HasColumnName("PC");

                entity.Property(e => e.PermanentPm)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("permanent_pm");

                entity.Property(e => e.Readmitted)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("readmitted");

                entity.Property(e => e.Reintubated)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("reintubated");

                entity.Property(e => e.ReintubationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REINTUBATION_DATE");

                entity.Property(e => e.ReintubationHr).HasColumnName("REINTUBATION_HR");

                entity.Property(e => e.ReintubationMin).HasColumnName("REINTUBATION_MIN");

                entity.Property(e => e.ReopResuture)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("reop_resuture");

                entity.Property(e => e.ReopSternalDehis)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("reop_sternal_dehis");

                entity.Property(e => e.SentTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sent_to");

                entity.Property(e => e.SternalDehis)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("sternal_dehis");

                entity.Property(e => e.Svt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("svt");

                entity.Property(e => e.Tv)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("tv");

                entity.Property(e => e.Vads)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("vads");

                entity.Property(e => e.VentStay1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Vent_Stay_1");

                entity.Property(e => e.VentStay2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Vent_Stay_2");

                entity.Property(e => e.VentStay3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Vent_Stay_3");

                entity.Property(e => e.WhenUsed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("When_Used");
            });

            modelBuilder.Entity<FinalPrint>(entity =>
            {
                entity.HasKey(e => e.ProcedureId);

                entity.ToTable("final_print");

                entity.Property(e => e.ProcedureId)
                    .ValueGeneratedNever()
                    .HasColumnName("procedure_id");

                entity.Property(e => e.Regel1).HasColumnName("regel_1");

                entity.Property(e => e.Regel10).HasColumnName("regel_10");

                entity.Property(e => e.Regel11).HasColumnName("regel_11");

                entity.Property(e => e.Regel12).HasColumnName("regel_12");

                entity.Property(e => e.Regel13).HasColumnName("regel_13");

                entity.Property(e => e.Regel14).HasColumnName("regel_14");

                entity.Property(e => e.Regel15).HasColumnName("regel_15");

                entity.Property(e => e.Regel16).HasColumnName("regel_16");

                entity.Property(e => e.Regel17).HasColumnName("regel_17");

                entity.Property(e => e.Regel18).HasColumnName("regel_18");

                entity.Property(e => e.Regel19).HasColumnName("regel_19");

                entity.Property(e => e.Regel2).HasColumnName("regel_2");

                entity.Property(e => e.Regel20).HasColumnName("regel_20");

                entity.Property(e => e.Regel3).HasColumnName("regel_3");

                entity.Property(e => e.Regel4).HasColumnName("regel_4");

                entity.Property(e => e.Regel5).HasColumnName("regel_5");

                entity.Property(e => e.Regel6).HasColumnName("regel_6");

                entity.Property(e => e.Regel7).HasColumnName("regel_7");

                entity.Property(e => e.Regel8).HasColumnName("regel_8");

                entity.Property(e => e.Regel9).HasColumnName("regel_9");

                entity.HasOne(d => d.Procedure)
                    .WithOne(p => p.FinalPrint)
                    .HasForeignKey<FinalPrint>(d => d.ProcedureId)
                    .HasConstraintName("FK_final_print_final_print");
            });

            modelBuilder.Entity<FinalPrintDischarge>(entity =>
            {
                entity.HasKey(e => e.AdmissionId);

                entity.ToTable("final_print_discharge");

                entity.Property(e => e.AdmissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("admission_id");

                entity.Property(e => e.Regel1).HasColumnName("regel_1");

                entity.Property(e => e.Regel10).HasColumnName("regel_10");

                entity.Property(e => e.Regel11).HasColumnName("regel_11");

                entity.Property(e => e.Regel12).HasColumnName("regel_12");

                entity.Property(e => e.Regel13).HasColumnName("regel_13");

                entity.Property(e => e.Regel14).HasColumnName("regel_14");

                entity.Property(e => e.Regel2).HasColumnName("regel_2");

                entity.Property(e => e.Regel3).HasColumnName("regel_3");

                entity.Property(e => e.Regel4).HasColumnName("regel_4");

                entity.Property(e => e.Regel5).HasColumnName("regel_5");

                entity.Property(e => e.Regel6).HasColumnName("regel_6");

                entity.Property(e => e.Regel7).HasColumnName("regel_7");

                entity.Property(e => e.Regel8).HasColumnName("regel_8");

                entity.Property(e => e.Regel9).HasColumnName("regel_9");

                entity.HasOne(d => d.Admission)
                    .WithOne(p => p.FinalPrintDischarge)
                    .HasForeignKey<FinalPrintDischarge>(d => d.AdmissionId)
                    .HasConstraintName("FK_final_print_discharge_admission");
            });

            modelBuilder.Entity<MechanicalValf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mechanical_valves");

                entity.Property(e => e.UkCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UK_Code");

                entity.Property(e => e.ValveId).HasColumnName("Valve_id");
            });

            modelBuilder.Entity<MinInv>(entity =>
            {
                entity.HasKey(e => e.ProcedureId)
                    .HasName("PK__min_inv__4A23E96A");

                entity.ToTable("min_inv");

                entity.Property(e => e.ProcedureId)
                    .HasColumnName("PROCEDURE_ID")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.AcuteFlow).HasColumnName("ACUTE_FLOW");

                entity.Property(e => e.AcuteFlowDetails).HasColumnName("ACUTE_FLOW_DETAILS");

                entity.Property(e => e.AlTime).HasColumnName("AL_TIME");

                entity.Property(e => e.ConversionDetails).HasColumnName("CONVERSION_DETAILS");

                entity.Property(e => e.ConversionToStandard).HasColumnName("CONVERSION_TO_STANDARD");

                entity.Property(e => e.CxTime).HasColumnName("CX_TIME");

                entity.Property(e => e.LadTime).HasColumnName("LAD_TIME");

                entity.Property(e => e.LimaHarvest).HasColumnName("LIMA_HARVEST");

                entity.Property(e => e.NumberOfIncisions).HasColumnName("NUMBER_OF_INCISIONS");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.PrimaryIncision).HasColumnName("PRIMARY_INCISION");

                entity.Property(e => e.PrimaryIncisionDetails).HasColumnName("PRIMARY_INCISION_DETAILS");

                entity.Property(e => e.RcaTime).HasColumnName("RCA_TIME");

                entity.Property(e => e.Robot).HasColumnName("ROBOT");

                entity.Property(e => e.RobotAortic).HasColumnName("ROBOT_AORTIC");

                entity.Property(e => e.RobotCabg).HasColumnName("ROBOT_CABG");

                entity.Property(e => e.RobotMitral).HasColumnName("ROBOT_MITRAL");

                entity.Property(e => e.RobotPulmonary).HasColumnName("ROBOT_PULMONARY");

                entity.Property(e => e.RobotTricuspid).HasColumnName("ROBOT_TRICUSPID");

                entity.Property(e => e.Shunt).HasColumnName("SHUNT");

                entity.Property(e => e.Strategy).HasColumnName("STRATEGY");

                entity.Property(e => e.Suture).HasColumnName("SUTURE");

                entity.Property(e => e.Vessel).HasColumnName("VESSEL");
            });

            modelBuilder.Entity<Operative>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operative");

                entity.Property(e => e.AorticOcclusion).HasColumnName("AORTIC_OCCLUSION");

                entity.Property(e => e.AssNo2)
                    .HasMaxLength(50)
                    .HasColumnName("ass_no_2");

                entity.Property(e => e.AssistantSurgeon)
                    .HasMaxLength(50)
                    .HasColumnName("ASSISTANT_SURGEON");

                entity.Property(e => e.CannulationMethod).HasColumnName("CANNULATION_METHOD");

                entity.Property(e => e.CardiopulmonaryBypass).HasColumnName("CARDIOPULMONARY_BYPASS");

                entity.Property(e => e.ClassificationAsa).HasColumnName("CLASSIFICATION_ASA");

                entity.Property(e => e.ConversionToCpb).HasColumnName("CONVERSION_TO_CPB");

                entity.Property(e => e.ConversionToStandardIncision)
                    .HasMaxLength(11)
                    .HasColumnName("CONVERSION_TO_STANDARD_INCISION");

                entity.Property(e => e.FdStatus)
                    .HasMaxLength(11)
                    .HasColumnName("fd_STATUS");

                entity.Property(e => e.FlowCheck).HasColumnName("FLOW_CHECK");

                entity.Property(e => e.ImaHarvestTech).HasColumnName("IMA_HARVEST_TECH");

                entity.Property(e => e.IndCon).HasColumnName("IND_CON");

                entity.Property(e => e.IntracoronaryShunt).HasColumnName("INTRACORONARY_SHUNT");

                entity.Property(e => e.IschemicTimeCfx)
                    .HasMaxLength(3)
                    .HasColumnName("ISCHEMIC_TIME_CFX");

                entity.Property(e => e.IschemicTimeLad)
                    .HasMaxLength(3)
                    .HasColumnName("ISCHEMIC_TIME_LAD");

                entity.Property(e => e.IschemicTimeRca)
                    .HasMaxLength(3)
                    .HasColumnName("ISCHEMIC_TIME_RCA");

                entity.Property(e => e.MinimallyInvasiveProcedure).HasColumnName("MINIMALLY_INVASIVE_PROCEDURE");

                entity.Property(e => e.OpCategory).HasColumnName("OP_CATEGORY");

                entity.Property(e => e.OtherCard)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARD");

                entity.Property(e => e.OtherCardiacAicd)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_AICD");

                entity.Property(e => e.OtherCardiacAsd)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_ASD");

                entity.Property(e => e.OtherCardiacBatista)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_BATISTA");

                entity.Property(e => e.OtherCardiacCongenital)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_CONGENITAL");

                entity.Property(e => e.OtherCardiacLaser)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_LASER");

                entity.Property(e => e.OtherCardiacLva)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_LVA");

                entity.Property(e => e.OtherCardiacOther)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_OTHER");

                entity.Property(e => e.OtherCardiacPacemaker)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_PACEMAKER");

                entity.Property(e => e.OtherCardiacTrauma)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_TRAUMA");

                entity.Property(e => e.OtherCardiacTx)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_TX");

                entity.Property(e => e.OtherCardiacVsd)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_CARDIAC_VSD");

                entity.Property(e => e.OtherNoncard)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARD");

                entity.Property(e => e.OtherNoncardiacAbd)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARDIAC_ABD");

                entity.Property(e => e.OtherNoncardiacAorticAneurysm)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARDIAC_AORTIC_ANEURYSM");

                entity.Property(e => e.OtherNoncardiacArch)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARDIAC_ARCH");

                entity.Property(e => e.OtherNoncardiacAsc)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARDIAC_ASC");

                entity.Property(e => e.OtherNoncardiacCarotidEndarterectomy)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARDIAC_CAROTID_ENDARTERECTOMY");

                entity.Property(e => e.OtherNoncardiacDesc)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARDIAC_DESC");

                entity.Property(e => e.OtherNoncardiacThor)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARDIAC_THOR");

                entity.Property(e => e.OtherNoncardiacThoracic)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARDIAC_THORACIC");

                entity.Property(e => e.OtherNoncardiacVascular)
                    .HasMaxLength(11)
                    .HasColumnName("OTHER_NONCARDIAC_VASCULAR");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.PredRiskOfMortality).HasColumnName("PRED_RISK_OF_MORTALITY");

                entity.Property(e => e.PredictedDeepSternalWondInfx).HasColumnName("PREDICTED_DEEP_STERNAL_WOND_INFX");

                entity.Property(e => e.PredictedLongLenStay).HasColumnName("PREDICTED_LONG_LEN_STAY");

                entity.Property(e => e.PredictedMorbidityOrMortality).HasColumnName("PREDICTED_MORBIDITY_OR_MORTALITY");

                entity.Property(e => e.PredictedPermanentStroke).HasColumnName("PREDICTED_PERMANENT_STROKE");

                entity.Property(e => e.PredictedProlongedVentilation).HasColumnName("PREDICTED_PROLONGED_VENTILATION");

                entity.Property(e => e.PredictedRenalFailure).HasColumnName("PREDICTED_RENAL_FAILURE");

                entity.Property(e => e.PredictedReoperation).HasColumnName("PREDICTED_REOPERATION");

                entity.Property(e => e.PredictedShortLenStay).HasColumnName("PREDICTED_SHORT_LEN_STAY");

                entity.Property(e => e.PrimIndMinInvas).HasColumnName("PRIM_IND_MIN_INVAS");

                entity.Property(e => e.PrimaryIncision).HasColumnName("PRIMARY_INCISION");

                entity.Property(e => e.ProcedureId).HasColumnName("PROCEDURE_ID");

                entity.Property(e => e.ReopReason).HasColumnName("REOP_REASON");

                entity.Property(e => e.Resident)
                    .HasMaxLength(50)
                    .HasColumnName("RESIDENT");

                entity.Property(e => e.ResponsibleForProc)
                    .HasMaxLength(11)
                    .HasColumnName("RESPONSIBLE_FOR_PROC");

                entity.Property(e => e.StatusEmergent).HasColumnName("STATUS_EMERGENT");

                entity.Property(e => e.StatusUrgent).HasColumnName("STATUS_URGENT");

                entity.Property(e => e.SurgVentricularRestoration)
                    .HasMaxLength(11)
                    .HasColumnName("SURG_VENTRICULAR_RESTORATION");

                entity.Property(e => e.SurgeonGroup)
                    .HasMaxLength(50)
                    .HasColumnName("SURGEON_GROUP");

                entity.Property(e => e.SurgeonName)
                    .HasMaxLength(50)
                    .HasColumnName("SURGEON_NAME");

                entity.Property(e => e.SutureTechnique).HasColumnName("SUTURE_TECHNIQUE");

                entity.Property(e => e.TotalIncisionNumber).HasColumnName("TOTAL_INCISION_NUMBER");

                entity.Property(e => e.VesselStabilization).HasColumnName("VESSEL_STABILIZATION");
            });

            modelBuilder.Entity<PatientDemographic>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("patient_demographics");

                entity.Property(e => e.PatientId)
                    .ValueGeneratedNever()
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS1");

                entity.Property(e => e.BirthCountry).HasColumnName("BIRTH_COUNTRY");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("CITY");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.DobString)
                    .HasMaxLength(50)
                    .HasColumnName("DOB_STRING");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(4)
                    .HasColumnName("GENDER");

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.MedRecNumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("MED_REC_NUMBER");

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(50)
                    .HasColumnName("MIDDLE_INITIAL");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILE_PHONE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Race).HasColumnName("RACE");

                entity.Property(e => e.Ssno)
                    .HasMaxLength(50)
                    .HasColumnName("SSNO");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("STATE");

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .HasColumnName("ZIP");
            });

            modelBuilder.Entity<PatientHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("patient_history");

                entity.Property(e => e.CookieString)
                    .HasMaxLength(20)
                    .HasColumnName("cookie_String");

                entity.Property(e => e.CsAngina)
                    .HasMaxLength(50)
                    .HasColumnName("CS_ANGINA");

                entity.Property(e => e.CsAnginaType).HasColumnName("CS_ANGINA_TYPE");

                entity.Property(e => e.CsAnginaUnstabType)
                    .HasMaxLength(50)
                    .HasColumnName("CS_ANGINA_UNSTAB_TYPE");

                entity.Property(e => e.CsArrAcute)
                    .HasMaxLength(50)
                    .HasColumnName("CS_ARR_ACUTE");

                entity.Property(e => e.CsArrAtrialFib)
                    .HasMaxLength(50)
                    .HasColumnName("CS_ARR_ATRIAL_FIB");

                entity.Property(e => e.CsArrAvBlock)
                    .HasMaxLength(50)
                    .HasColumnName("CS_ARR_AV_BLOCK");

                entity.Property(e => e.CsArrChb)
                    .HasMaxLength(50)
                    .HasColumnName("CS_ARR_CHB");

                entity.Property(e => e.CsArrChronic)
                    .HasMaxLength(50)
                    .HasColumnName("CS_ARR_CHRONIC");

                entity.Property(e => e.CsArrVent)
                    .HasMaxLength(50)
                    .HasColumnName("CS_ARR_VENT");

                entity.Property(e => e.CsArrhythmia)
                    .HasMaxLength(50)
                    .HasColumnName("CS_ARRHYTHMIA");

                entity.Property(e => e.CsArrhythmiaType).HasColumnName("CS_ARRHYTHMIA_TYPE");

                entity.Property(e => e.CsCardioShockType).HasColumnName("CS_CARDIO_SHOCK_TYPE");

                entity.Property(e => e.CsCardiogenicShock)
                    .HasMaxLength(50)
                    .HasColumnName("CS_CARDIOGENIC_SHOCK");

                entity.Property(e => e.CsCardiomegaly)
                    .HasMaxLength(50)
                    .HasColumnName("CS_CARDIOMEGALY");

                entity.Property(e => e.CsChf)
                    .HasMaxLength(50)
                    .HasColumnName("CS_CHF");

                entity.Property(e => e.CsClassCcs)
                    .HasMaxLength(50)
                    .HasColumnName("CS_CLASS_CCS");

                entity.Property(e => e.CsClassificationNyha).HasColumnName("CS_CLASSIFICATION_NYHA");

                entity.Property(e => e.CsMi)
                    .HasMaxLength(50)
                    .HasColumnName("CS_MI");

                entity.Property(e => e.CsMiType).HasColumnName("CS_MI_TYPE");

                entity.Property(e => e.CsMiWhen)
                    .HasMaxLength(50)
                    .HasColumnName("CS_MI_WHEN");

                entity.Property(e => e.CsResuscitation)
                    .HasMaxLength(50)
                    .HasColumnName("CS_RESUSCITATION");

                entity.Property(e => e.CvCab)
                    .HasMaxLength(50)
                    .HasColumnName("CV_CAB");

                entity.Property(e => e.CvDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CV_DATE");

                entity.Property(e => e.CvIntervention).HasColumnName("CV_INTERVENTION");

                entity.Property(e => e.CvInvasiveCabg)
                    .HasMaxLength(50)
                    .HasColumnName("CV_INVASIVE_CABG");

                entity.Property(e => e.CvInvasiveValve)
                    .HasMaxLength(50)
                    .HasColumnName("CV_INVASIVE_VALVE");

                entity.Property(e => e.CvInvasiveValveA)
                    .HasMaxLength(50)
                    .HasColumnName("CV_INVASIVE_VALVE_A");

                entity.Property(e => e.CvInvasiveValveM)
                    .HasMaxLength(50)
                    .HasColumnName("CV_INVASIVE_VALVE_M");

                entity.Property(e => e.CvInvasiveValveP)
                    .HasMaxLength(50)
                    .HasColumnName("CV_INVASIVE_VALVE_P");

                entity.Property(e => e.CvInvasiveValveT)
                    .HasMaxLength(50)
                    .HasColumnName("CV_INVASIVE_VALVE_T");

                entity.Property(e => e.CvNonsurg)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG");

                entity.Property(e => e.CvNonsurgBalloon)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG_BALLOON");

                entity.Property(e => e.CvNonsurgBalloonA)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG_BALLOON_A");

                entity.Property(e => e.CvNonsurgBalloonM)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG_BALLOON_M");

                entity.Property(e => e.CvNonsurgBalloonP)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG_BALLOON_P");

                entity.Property(e => e.CvNonsurgBalloonT)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG_BALLOON_T");

                entity.Property(e => e.CvNonsurgLaser)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG_LASER");

                entity.Property(e => e.CvNonsurgPtca)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG_PTCA");

                entity.Property(e => e.CvNonsurgStent)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG_STENT");

                entity.Property(e => e.CvNonsurgThrombolysis)
                    .HasMaxLength(50)
                    .HasColumnName("CV_NONSURG_THROMBOLYSIS");

                entity.Property(e => e.CvOpsWithBypass)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OPS_WITH_BYPASS");

                entity.Property(e => e.CvOpsWithoutBypass)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OPS_WITHOUT_BYPASS");

                entity.Property(e => e.CvOtherCardiac)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC");

                entity.Property(e => e.CvOtherCardiacAicd)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_AICD");

                entity.Property(e => e.CvOtherCardiacAsd)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_ASD");

                entity.Property(e => e.CvOtherCardiacBatista)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_BATISTA");

                entity.Property(e => e.CvOtherCardiacCongenital)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_CONGENITAL");

                entity.Property(e => e.CvOtherCardiacLva)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_LVA");

                entity.Property(e => e.CvOtherCardiacOther)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_OTHER");

                entity.Property(e => e.CvOtherCardiacPacemaker)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_PACEMAKER");

                entity.Property(e => e.CvOtherCardiacTrauma)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_TRAUMA");

                entity.Property(e => e.CvOtherCardiacTx)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_TX");

                entity.Property(e => e.CvOtherCardiacVsd)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_CARDIAC_VSD");

                entity.Property(e => e.CvOtherNoncardiac)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC");

                entity.Property(e => e.CvOtherNoncardiacAbd)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC_ABD");

                entity.Property(e => e.CvOtherNoncardiacAneurysm)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC_ANEURYSM");

                entity.Property(e => e.CvOtherNoncardiacArch)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC_ARCH");

                entity.Property(e => e.CvOtherNoncardiacAsc)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC_ASC");

                entity.Property(e => e.CvOtherNoncardiacDesc)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC_DESC");

                entity.Property(e => e.CvOtherNoncardiacEndart)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC_ENDART");

                entity.Property(e => e.CvOtherNoncardiacOtherThoracic)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC_OTHER_THORACIC");

                entity.Property(e => e.CvOtherNoncardiacOtherVasc)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC_OTHER_VASC");

                entity.Property(e => e.CvOtherNoncardiacThor)
                    .HasMaxLength(50)
                    .HasColumnName("CV_OTHER_NONCARDIAC_THOR");

                entity.Property(e => e.CvPreopMeds).HasColumnName("CV_PREOP_MEDS");

                entity.Property(e => e.CvPreopMedsAce).HasColumnName("CV_PREOP_MEDS_ACE");

                entity.Property(e => e.CvPreopMedsAntiarrhythmics).HasColumnName("CV_PREOP_MEDS_ANTIARRHYTHMICS");

                entity.Property(e => e.CvPreopMedsAnticoagulants).HasColumnName("CV_PREOP_MEDS_ANTICOAGULANTS");

                entity.Property(e => e.CvPreopMedsAntiplatelets).HasColumnName("CV_PREOP_MEDS_ANTIPLATELETS");

                entity.Property(e => e.CvPreopMedsAspirin).HasColumnName("CV_PREOP_MEDS_ASPIRIN");

                entity.Property(e => e.CvPreopMedsBeta).HasColumnName("CV_PREOP_MEDS_BETA");

                entity.Property(e => e.CvPreopMedsCa).HasColumnName("CV_PREOP_MEDS_CA");

                entity.Property(e => e.CvPreopMedsDigitalis).HasColumnName("CV_PREOP_MEDS_DIGITALIS");

                entity.Property(e => e.CvPreopMedsDiuretics).HasColumnName("CV_PREOP_MEDS_DIURETICS");

                entity.Property(e => e.CvPreopMedsInotropes).HasColumnName("CV_PREOP_MEDS_INOTROPES");

                entity.Property(e => e.CvPreopMedsNitratesIv).HasColumnName("CV_PREOP_MEDS_NITRATES_IV");

                entity.Property(e => e.CvPreopMedsNitratesPo).HasColumnName("CV_PREOP_MEDS_NITRATES_PO");

                entity.Property(e => e.CvPreopMedsSteroids).HasColumnName("CV_PREOP_MEDS_STEROIDS");

                entity.Property(e => e.CvPreviousInterval)
                    .HasMaxLength(50)
                    .HasColumnName("CV_PREVIOUS_INTERVAL");

                entity.Property(e => e.CvPtcaAther)
                    .HasMaxLength(50)
                    .HasColumnName("CV_PTCA_ATHER");

                entity.Property(e => e.CvPtcaInterval).HasColumnName("CV_PTCA_INTERVAL");

                entity.Property(e => e.CvPtcaNumPriorPtca)
                    .HasMaxLength(50)
                    .HasColumnName("CV_PTCA_NUM_PRIOR_PTCA");

                entity.Property(e => e.CvPtcaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("CV_PTCA_STATUS");

                entity.Property(e => e.CvPtcaSurgSameAdm)
                    .HasMaxLength(50)
                    .HasColumnName("CV_PTCA_SURG_SAME_ADM");

                entity.Property(e => e.CvThrombo)
                    .HasMaxLength(50)
                    .HasColumnName("CV_THROMBO");

                entity.Property(e => e.CvThromboAgent).HasColumnName("CV_THROMBO_AGENT");

                entity.Property(e => e.CvThromboInterval)
                    .HasMaxLength(50)
                    .HasColumnName("CV_THROMBO_INTERVAL");

                entity.Property(e => e.CvValve)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE");

                entity.Property(e => e.CvValveRepair)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPAIR");

                entity.Property(e => e.CvValveRepairA)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPAIR_A");

                entity.Property(e => e.CvValveRepairM)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPAIR_M");

                entity.Property(e => e.CvValveRepairP)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPAIR_P");

                entity.Property(e => e.CvValveRepairT)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPAIR_T");

                entity.Property(e => e.CvValveReplace)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPLACE");

                entity.Property(e => e.CvValveReplaceA)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPLACE_A");

                entity.Property(e => e.CvValveReplaceM)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPLACE_M");

                entity.Property(e => e.CvValveReplaceP)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPLACE_P");

                entity.Property(e => e.CvValveReplaceT)
                    .HasMaxLength(50)
                    .HasColumnName("CV_VALVE_REPLACE_T");

                entity.Property(e => e.DxAortic)
                    .HasMaxLength(50)
                    .HasColumnName("DX_AORTIC");

                entity.Property(e => e.DxCad)
                    .HasMaxLength(50)
                    .HasColumnName("DX_CAD");

                entity.Property(e => e.DxCongenital)
                    .HasMaxLength(50)
                    .HasColumnName("DX_CONGENITAL");

                entity.Property(e => e.DxIhss)
                    .HasMaxLength(50)
                    .HasColumnName("DX_IHSS");

                entity.Property(e => e.DxLva)
                    .HasMaxLength(50)
                    .HasColumnName("DX_LVA");

                entity.Property(e => e.DxValvular)
                    .HasMaxLength(50)
                    .HasColumnName("DX_VALVULAR");

                entity.Property(e => e.Height).HasColumnName("HEIGHT");

                entity.Property(e => e.HeightUnits)
                    .HasMaxLength(3)
                    .HasColumnName("HEIGHT_UNITS");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.RfCad)
                    .HasMaxLength(50)
                    .HasColumnName("RF_CAD");

                entity.Property(e => e.RfCerebrovascularAccident)
                    .HasMaxLength(50)
                    .HasColumnName("RF_CEREBROVASCULAR_ACCIDENT");

                entity.Property(e => e.RfCerebrovascularAccidentTime).HasColumnName("RF_CEREBROVASCULAR_ACCIDENT_TIME");

                entity.Property(e => e.RfChronicLungDis)
                    .HasMaxLength(50)
                    .HasColumnName("RF_CHRONIC_LUNG_DIS");

                entity.Property(e => e.RfCvd)
                    .HasMaxLength(50)
                    .HasColumnName("RF_CVD");

                entity.Property(e => e.RfCvdType).HasColumnName("RF_CVD_TYPE");

                entity.Property(e => e.RfDiabetes)
                    .HasMaxLength(50)
                    .HasColumnName("RF_DIABETES");

                entity.Property(e => e.RfDiabetesControl)
                    .HasMaxLength(50)
                    .HasColumnName("RF_DIABETES_CONTROL");

                entity.Property(e => e.RfHypercholesterolemia)
                    .HasMaxLength(50)
                    .HasColumnName("RF_HYPERCHOLESTEROLEMIA");

                entity.Property(e => e.RfHypercholesterolemiaLevel).HasColumnName("RF_HYPERCHOLESTEROLEMIA_LEVEL");

                entity.Property(e => e.RfHypertension)
                    .HasMaxLength(50)
                    .HasColumnName("RF_HYPERTENSION");

                entity.Property(e => e.RfImmunosuppressiveRx)
                    .HasMaxLength(50)
                    .HasColumnName("RF_IMMUNOSUPPRESSIVE_RX");

                entity.Property(e => e.RfInfectiousEndocardType).HasColumnName("RF_INFECTIOUS_ENDOCARD_TYPE");

                entity.Property(e => e.RfInfectiousEndocarditis)
                    .HasMaxLength(50)
                    .HasColumnName("RF_INFECTIOUS_ENDOCARDITIS");

                entity.Property(e => e.RfMorbidObesity)
                    .HasMaxLength(50)
                    .HasColumnName("RF_MORBID_OBESITY");

                entity.Property(e => e.RfPvd)
                    .HasMaxLength(50)
                    .HasColumnName("RF_PVD");

                entity.Property(e => e.RfRenalFailLast)
                    .HasMaxLength(50)
                    .HasColumnName("RF_RENAL_FAIL_LAST");

                entity.Property(e => e.RfRenalFailure)
                    .HasMaxLength(50)
                    .HasColumnName("RF_RENAL_FAILURE");

                entity.Property(e => e.RfRenalFailureDialysis)
                    .HasMaxLength(50)
                    .HasColumnName("RF_RENAL_FAILURE_DIALYSIS");

                entity.Property(e => e.RfSmoking)
                    .HasMaxLength(50)
                    .HasColumnName("RF_SMOKING");

                entity.Property(e => e.RfSmokingCurrent)
                    .HasMaxLength(50)
                    .HasColumnName("RF_SMOKING_CURRENT");

                entity.Property(e => e.RfSmokingCurrentPk).HasColumnName("RF_SMOKING_CURRENT_PK");

                entity.Property(e => e.RiskFactors)
                    .HasMaxLength(50)
                    .HasColumnName("RISK_FACTORS");

                entity.Property(e => e.RiskfactorString)
                    .HasMaxLength(30)
                    .HasColumnName("riskfactor_String");

                entity.Property(e => e.StentIntvl).HasColumnName("STENT_INTVL");

                entity.Property(e => e.SurgDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SURG_DATE");

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");

                entity.Property(e => e.WeightUnits)
                    .HasMaxLength(3)
                    .HasColumnName("WEIGHT_UNITS");
            });

            modelBuilder.Entity<PostOp>(entity =>
            {
                entity.HasKey(e => e.ProcedureId);

                entity.ToTable("post_op");

                entity.Property(e => e.ProcedureId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROCEDURE_ID");

                entity.Property(e => e.AcuteLimbIschemia)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ACUTE_LIMB_ISCHEMIA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.AdditionalHoursVentilated)
                    .HasColumnName("ADDITIONAL_HOURS_VENTILATED")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.AdditionalIcuHours)
                    .HasColumnName("ADDITIONAL_ICU_HOURS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.AnticoagulantComplication)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ANTICOAGULANT_COMPLICATION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.AorticDissection)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("AORTIC_DISSECTION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Ards)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ARDS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.BbpCryo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("BBP_CRYO")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.BbpFfp)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("BBP_FFP")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.BbpPlatelets)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("BBP_PLATELETS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.BbpRbc)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("BBP_RBC")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.BbpUsed)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("BBP_USED")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Complications)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("COMPLICATIONS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ContinuousComa)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CONTINUOUS_COMA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Delirium)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("DELIRIUM")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.DialysisRequired)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("DIALYSIS_REQUIRED")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Drg)
                    .HasColumnName("DRG")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.GraftStenOcc)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("GRAFT_STEN_OCC")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.IabpSite)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IABP_SITE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.IliacFemDissection)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ILIAC_FEM_DISSECTION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Infection)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INFECTION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.InitialHoursVentilated)
                    .HasColumnName("INITIAL_HOURS_VENTILATED")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.InitialIcuHours)
                    .HasColumnName("INITIAL_ICU_HOURS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Leg)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("LEG")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.MortPrimCause)
                    .HasColumnName("MORT_PRIM_CAUSE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Mortality)
                    .HasColumnName("MORTALITY")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Mortality30Day)
                    .HasColumnName("MORTALITY_30_DAY")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.MortalityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MORTALITY_DATE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.MortalityDiscStatus)
                    .HasColumnName("MORTALITY_DISC_STATUS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.MortalityLocation)
                    .HasColumnName("MORTALITY_LOCATION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Neurologic)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("NEUROLOGIC")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.NonstructuralDeterioration)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("NONSTRUCTURAL_DETERIORATION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Operative)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OPERATIVE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OperativeMortality)
                    .HasColumnName("OPERATIVE_MORTALITY")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherAfib)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_AFIB")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherAnticoagulantComplication)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_ANTICOAGULANT_COMPLICATION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherCardiacArrest)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_CARDIAC_ARREST")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherComps)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_COMPS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherGiComplications)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_GI_COMPLICATIONS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherHeartBlock)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_HEART_BLOCK")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherMultiSystemFailure)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_MULTI_SYSTEM_FAILURE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherOther)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_OTHER")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherTamponade)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_TAMPONADE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PatientId)
                    .HasColumnName("PATIENT_ID")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PerioperativeMi)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PERIOPERATIVE_MI")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Pneumonia)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PNEUMONIA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PortSite)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PORT_SITE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PostOpAngio)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("POST_OP_ANGIO")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PostOpDbStress)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("POST_OP_DB_STRESS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PostOpDoppler)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("POST_OP_DOPPLER")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PostOpOther)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("POST_OP_OTHER")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PostOpOtherDesc)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("POST_OP_OTHER_DESC")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PostOpStudy)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("POST_OP_STUDY")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PostOpTee)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("POST_OP_TEE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PostOpVentHrs)
                    .HasColumnName("POST_OP_VENT_HRS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ProsthValveEndocarditis)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PROSTH_VALVE_ENDOCARDITIS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PtcaAtherectomy)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PTCA_ATHERECTOMY")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PtcaBalloon)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PTCA_BALLOON")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PtcaLaser)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PTCA_LASER")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PtcaStent)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PTCA_STENT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Pulmonary)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PULMONARY")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PulmonaryEdema)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PULMONARY_EDEMA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PulmonaryEmbolism)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PULMONARY_EMBOLISM")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Readmission)
                    .HasColumnName("READMISSION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ReadmissionToIcu)
                    .HasColumnName("READMISSION_TO_ICU")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ReadmitReasonHarv)
                    .HasColumnName("READMIT_REASON_HARV")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ReintubatedDuringStay)
                    .HasColumnName("REINTUBATED_DURING_STAY")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Renal)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RENAL")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.RenalFailure)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RENAL_FAILURE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ReopBleeding)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REOP_BLEEDING")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ReopGraftOcclusion)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REOP_GRAFT_OCCLUSION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ReopOtherCardiac)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REOP_OTHER_CARDIAC")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ReopOtherNoncardiac)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REOP_OTHER_NONCARDIAC")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ReopValveDysfunction)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REOP_VALVE_DYSFUNCTION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Septicemia)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SEPTICEMIA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.SternumDeep)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("STERNUM_DEEP")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.SternumSuperficial)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("STERNUM_SUPERFICIAL")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.StrokePermanent)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("STROKE_PERMANENT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.StrokeTransient)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("STROKE_TRANSIENT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.StructuralDeterioration)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("STRUCTURAL_DETERIORATION")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Thoracotomy)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("THORACOTOMY")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Thromboembolism)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("THROMBOEMBOLISM")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.TotalHrsIcu)
                    .HasColumnName("TOTAL_HRS_ICU")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Uti)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("UTI")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ValveThrombus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VALVE_THROMBUS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Valvular)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("VALVULAR")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Vascular)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("VASCULAR")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.VentilatorDays)
                    .HasColumnName("VENTILATOR_DAYS")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.VentilatorProlonged)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("VENTILATOR_PROLONGED")
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<ProcedureInfo>(entity =>
            {
                entity.HasKey(e => e.ProcedureId);

                entity.ToTable("procedure_info");

                entity.Property(e => e.ProcedureId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROCEDURE_ID");

                entity.Property(e => e.AdmissionId).HasColumnName("Admission_id");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.Cardiologist)
                    .HasMaxLength(50)
                    .HasColumnName("CARDIOLOGIST");

                entity.Property(e => e.CardiologistCity)
                    .HasMaxLength(25)
                    .HasColumnName("CARDIOLOGIST_CITY");

                entity.Property(e => e.CardiologistPhone)
                    .HasMaxLength(14)
                    .HasColumnName("CARDIOLOGIST_PHONE");

                entity.Property(e => e.FdType)
                    .HasColumnType("ntext")
                    .HasColumnName("fd_TYPE");

                entity.Property(e => e.LosAdmitSurg).HasColumnName("LOS_ADMIT_SURG");

                entity.Property(e => e.LosSurgDischarge).HasColumnName("LOS_SURG_DISCHARGE");

                entity.Property(e => e.ParticipantId)
                    .HasMaxLength(8)
                    .HasColumnName("PARTICIPANT_ID");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.Physician)
                    .HasMaxLength(50)
                    .HasColumnName("PHYSICIAN");

                entity.Property(e => e.PhysicianCity)
                    .HasMaxLength(25)
                    .HasColumnName("PHYSICIAN_CITY");

                entity.Property(e => e.RecComp).HasColumnName("REC_COMP");

                entity.Property(e => e.RecordId).HasColumnName("record_id");

                entity.Property(e => e.Refcardno).HasColumnName("refcardno");

                entity.Property(e => e.ReferringPhysicianPhone)
                    .HasMaxLength(14)
                    .HasColumnName("REFERRING_PHYSICIAN_PHONE");

                entity.Property(e => e.Sent).HasColumnName("SENT");

                entity.Property(e => e.StsDataVersion)
                    .HasMaxLength(8)
                    .HasColumnName("STS_DATA_VERSION");

                entity.Property(e => e.SurgeryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SURGERY_DATE");

                entity.Property(e => e.SurgeryDateString)
                    .HasMaxLength(50)
                    .HasColumnName("SURGERY_DATE_STRING");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<QueenDischarge>(entity =>
            {
                entity.HasKey(e => e.AdmissionId)
                    .HasName("PK__queen_discharge__766C7FFC");

                entity.ToTable("queen_discharge");

                entity.Property(e => e.AdmissionId)
                    .HasColumnName("Admission_id")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Adddis01)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDDIS01");

                entity.Property(e => e.Adddis02)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDDIS02");

                entity.Property(e => e.Adddis03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDDIS03");

                entity.Property(e => e.Adddis04)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDDIS04");

                entity.Property(e => e.Adddis05)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDDIS05");

                entity.Property(e => e.Adddis06)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDDIS06");

                entity.Property(e => e.Admisdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADMISDATE");

                entity.Property(e => e.Anticodate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANTICODATE");

                entity.Property(e => e.Attending)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATTENDING");

                entity.Property(e => e.Carddate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARDDATE");

                entity.Property(e => e.ChkAce).HasColumnName("chkACE");

                entity.Property(e => e.ChkAnti).HasColumnName("chkAnti");

                entity.Property(e => e.ChkAspirin).HasColumnName("chkAspirin");

                entity.Property(e => e.ChkBeta).HasColumnName("chkBeta");

                entity.Property(e => e.ChkLipid).HasColumnName("chkLipid");

                entity.Property(e => e.Clinicald1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLINICALD1");

                entity.Property(e => e.Clinicaldb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLINICALDB");

                entity.Property(e => e.Comment01)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COMMENT01");

                entity.Property(e => e.Comment02)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COMMENT02");

                entity.Property(e => e.Course)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("COURSE");

                entity.Property(e => e.Cvtdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CVTDATE");

                entity.Property(e => e.Dischdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISCHDATE");

                entity.Property(e => e.Dm01)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM01");

                entity.Property(e => e.Dm02)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM02");

                entity.Property(e => e.Dm03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM03");

                entity.Property(e => e.Dm04)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM04");

                entity.Property(e => e.Dm05)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM05");

                entity.Property(e => e.Dm06)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM06");

                entity.Property(e => e.Dm07)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM07");

                entity.Property(e => e.Dm08)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM08");

                entity.Property(e => e.Dm09)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM09");

                entity.Property(e => e.Dm10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM10");

                entity.Property(e => e.Dm11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM11");

                entity.Property(e => e.Dm12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM12");

                entity.Property(e => e.Dm13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM13");

                entity.Property(e => e.Dm14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM14");

                entity.Property(e => e.Dm15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DM15");

                entity.Property(e => e.Ecg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ECG");

                entity.Property(e => e.EcgExt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ecg_ext");

                entity.Property(e => e.Echo)
                    .IsUnicode(false)
                    .HasColumnName("ECHO");

                entity.Property(e => e.Finaldiag)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FINALDIAG");

                entity.Property(e => e.Lab01)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB01");

                entity.Property(e => e.Lab02)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB02");

                entity.Property(e => e.Lab03)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB03");

                entity.Property(e => e.Lab04)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB04");

                entity.Property(e => e.Lab05)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB05");

                entity.Property(e => e.Lab06)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB06");

                entity.Property(e => e.Lab07)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB07");

                entity.Property(e => e.Lab08)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB08");

                entity.Property(e => e.Lab09)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB09");

                entity.Property(e => e.Lab10)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB10");

                entity.Property(e => e.Lab11)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB11");

                entity.Property(e => e.Lab12)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB12");

                entity.Property(e => e.Lab13)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB13");

                entity.Property(e => e.Lab14)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB14");

                entity.Property(e => e.Lab15)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB15");

                entity.Property(e => e.Lab16)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB16");

                entity.Property(e => e.Lab17)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB17");

                entity.Property(e => e.Lab18)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB18");

                entity.Property(e => e.Lab19)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB19");

                entity.Property(e => e.Lab20)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB20");

                entity.Property(e => e.Lab21)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB21");

                entity.Property(e => e.Lab22)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB22");

                entity.Property(e => e.Lab23)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB23");

                entity.Property(e => e.Lab24)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LAB24");

                entity.Property(e => e.OntslagDiagnosisExt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ontslag_diagnosis_ext");

                entity.Property(e => e.Poc01)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("POC01");

                entity.Property(e => e.Poc02)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("POC02");

                entity.Property(e => e.Poc03)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("POC03");

                entity.Property(e => e.PoliDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("poli_date");

                entity.Property(e => e.Problem01)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM01");

                entity.Property(e => e.Problem02)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM02");

                entity.Property(e => e.Problem03)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM03");

                entity.Property(e => e.Problem04)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM04");

                entity.Property(e => e.Problem05)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM05");

                entity.Property(e => e.Repdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPDATE");

                entity.Property(e => e.Siglabel1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIGLABEL1");

                entity.Property(e => e.Siglabel2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIGLABEL2");

                entity.Property(e => e.Surgproc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SURGPROC");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Valvecom01)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("VALVECOM01");

                entity.Property(e => e.Valvecom02)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("VALVECOM02");

                entity.Property(e => e.Valvecom03)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("VALVECOM03");

                entity.Property(e => e.XThorax)
                    .IsUnicode(false)
                    .HasColumnName("X_Thorax");
            });

            modelBuilder.Entity<QueenSupport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("queen_support");

                entity.Property(e => e.Cardiopleg)
                    .HasMaxLength(50)
                    .HasColumnName("CARDIOPLEG");

                entity.Property(e => e.CommentA)
                    .HasMaxLength(255)
                    .HasColumnName("COMMENT_A");

                entity.Property(e => e.CommentB)
                    .HasMaxLength(255)
                    .HasColumnName("COMMENT_B");

                entity.Property(e => e.CommentC)
                    .HasMaxLength(255)
                    .HasColumnName("COMMENT_C");

                entity.Property(e => e.Iabp)
                    .HasMaxLength(50)
                    .HasColumnName("IABP");

                entity.Property(e => e.Inotr)
                    .HasMaxLength(50)
                    .HasColumnName("INOTR");

                entity.Property(e => e.Pacemaker)
                    .HasMaxLength(50)
                    .HasColumnName("PACEMAKER");

                entity.Property(e => e.Pericard)
                    .HasMaxLength(25)
                    .HasColumnName("PERICARD");

                entity.Property(e => e.Pleura)
                    .HasMaxLength(50)
                    .HasColumnName("PLEURA");

                entity.Property(e => e.ProcedureId).HasColumnName("PROCEDURE_ID");
            });

            modelBuilder.Entity<Readmission>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("readmission");

                entity.Property(e => e.PatientId)
                    .ValueGeneratedNever()
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.Anticoagulant)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ANTICOAGULANT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Arrhythmia)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ARRHYTHMIA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Bleeding)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("BLEEDING")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Cath)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CATH")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CathPtca)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CATH_PTCA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CathStent)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CATH_STENT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Chf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CHF")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Cva)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CVA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Graft)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("GRAFT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.HeartBlock)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("HEART_BLOCK")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.LegInfect)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("LEG_INFECT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Mi)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("MI")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Other)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("OTHER")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OtherSpecify)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_SPECIFY")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Pneumonia)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PNEUMONIA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Ppm)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PPM")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.RenalFailure)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RENAL_FAILURE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.SternalInfect)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("STERNAL_INFECT")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Tamponade)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("TAMPONADE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Tia)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("TIA")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Valve)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("VALVE")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Vascular)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("VASCULAR")
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Svr>(entity =>
            {
                entity.HasKey(e => e.ProcedureId);

                entity.ToTable("svr");

                entity.HasIndex(e => e.ProcedureId, "IX_svr");

                entity.Property(e => e.ProcedureId)
                    .ValueGeneratedNever()
                    .HasColumnName("procedure_id");

                entity.Property(e => e.BalloonSize).HasColumnName("balloon_size");

                entity.Property(e => e.BalloonVendor)
                    .HasMaxLength(50)
                    .HasColumnName("balloon_vendor");

                entity.HasOne(d => d.Procedure)
                    .WithOne(p => p.Svr)
                    .HasForeignKey<Svr>(d => d.ProcedureId)
                    .HasConstraintName("FK_svr_procedure_info");
            });

            modelBuilder.Entity<ValveSurgery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("valve_surgery");

                entity.Property(e => e.AorticAetiology)
                    .HasMaxLength(50)
                    .HasColumnName("AORTIC_AETIOLOGY");

                entity.Property(e => e.AorticExplant)
                    .HasMaxLength(150)
                    .HasColumnName("AORTIC_EXPLANT");

                entity.Property(e => e.AorticImplant).HasColumnName("AORTIC_IMPLANT");

                entity.Property(e => e.AorticModel)
                    .HasMaxLength(150)
                    .HasColumnName("AORTIC_MODEL");

                entity.Property(e => e.AorticModelExp)
                    .HasMaxLength(150)
                    .HasColumnName("AORTIC_MODEL_EXP");

                entity.Property(e => e.AorticProcedure).HasColumnName("AORTIC_PROCEDURE");

                entity.Property(e => e.AorticSerialExp)
                    .HasMaxLength(50)
                    .HasColumnName("AORTIC_SERIAL_EXP");

                entity.Property(e => e.AorticSerialImp)
                    .HasMaxLength(50)
                    .HasColumnName("AORTIC_SERIAL_IMP");

                entity.Property(e => e.AorticSize)
                    .HasMaxLength(2)
                    .HasColumnName("AORTIC_SIZE");

                entity.Property(e => e.AorticSizeExp)
                    .HasMaxLength(2)
                    .HasColumnName("AORTIC_SIZE_EXP");

                entity.Property(e => e.AorticType).HasColumnName("AORTIC_TYPE");

                entity.Property(e => e.AorticTypeExp).HasColumnName("AORTIC_TYPE_EXP");

                entity.Property(e => e.AorticValveId).HasColumnName("AorticValve_id");

                entity.Property(e => e.Combined).HasMaxLength(5);

                entity.Property(e => e.Memo).HasColumnType("ntext");

                entity.Property(e => e.MitralAetiology)
                    .HasMaxLength(50)
                    .HasColumnName("MITRAL_AETIOLOGY");

                entity.Property(e => e.MitralExplant)
                    .HasMaxLength(150)
                    .HasColumnName("MITRAL_EXPLANT");

                entity.Property(e => e.MitralImplant).HasColumnName("MITRAL_IMPLANT");

                entity.Property(e => e.MitralModel)
                    .HasMaxLength(150)
                    .HasColumnName("MITRAL_MODEL");

                entity.Property(e => e.MitralModelExp)
                    .HasMaxLength(150)
                    .HasColumnName("MITRAL_MODEL_EXP");

                entity.Property(e => e.MitralProcedure).HasColumnName("MITRAL_PROCEDURE");

                entity.Property(e => e.MitralSerialExp)
                    .HasMaxLength(50)
                    .HasColumnName("MITRAL_SERIAL_EXP");

                entity.Property(e => e.MitralSerialImp)
                    .HasMaxLength(50)
                    .HasColumnName("MITRAL_SERIAL_IMP");

                entity.Property(e => e.MitralSize)
                    .HasMaxLength(2)
                    .HasColumnName("MITRAL_SIZE");

                entity.Property(e => e.MitralSizeExp)
                    .HasMaxLength(2)
                    .HasColumnName("MITRAL_SIZE_EXP");

                entity.Property(e => e.MitralType).HasColumnName("MITRAL_TYPE");

                entity.Property(e => e.MitralTypeExp).HasColumnName("MITRAL_TYPE_EXP");

                entity.Property(e => e.MitralValveId).HasColumnName("MitralValve_id");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.ProcedureId).HasColumnName("PROCEDURE_ID");

                entity.Property(e => e.PulmonicAetiology)
                    .HasMaxLength(50)
                    .HasColumnName("PULMONIC_AETIOLOGY");

                entity.Property(e => e.PulmonicExplant)
                    .HasMaxLength(150)
                    .HasColumnName("PULMONIC_EXPLANT");

                entity.Property(e => e.PulmonicImplant).HasColumnName("PULMONIC_IMPLANT");

                entity.Property(e => e.PulmonicModel)
                    .HasMaxLength(150)
                    .HasColumnName("PULMONIC_MODEL");

                entity.Property(e => e.PulmonicModelExp)
                    .HasMaxLength(150)
                    .HasColumnName("PULMONIC_MODEL_EXP");

                entity.Property(e => e.PulmonicProcedure).HasColumnName("PULMONIC_PROCEDURE");

                entity.Property(e => e.PulmonicSerialExp)
                    .HasMaxLength(50)
                    .HasColumnName("PULMONIC_SERIAL_EXP");

                entity.Property(e => e.PulmonicSerialImp)
                    .HasMaxLength(50)
                    .HasColumnName("PULMONIC_SERIAL_IMP");

                entity.Property(e => e.PulmonicSize)
                    .HasMaxLength(2)
                    .HasColumnName("PULMONIC_SIZE");

                entity.Property(e => e.PulmonicSizeExp)
                    .HasMaxLength(2)
                    .HasColumnName("PULMONIC_SIZE_EXP");

                entity.Property(e => e.PulmonicType).HasColumnName("PULMONIC_TYPE");

                entity.Property(e => e.PulmonicTypeExp).HasColumnName("PULMONIC_TYPE_EXP");

                entity.Property(e => e.PulmonicValveId).HasColumnName("PulmonicValve_id");

                entity.Property(e => e.TricuspidAetiology)
                    .HasMaxLength(50)
                    .HasColumnName("TRICUSPID_AETIOLOGY");

                entity.Property(e => e.TricuspidExplant)
                    .HasMaxLength(150)
                    .HasColumnName("TRICUSPID_EXPLANT");

                entity.Property(e => e.TricuspidImplant).HasColumnName("TRICUSPID_IMPLANT");

                entity.Property(e => e.TricuspidModel)
                    .HasMaxLength(150)
                    .HasColumnName("TRICUSPID_MODEL");

                entity.Property(e => e.TricuspidModelExp)
                    .HasMaxLength(150)
                    .HasColumnName("TRICUSPID_MODEL_EXP");

                entity.Property(e => e.TricuspidProcedure).HasColumnName("TRICUSPID_PROCEDURE");

                entity.Property(e => e.TricuspidSerialExp)
                    .HasMaxLength(50)
                    .HasColumnName("TRICUSPID_SERIAL_EXP");

                entity.Property(e => e.TricuspidSerialImp)
                    .HasMaxLength(50)
                    .HasColumnName("TRICUSPID_SERIAL_IMP");

                entity.Property(e => e.TricuspidSize)
                    .HasMaxLength(2)
                    .HasColumnName("TRICUSPID_SIZE");

                entity.Property(e => e.TricuspidSizeExp)
                    .HasMaxLength(2)
                    .HasColumnName("TRICUSPID_SIZE_EXP");

                entity.Property(e => e.TricuspidType).HasColumnName("TRICUSPID_TYPE");

                entity.Property(e => e.TricuspidTypeExp).HasColumnName("TRICUSPID_TYPE_EXP");

                entity.Property(e => e.TricuspidValveId).HasColumnName("TricuspidValve_id");
            });

            modelBuilder.Entity<VladTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vlad_table");

                entity.Property(e => e.AddValue).HasColumnName("add_value");

                entity.Property(e => e.LogValue).HasColumnName("Log_value");

                entity.Property(e => e.No).HasColumnName("no");
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.DataEncryption;
using Microsoft.EntityFrameworkCore.DataEncryption.Providers;
using Microsoft.EntityFrameworkCore.Metadata;

namespace com.study.core.model
{
    public partial class mobileSurveyContext : DbContext
    {

        //private readonly byte[] _encryptionKey = "";
        //private readonly byte[] _encryptionIV = "";
        private readonly IEncryptionProvider _provider;


        public mobileSurveyContext()
        {
        }

        public void ExecuteSqlCommend(string query)
        {
            throw new NotImplementedException();
        }

        public mobileSurveyContext(DbContextOptions<mobileSurveyContext> options)
            : base(options)
        {
            
           // this._provider = new AesProvider(this._encryptionKey, this._encryptionIV);
        }

        public virtual DbSet<TblUser> TblUsers { get; set; }

        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<TblAccessLog> TblAccessLog { get; set; }
        public virtual DbSet<TblAttrJavascript> TblAttrJavascript { get; set; }
        public virtual DbSet<TblCode> TblCode { get; set; }
        public virtual DbSet<TblList> TblList { get; set; }
        public virtual DbSet<TblListQuota> TblListQuota { get; set; }
        public virtual DbSet<TblListcolumns> TblListcolumns { get; set; }
        public virtual DbSet<TblOption> TblOption { get; set; }
        public virtual DbSet<TblOptionAttribute> TblOptionAttribute { get; set; }
        public virtual DbSet<TblQuestion> TblQuestion { get; set; }
        public virtual DbSet<TblQuestionAttribute> TblQuestionAttribute { get; set; }
        public virtual DbSet<TblQuestionHistory> TblQuestionHistory { get; set; }
        public virtual DbSet<TblQuestionLog> TblQuestionLog { get; set; }
        public virtual DbSet<TblQuotaLabel> TblQuotaLabel { get; set; }
        public virtual DbSet<TblQuotaTable> TblQuotaTable { get; set; }
        public virtual DbSet<TblReData> TblReData { get; set; }
        public virtual DbSet<TblRefusalLog> TblRefusalLog { get; set; }
        public virtual DbSet<TblSendLog> TblSendLog { get; set; }
        public virtual DbSet<TblSurvey> TblSurvey { get; set; }
        public virtual DbSet<TblSurveyTemplete> TblSurveyTemplete { get; set; }
        public virtual DbSet<TblSurveyTempleteColumns> TblSurveyTempleteColumns { get; set; }
        public virtual DbSet<TblSurveyTemplete표준> TblSurveyTemplete표준 { get; set; }
        public virtual DbSet<V응답리스트매칭정보> V응답리스트매칭정보 { get; set; }
        public virtual DbSet<V응답리스트매칭정보가로베이스> V응답리스트매칭정보가로베이스 { get; set; }
        public virtual DbSet<V테스트리스트> V테스트리스트 { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=172.29.181.161;Initial Catalog=mobileSurvey;User ID=sa;Password=skdltmfltjcl");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("tbl_user");

                entity.Property(e => e.MemId)
                    .HasColumnName("memId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.IsDel).HasColumnName("isDel");

                entity.Property(e => e.LastDate)
                    .HasColumnName("lastDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemName)
                    .HasColumnName("memName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("regDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasKey(e => e.DiagramId)
                    .HasName("PK__sysdiagr__C2B05B61C78EEF8A");

                entity.ToTable("sysdiagrams");

                entity.HasIndex(e => new { e.Name, e.PrincipalId })
                    .HasName("UK_principal_name")
                    .IsUnique();

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<TblAccessLog>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.ListNo, e.SendNo, e.AccessNo });

                entity.ToTable("tbl_accessLog");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.SendNo).HasColumnName("send_no");

                entity.Property(e => e.AccessNo)
                    .HasColumnName("access_no")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AcDate)
                    .HasColumnName("acDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EncryKey)
                    .HasColumnName("encryKey")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblAttrJavascript>(entity =>
            {
                entity.HasKey(e => e.AttrName);

                entity.ToTable("tbl_attr_javascript");

                entity.Property(e => e.AttrName)
                    .HasColumnName("attrName")
                    .HasMaxLength(100);

                entity.Property(e => e.ScriptBody).HasColumnName("scriptBody");

                entity.Property(e => e.ScriptType)
                    .HasColumnName("scriptType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCode>(entity =>
            {
                entity.HasKey(e => new { e.CodeNo, e.CodeGroup })
                    .HasName("PK_tbl_code_1");

                entity.ToTable("tbl_code");

                entity.Property(e => e.CodeNo).HasColumnName("code_no");

                entity.Property(e => e.CodeGroup)
                    .HasColumnName("code_group")
                    .HasMaxLength(50);

                entity.Property(e => e.CodeLabel)
                    .HasColumnName("code_label")
                    .HasMaxLength(100);

                entity.Property(e => e.CodeValue)
                    .HasColumnName("code_value")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblList>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.ListNo });

                entity.ToTable("tbl_list");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.CellNum)
                    .HasColumnName("cellNum")
                    .HasMaxLength(50);

                entity.Property(e => e.Col01)
                    .HasColumnName("col01")
                    .HasMaxLength(200);

                entity.Property(e => e.Col02)
                    .HasColumnName("col02")
                    .HasMaxLength(200);

                entity.Property(e => e.Col03)
                    .HasColumnName("col03")
                    .HasMaxLength(200);

                entity.Property(e => e.Col04)
                    .HasColumnName("col04")
                    .HasMaxLength(200);

                entity.Property(e => e.Col05)
                    .HasColumnName("col05")
                    .HasMaxLength(200);

                entity.Property(e => e.Col06)
                    .HasColumnName("col06")
                    .HasMaxLength(200);

                entity.Property(e => e.EndCode).HasColumnName("endCode");

                entity.Property(e => e.FinishBl).HasColumnName("finish_bl");

                entity.Property(e => e.IngBl).HasColumnName("ing_bl");

                entity.Property(e => e.QuestCount).HasColumnName("questCount");

                entity.Property(e => e.QuotaOverBl).HasColumnName("quotaOver_bl");

                entity.Property(e => e.RefusalBl).HasColumnName("refusal_bl");

                entity.Property(e => e.StateCode).HasColumnName("stateCode");

                entity.Property(e => e.StopBl).HasColumnName("stop_bl");

                entity.HasOne(d => d.SurveyNoNavigation)
                    .WithMany(p => p.TblList)
                    .HasForeignKey(d => d.SurveyNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_list_tbl_survey");
            });

            modelBuilder.Entity<TblListQuota>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.ListNo, e.QuotaNo, e.QuotaCode });

                entity.ToTable("tbl_list_quota");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.QuotaNo).HasColumnName("quota_no");

                entity.Property(e => e.QuotaCode).HasColumnName("quota_code");

                entity.HasOne(d => d.TblList)
                    .WithMany(p => p.TblListQuota)
                    .HasForeignKey(d => new { d.SurveyNo, d.ListNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_list_quota_tbl_list");

                entity.HasOne(d => d.TblQuotaLabel)
                    .WithMany(p => p.TblListQuota)
                    .HasForeignKey(d => new { d.SurveyNo, d.QuotaNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_list_quota_tbl_quota_label");
            });

            modelBuilder.Entity<TblListcolumns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_listcolumns");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.VariableLabel)
                    .HasColumnName("variable_label")
                    .HasMaxLength(200);

                entity.Property(e => e.VariableName)
                    .HasColumnName("variable_name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblOption>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.QtCode, e.OpCode });

                entity.ToTable("tbl_option");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.QtCode)
                    .HasColumnName("qtCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OpCode)
                    .HasColumnName("opCode")
                    .HasMaxLength(50);

                entity.Property(e => e.EndCode).HasColumnName("endCode");

                entity.Property(e => e.InputLabel)
                    .HasColumnName("inputLabel")
                    .HasMaxLength(1000);

                entity.Property(e => e.InputType)
                    .HasColumnName("inputType")
                    .HasMaxLength(50);

                entity.Property(e => e.InputValue)
                    .HasColumnName("inputValue")
                    .HasMaxLength(100);

                entity.Property(e => e.NextQuestion)
                    .HasColumnName("next_question")
                    .HasMaxLength(50);

                entity.Property(e => e.Open).HasColumnName("open");

                entity.HasOne(d => d.TblQuestion)
                    .WithMany(p => p.TblOption)
                    .HasForeignKey(d => new { d.SurveyNo, d.QtCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_option_tbl_question");
            });

            modelBuilder.Entity<TblOptionAttribute>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.QtCode, e.OpCode, e.AttrName });

                entity.ToTable("tbl_option_attribute");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.QtCode)
                    .HasColumnName("qtCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OpCode)
                    .HasColumnName("opCode")
                    .HasMaxLength(50);

                entity.Property(e => e.AttrName)
                    .HasColumnName("attrName")
                    .HasMaxLength(200);

                entity.Property(e => e.AttrValue)
                    .HasColumnName("attrValue")
                    .HasMaxLength(300);

                entity.HasOne(d => d.TblOption)
                    .WithMany(p => p.TblOptionAttribute)
                    .HasForeignKey(d => new { d.SurveyNo, d.QtCode, d.OpCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_option_attribute_tbl_option");
            });

            modelBuilder.Entity<TblQuestion>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.QtCode });

                entity.ToTable("tbl_question");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.QtCode)
                    .HasColumnName("qtCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Detailorder).HasColumnName("detailorder");

                entity.Property(e => e.EndCode).HasColumnName("endCode");

                entity.Property(e => e.Exclude)
                    .HasColumnName("exclude")
                    .HasMaxLength(5);

                entity.Property(e => e.Include)
                    .HasColumnName("include")
                    .HasMaxLength(5);

                entity.Property(e => e.NextQuestion)
                    .HasColumnName("next_question")
                    .HasMaxLength(50);

                entity.Property(e => e.QtBody)
                    .HasColumnName("qtBody")
                    .HasMaxLength(4000);

                entity.Property(e => e.QtScript)
                    .HasColumnName("qtScript")
                    .HasMaxLength(4000);

                entity.Property(e => e.QtText)
                    .HasColumnName("qtText")
                    .HasMaxLength(2000);

                entity.Property(e => e.QtType)
                    .HasColumnName("qtType")
                    .HasMaxLength(50);

                entity.Property(e => e.UseQuotaBl).HasColumnName("useQuota_bl");

                entity.HasOne(d => d.SurveyNoNavigation)
                    .WithMany(p => p.TblQuestion)
                    .HasForeignKey(d => d.SurveyNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_question_tbl_survey");
            });

            modelBuilder.Entity<TblQuestionAttribute>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.QtCode, e.AttrName });

                entity.ToTable("tbl_question_attribute");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.QtCode)
                    .HasColumnName("qtCode")
                    .HasMaxLength(50);

                entity.Property(e => e.AttrName)
                    .HasColumnName("attrName")
                    .HasMaxLength(100);

                entity.Property(e => e.AttrValue)
                    .HasColumnName("attrValue")
                    .HasMaxLength(300);

                entity.HasOne(d => d.TblQuestion)
                    .WithMany(p => p.TblQuestionAttribute)
                    .HasForeignKey(d => new { d.SurveyNo, d.QtCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_question_attribute_tbl_question");
            });

            modelBuilder.Entity<TblQuestionHistory>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.ListNo, e.QhNo });

                entity.ToTable("tbl_question_history");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.QhNo).HasColumnName("qh_no");

                entity.Property(e => e.DelBl).HasColumnName("del_bl");

                entity.Property(e => e.InQtCode)
                    .HasColumnName("in_qtCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OutQtCode)
                    .HasColumnName("out_qtCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.TblList)
                    .WithMany(p => p.TblQuestionHistory)
                    .HasForeignKey(d => new { d.SurveyNo, d.ListNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_question_history_tbl_list");
            });

            modelBuilder.Entity<TblQuestionLog>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.ListNo, e.QtCode, e.QlNo });

                entity.ToTable("tbl_question_log");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.QtCode)
                    .HasColumnName("qtCode")
                    .HasMaxLength(50);

                entity.Property(e => e.QlNo)
                    .HasColumnName("ql_no")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InBl).HasColumnName("in_bl");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblQuotaLabel>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.QuotaNo });

                entity.ToTable("tbl_quota_label");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.QuotaNo).HasColumnName("quota_no");

                entity.Property(e => e.QuotaAlias)
                    .HasColumnName("quota_alias")
                    .HasMaxLength(100);

                entity.Property(e => e.QuotaLabel)
                    .HasColumnName("quota_label")
                    .HasMaxLength(200);

                entity.HasOne(d => d.SurveyNoNavigation)
                    .WithMany(p => p.TblQuotaLabel)
                    .HasForeignKey(d => d.SurveyNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_quota_label_tbl_survey");
            });

            modelBuilder.Entity<TblQuotaTable>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.QuotaNo, e.QuotaCode });

                entity.ToTable("tbl_quota_table");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.QuotaNo).HasColumnName("quota_no");

                entity.Property(e => e.QuotaCode).HasColumnName("quota_code");

                entity.Property(e => e.CellName)
                    .HasColumnName("cell_name")
                    .HasMaxLength(200);

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Sample).HasColumnName("sample");

                entity.Property(e => e.Sms).HasColumnName("sms");

                entity.Property(e => e.Surveying).HasColumnName("surveying");

                entity.Property(e => e.Target).HasColumnName("target");

                entity.Property(e => e.WithoutBl).HasColumnName("without_bl");
            });

            modelBuilder.Entity<TblReData>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.ListNo, e.QtCode, e.OpCode });

                entity.ToTable("tbl_reData");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.QtCode)
                    .HasColumnName("qtCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OpCode)
                    .HasColumnName("opCode")
                    .HasMaxLength(50);

                entity.Property(e => e.QhNo).HasColumnName("qh_no");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(1000);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.TblList)
                    .WithMany(p => p.TblReData)
                    .HasForeignKey(d => new { d.SurveyNo, d.ListNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_reData_tbl_list");

                entity.HasOne(d => d.TblQuestionHistory)
                    .WithMany(p => p.TblReData)
                    .HasForeignKey(d => new { d.SurveyNo, d.ListNo, d.QhNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_reData_tbl_question_history");

                entity.HasOne(d => d.TblOption)
                    .WithMany(p => p.TblReData)
                    .HasForeignKey(d => new { d.SurveyNo, d.QtCode, d.OpCode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_reData_tbl_option");
            });

            modelBuilder.Entity<TblRefusalLog>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.ListNo, e.RefNo })
                    .HasName("PK_tbl_denyLog");

                entity.ToTable("tbl_refusalLog");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.RefNo)
                    .HasColumnName("ref_no")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ClickPoint)
                    .HasColumnName("click_point")
                    .HasMaxLength(100);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSendLog>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.ListNo, e.SendNo });

                entity.ToTable("tbl_sendLog");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.SendNo).HasColumnName("send_no");

                entity.Property(e => e.CellNum)
                    .HasColumnName("cellNum")
                    .HasMaxLength(50);

                entity.Property(e => e.DurationDay).HasColumnName("durationDay");

                entity.Property(e => e.EncryKey)
                    .HasColumnName("encryKey")
                    .HasMaxLength(200);

                entity.Property(e => e.RegDate)
                    .HasColumnName("regDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.TblList)
                    .WithMany(p => p.TblSendLog)
                    .HasForeignKey(d => new { d.SurveyNo, d.ListNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_sendLog_tbl_list");
            });

            modelBuilder.Entity<TblSurvey>(entity =>
            {
                entity.HasKey(e => e.SurveyNo);

                entity.ToTable("tbl_survey");

                entity.Property(e => e.SurveyNo)
                    .HasColumnName("survey_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.Callback)
                    .HasColumnName("callback")
                    .HasMaxLength(100);

                entity.Property(e => e.CssStyleName)
                    .HasColumnName("cssStyleName")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IngQuotaBl).HasColumnName("ingQuota_bl");

                entity.Property(e => e.LastDay).HasColumnName("lastDay");

                entity.Property(e => e.LogHeight).HasColumnName("logHeight");

                entity.Property(e => e.LogoFile)
                    .HasColumnName("logoFile")
                    .HasMaxLength(100);

                entity.Property(e => e.LogoWidth).HasColumnName("logoWidth");

                entity.Property(e => e.SName)
                    .HasColumnName("sName")
                    .HasMaxLength(300);

                entity.Property(e => e.SmsMessage)
                    .IsRequired()
                    .HasColumnName("smsMessage")
                    .HasMaxLength(1000);

                entity.Property(e => e.SurveyYear)
                    .HasColumnName("survey_year")
                    .HasMaxLength(4);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(300);

                entity.Property(e => e.UseBl).HasColumnName("use_bl");

                entity.Property(e => e.UseListCountBl).HasColumnName("useListCount_bl");

                entity.Property(e => e.UseQuotaAccessBl).HasColumnName("useQuotaAccess_bl");
            });

            modelBuilder.Entity<TblSurveyTemplete>(entity =>
            {
                entity.HasKey(e => new { e.SurveyNo, e.Type });

                entity.ToTable("tbl_survey_templete");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.Contents).HasColumnName("contents");

                entity.Property(e => e.UseBl).HasColumnName("use_bl");

                entity.HasOne(d => d.SurveyNoNavigation)
                    .WithMany(p => p.TblSurveyTemplete)
                    .HasForeignKey(d => d.SurveyNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_html_templete_tbl_survey");
            });

            modelBuilder.Entity<TblSurveyTempleteColumns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_survey_templete_columns");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.VariableLabel)
                    .HasColumnName("variable_label")
                    .HasMaxLength(200);

                entity.Property(e => e.VariableName)
                    .HasColumnName("variable_name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblSurveyTemplete표준>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_survey_templete_표준");

                entity.Property(e => e.Contents).HasColumnName("contents");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.UseBl).HasColumnName("use_bl");

                entity.Property(e => e.비고).HasMaxLength(2000);
            });

            modelBuilder.Entity<V응답리스트매칭정보>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v응답리스트매칭정보");

                entity.Property(e => e.CellNum)
                    .HasColumnName("cellNum")
                    .HasMaxLength(50);

                entity.Property(e => e.Col01)
                    .HasColumnName("col01")
                    .HasMaxLength(200);

                entity.Property(e => e.Col02)
                    .HasColumnName("col02")
                    .HasMaxLength(200);

                entity.Property(e => e.Col03)
                    .HasColumnName("col03")
                    .HasMaxLength(200);

                entity.Property(e => e.Col04)
                    .HasColumnName("col04")
                    .HasMaxLength(200);

                entity.Property(e => e.Col05)
                    .HasColumnName("col05")
                    .HasMaxLength(200);

                entity.Property(e => e.Col06)
                    .HasColumnName("col06")
                    .HasMaxLength(200);

                entity.Property(e => e.EndCode).HasColumnName("endCode");

                entity.Property(e => e.FinishBl).HasColumnName("finish_bl");

                entity.Property(e => e.IngBl).HasColumnName("ing_bl");

                entity.Property(e => e.InputLabel)
                    .HasColumnName("inputLabel")
                    .HasMaxLength(1000);

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.OpCode)
                    .IsRequired()
                    .HasColumnName("opCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Open).HasColumnName("open");

                entity.Property(e => e.QhNo).HasColumnName("qh_no");

                entity.Property(e => e.QtCode)
                    .IsRequired()
                    .HasColumnName("qtCode")
                    .HasMaxLength(50);

                entity.Property(e => e.QtText)
                    .HasColumnName("qtText")
                    .HasMaxLength(2000);

                entity.Property(e => e.QuestCount).HasColumnName("questCount");

                entity.Property(e => e.QuotaOverBl).HasColumnName("quotaOver_bl");

                entity.Property(e => e.RefusalBl).HasColumnName("refusal_bl");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StateCode).HasColumnName("stateCode");

                entity.Property(e => e.StopBl).HasColumnName("stop_bl");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(1000);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<V응답리스트매칭정보가로베이스>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v응답리스트매칭정보_가로베이스");

                entity.Property(e => e.CellNum)
                    .HasColumnName("cellNum")
                    .HasMaxLength(50);

                entity.Property(e => e.Col01)
                    .HasColumnName("col01")
                    .HasMaxLength(200);

                entity.Property(e => e.Col02)
                    .HasColumnName("col02")
                    .HasMaxLength(200);

                entity.Property(e => e.Col03)
                    .HasColumnName("col03")
                    .HasMaxLength(200);

                entity.Property(e => e.Col04)
                    .HasColumnName("col04")
                    .HasMaxLength(200);

                entity.Property(e => e.Col05)
                    .HasColumnName("col05")
                    .HasMaxLength(200);

                entity.Property(e => e.Col06)
                    .HasColumnName("col06")
                    .HasMaxLength(200);

                entity.Property(e => e.EndCode).HasColumnName("endCode");

                entity.Property(e => e.FinishBl).HasColumnName("finish_bl");

                entity.Property(e => e.IngBl).HasColumnName("ing_bl");

                entity.Property(e => e.InputLabel)
                    .HasColumnName("inputLabel")
                    .HasMaxLength(1000);

                entity.Property(e => e.ListNo).HasColumnName("list_no");

                entity.Property(e => e.OpCode)
                    .IsRequired()
                    .HasColumnName("opCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Open).HasColumnName("open");

                entity.Property(e => e.QhNo).HasColumnName("qh_no");

                entity.Property(e => e.QtCode)
                    .IsRequired()
                    .HasColumnName("qtCode")
                    .HasMaxLength(51);

                entity.Property(e => e.QtText)
                    .HasColumnName("qtText")
                    .HasMaxLength(2000);

                entity.Property(e => e.QuestCount).HasColumnName("questCount");

                entity.Property(e => e.QuotaOverBl).HasColumnName("quotaOver_bl");

                entity.Property(e => e.RefusalBl).HasColumnName("refusal_bl");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StateCode).HasColumnName("stateCode");

                entity.Property(e => e.StopBl).HasColumnName("stop_bl");

                entity.Property(e => e.SurveyNo).HasColumnName("survey_no");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<V테스트리스트>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v테스트리스트");

                entity.Property(e => e.Base62리스트코딩)
                    .HasColumnName("base62리스트코딩")
                    .IsUnicode(false);

                entity.Property(e => e.Base62연도두자리)
                    .HasColumnName("base62연도두자리")
                    .IsUnicode(false);

                entity.Property(e => e.Hex도전).HasColumnName("hex도전");

                entity.Property(e => e.Hex리스트코드)
                    .HasColumnName("hex리스트코드")
                    .HasMaxLength(30);

                entity.Property(e => e.Hex연도)
                    .HasColumnName("hex연도")
                    .HasMaxLength(30);

                entity.Property(e => e.Hex연도두자리)
                    .HasColumnName("hex연도두자리")
                    .HasMaxLength(30);

                entity.Property(e => e.In변환)
                    .HasColumnName("in변환")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Md5).HasColumnName("md5");

                entity.Property(e => e.Sha1).HasColumnName("sha1");

                entity.Property(e => e.연도).HasMaxLength(2);

                entity.Property(e => e.연도변환)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.차)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

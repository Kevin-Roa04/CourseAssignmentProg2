using System;
using Economy.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class EconomyContext : DbContext, IEconomyDbContext
    {
        public EconomyContext()
        {
        }

        public EconomyContext(DbContextOptions<EconomyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activo> Activos { get; set; }
        public virtual DbSet<Amortizacion> Amortizacions { get; set; }
        public virtual DbSet<Annuity> Annuities { get; set; }
        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<Depreciacion> Depreciacions { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<InversionFne> InversionFnes { get; set; }
        public virtual DbSet<Profit> Profits { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Serie> Series { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-K1R9BD8;Initial Catalog=Economy;user=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Activo>(entity =>
            {
                entity.ToTable("Activo");

                entity.Property(e => e.DescripcionActivo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreActivo)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Amortizacion>(entity =>
            {
                entity.ToTable("Amortizacion");

                entity.Property(e => e.TasaPrestamo).HasColumnType("money");

                entity.Property(e => e.ValorInversion).HasColumnType("money");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Amortizacions)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Amortizac__Proje__398D8EEE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Amortizacions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Amortizac__UserI__38996AB5");
            });

            modelBuilder.Entity<Annuity>(entity =>
            {
                entity.ToTable("Annuity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.End).HasColumnName("end");

                entity.Property(e => e.FlowType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flowType");

                entity.Property(e => e.Future)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("future");

                entity.Property(e => e.Initial).HasColumnName("initial");

                entity.Property(e => e.Payment)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("payment");

                entity.Property(e => e.Present)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("present");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.TotalPeriod).HasColumnName("totalPeriod");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Annuities)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projects");
            });

            modelBuilder.Entity<Cost>(entity =>
            {
                entity.ToTable("Cost");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorIncremento).HasColumnType("money");

                entity.Property(e => e.ValorInicial).HasColumnType("money");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Costs)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cost__ProjectId__3F466844");
            });

            modelBuilder.Entity<Depreciacion>(entity =>
            {
                entity.ToTable("Depreciacion");

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorResidual).HasColumnType("money");

                entity.HasOne(d => d.Activo)
                    .WithMany(p => p.Depreciacions)
                    .HasForeignKey(d => d.ActivoId)
                    .HasConstraintName("FK__Depreciac__Activ__35BCFE0A");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Depreciacions)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Depreciac__Proje__34C8D9D1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Depreciacions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Depreciac__UserI__33D4B598");
            });

            modelBuilder.Entity<Interest>(entity =>
            {
                entity.ToTable("Interest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.End).HasColumnName("end");

                entity.Property(e => e.FlowType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flowType");

                entity.Property(e => e.Future)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("future");

                entity.Property(e => e.Initial).HasColumnName("initial");

                entity.Property(e => e.Payment)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("payment");

                entity.Property(e => e.Present)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("present");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.TotalPeriod).HasColumnName("totalPeriod");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Interests)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projectss");
            });

            modelBuilder.Entity<InversionFne>(entity =>
            {
                entity.ToTable("InversionFNE");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.HasOne(d => d.Activo)
                    .WithMany(p => p.InversionFnes)
                    .HasForeignKey(d => d.ActivoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inversion__Activ__4316F928");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.InversionFnes)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inversion__Proje__4222D4EF");
            });

            modelBuilder.Entity<Profit>(entity =>
            {
                entity.ToTable("Profit");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorIncremento).HasColumnType("money");

                entity.Property(e => e.ValorInicial).HasColumnType("money");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Profits)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Profit__ProjectI__3C69FB99");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Creation)
                    .HasColumnType("date")
                    .HasColumnName("creation");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Path)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("path");

                entity.Property(e => e.Period)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("period");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user");
            });

            modelBuilder.Entity<Serie>(entity =>
            {
                entity.ToTable("Serie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DownPayment)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("downPayment");

                entity.Property(e => e.End).HasColumnName("end");

                entity.Property(e => e.FinalPayment)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("finalPayment");

                entity.Property(e => e.FlowType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flowType");

                entity.Property(e => e.Future)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("future");

                entity.Property(e => e.Incremental).HasColumnName("incremental");

                entity.Property(e => e.Initial).HasColumnName("initial");

                entity.Property(e => e.Present)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("present");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.TotalPeriod).HasColumnName("totalPeriod");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_project");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

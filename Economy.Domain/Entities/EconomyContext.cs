using System;
using Economy.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class EconomyContext : DbContext,IEconomyDbContext
    {
        public EconomyContext()
        {
        }

        public EconomyContext(DbContextOptions<EconomyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Annuity> Annuities { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Serie> Series { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-75SE2PC\\SQLEXPRESS;Initial Catalog=Economy;user=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Annuity>(entity =>
            {
                entity.ToTable("Annuity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.End).HasColumnName("end");

                entity.Property(e => e.FlowType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flowType");

                entity.Property(e => e.Future)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("future");

                entity.Property(e => e.Initial).HasColumnName("initial");

                entity.Property(e => e.Payment)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("payment");

                entity.Property(e => e.Present)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("present");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("rate");

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

            modelBuilder.Entity<Interest>(entity =>
            {
                entity.ToTable("Interest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.End).HasColumnName("end");

                entity.Property(e => e.FlowType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flowType");

                entity.Property(e => e.Future)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("future");

                entity.Property(e => e.Initial).HasColumnName("initial");

                entity.Property(e => e.Present)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("present");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("rate");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Interests)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_projectss");
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
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("future");

                entity.Property(e => e.Incremental).HasColumnName("incremental");

                entity.Property(e => e.Initial).HasColumnName("initial");

                entity.Property(e => e.Present)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("present");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("rate");

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

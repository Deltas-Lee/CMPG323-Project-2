using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ORGANISATION_X.Models
{
    public partial class OrganisationxDBContext : DbContext
    {
        public OrganisationxDBContext()
        {
        }

        public OrganisationxDBContext(DbContextOptions<OrganisationxDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Cmpg323Project2Dataset> Cmpg323Project2Dataset { get; set; }
        public virtual DbSet<EmployeeModel> EmployeeModel { get; set; }
        public virtual DbSet<LoginModel> LoginModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=USERPC-PC\\SQLEXPRESS;Database=OrganisationxDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Cmpg323Project2Dataset>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber)
                    .HasName("PK__CMPG323___8D663599476A99D0");

                entity.ToTable("CMPG323_project_2_dataset");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Attrition)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessTravel)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.EducationField)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobRole)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Over18)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OverTime)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeModel>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber)
                    .HasName("PK__Employee__8D6635994F70AA23");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Attrition)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessTravel)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.EducationField)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JobRole)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Over18)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OverTime)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoginModel>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

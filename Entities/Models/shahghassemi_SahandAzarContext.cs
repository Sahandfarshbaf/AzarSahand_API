using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Models
{
    public partial class shahghassemi_SahandAzarContext : DbContext
    {
        public shahghassemi_SahandAzarContext()
        {
        }

        public shahghassemi_SahandAzarContext(DbContextOptions<shahghassemi_SahandAzarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatForm> CatForms { get; set; } = null!;
        public virtual DbSet<CatRole> CatRoles { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Form> Forms { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleForm> RoleForms { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserAccessLocation> UserAccessLocations { get; set; } = null!;
        public virtual DbSet<UserActivation> UserActivations { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=185.55.224.2;Initial Catalog=shahghassemi_SahandAzar;User ID=shahghassemi_SahandAzar;Password=Abc@123%pP123;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("shahghassemi_SahandAzar");

            modelBuilder.Entity<CatForm>(entity =>
            {
                entity.ToTable("CatForm", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Class).HasMaxLength(512);

                entity.Property(e => e.Icone).HasMaxLength(512);

                entity.Property(e => e.Title).HasMaxLength(64);

                entity.Property(e => e.Url)
                    .HasMaxLength(512)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<CatRole>(entity =>
            {
                entity.ToTable("CatRole", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title).HasMaxLength(128);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CodeMapper).HasMaxLength(32);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.Title).HasMaxLength(64);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_City_Province");
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.ToTable("Form", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Class).HasMaxLength(512);

                entity.Property(e => e.Icone).HasMaxLength(512);

                entity.Property(e => e.Title).HasMaxLength(64);

                entity.Property(e => e.Url)
                    .HasMaxLength(512)
                    .HasColumnName("URL");

                entity.HasOne(d => d.CatFormNavigation)
                    .WithMany(p => p.Forms)
                    .HasForeignKey(d => d.CatForm)
                    .HasConstraintName("FK_Form_CatForm");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CodeMapper).HasMaxLength(32);

                entity.Property(e => e.Title).HasMaxLength(64);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatRoleId).HasColumnName("CatRoleID");

                entity.Property(e => e.Title).HasMaxLength(128);

                entity.HasOne(d => d.CatRole)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.CatRoleId)
                    .HasConstraintName("FK_Role_CatRole");
            });

            modelBuilder.Entity<RoleForm>(entity =>
            {
                entity.ToTable("RoleForm", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.RoleForms)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_RoleForm_Form");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleForms)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleForm_Role");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bdate).HasColumnName("BDate");

                entity.Property(e => e.Cdate).HasColumnName("CDate");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CuserId).HasColumnName("CUserID");

                entity.Property(e => e.DaUserId).HasColumnName("DaUserID");

                entity.Property(e => e.Ddate).HasColumnName("DDate");

                entity.Property(e => e.DuserId).HasColumnName("DUserID");

                entity.Property(e => e.Family).HasMaxLength(128);

                entity.Property(e => e.Hpassword)
                    .HasMaxLength(512)
                    .HasColumnName("HPassword");

                entity.Property(e => e.Mdate).HasColumnName("MDate");

                entity.Property(e => e.MuserId).HasColumnName("MUserID");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.NationalCode).HasMaxLength(11);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.UserName).HasMaxLength(64);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Users_City");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_Users_Province");
            });

            modelBuilder.Entity<UserAccessLocation>(entity =>
            {
                entity.ToTable("UserAccessLocation", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.UserAccessLocations)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_UserAccessLocation_City");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.UserAccessLocations)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_UserAccessLocation_Province");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAccessLocations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserAccessLocation_Users");
            });

            modelBuilder.Entity<UserActivation>(entity =>
            {
                entity.ToTable("UserActivation", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cdate).HasColumnName("CDate");

                entity.Property(e => e.CuserId).HasColumnName("CUserID");

                entity.Property(e => e.DaUserId).HasColumnName("DaUserID");

                entity.Property(e => e.Ddate).HasColumnName("DDate");

                entity.Property(e => e.DuserId).HasColumnName("DUserID");

                entity.Property(e => e.Mdate).HasColumnName("MDate");

                entity.Property(e => e.MuserId).HasColumnName("MUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserActivations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserActivation_Users");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRole_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Logger.Models
{
    public partial class shahghassemi_SahandAzarLog_DBContext : DbContext
    {
        public shahghassemi_SahandAzarLog_DBContext()
        {
        }

        public shahghassemi_SahandAzarLog_DBContext(DbContextOptions<shahghassemi_SahandAzarLog_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HandledErrorLog> HandledErrorLogs { get; set; }
        public virtual DbSet<OperationLog> OperationLogs { get; set; }
        public virtual DbSet<SystemErrorLog> SystemErrorLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<HandledErrorLog>(entity =>
            {
                entity.ToTable("HandledErrorLog");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasMaxLength(300);

                entity.Property(e => e.InnerClassName).HasMaxLength(300);

                entity.Property(e => e.InnerMethodName).HasMaxLength(300);

                entity.Property(e => e.ServiceMethodName).HasMaxLength(300);

                entity.Property(e => e.ServiceName).HasMaxLength(300);
            });

            modelBuilder.Entity<OperationLog>(entity =>
            {
                entity.ToTable("OperationLog");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExecuteTime).HasMaxLength(50);

                entity.Property(e => e.MethodName).HasMaxLength(200);

                entity.Property(e => e.ServiceName).HasMaxLength(200);
            });

            modelBuilder.Entity<SystemErrorLog>(entity =>
            {
                entity.ToTable("SystemErrorLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.InnerClassName).HasMaxLength(300);

                entity.Property(e => e.InnerMethodName).HasMaxLength(300);

                entity.Property(e => e.ServiceMethodName).HasMaxLength(300);

                entity.Property(e => e.ServiceName).HasMaxLength(300);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WAPizza.Shared.Models;
#nullable disable

namespace WAPizza.Server.Models
{
    public partial class SchoolEquipmentDBContext : DbContext
    {
        public SchoolEquipmentDBContext()
        {
        }

        public SchoolEquipmentDBContext(DbContextOptions<SchoolEquipmentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SchoolEquipment> SchoolEquipment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           /* if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-C1TI2QO\\JAIRBEDOYA;Database=SchoolEquipmentDB;Integrated Security=True; User=sa; Password=123456");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolEquipment>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Trabajador)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

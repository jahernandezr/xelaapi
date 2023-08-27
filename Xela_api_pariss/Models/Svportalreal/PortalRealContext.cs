using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Xela_api_pariss.Models.Svportalreal
{
    public partial class PortalRealContext : DbContext
    {
        public PortalRealContext()
        {
        }

        public PortalRealContext(DbContextOptions<PortalRealContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Prueba> Pruebas { get; set; }
//        public virtual DbSet<Vw_ImagenesBit> Vw_ImagenesBit { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= 192.168.9.3;Database= aplicacionesNet;Trusted_Connection=false;User ID=api;Password=Desarrollo05");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prueba>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

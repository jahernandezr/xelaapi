using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Xela_api_pariss.Models.ProyectosApp
{
    public partial class ProyectosAppContext : DbContext
    {
        public ProyectosAppContext()
        {
        }

        public ProyectosAppContext(DbContextOptions<ProyectosAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nomina_nomina> Proyecto_proyectos { get; set; }
        public virtual DbSet<Proyecto_soportes> Proyecto_soportes { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= 5CD746D1P5\\SQLEXPRESS;Database= apiAppNet;Trusted_Connection=True;");

            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //          partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        // }
    }
}

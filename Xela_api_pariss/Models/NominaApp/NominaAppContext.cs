using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Xela_api_pariss.Models.NominaApp
{
    public partial class NominaAppContext : DbContext
    {
        public NominaAppContext()
        {
        }

        public NominaAppContext(DbContextOptions<NominaAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nomina_nomina> Nomina_nomina { get; set; }
        public virtual DbSet<VwNomnina_nomina> VwNomnina_nomina { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=10.127.209.100;Database=aplicacionesNet;Trusted_Connection=false;User ID=sa;Password=Qwerty1514.!");

            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //          partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        // }
    }
}

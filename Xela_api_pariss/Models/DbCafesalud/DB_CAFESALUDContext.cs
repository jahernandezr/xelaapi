using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Xela_api_pariss.Models.DbCafesalud
{
    public partial class DB_CAFESALUDContext : DbContext
    {
        public DB_CAFESALUDContext()
        {
        }

        public DB_CAFESALUDContext(DbContextOptions<DB_CAFESALUDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Catalogo> Catalogos { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<VWcatalogos> VWcatalogos { get; set; }
       public virtual DbSet<VwImagCYS> VwImagCYS { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
           //    optionsBuilder.UseSqlServer("Server= 5CD746D1P5\\SQLEXPRESS;Database= DB_CAFESALUD;Trusted_Connection=True;");
              optionsBuilder.UseSqlServer("Server= 10.127.209.5;Database= DB_CAFESALUD;Trusted_Connection=false; User ID =apixela; Password =Desarrollo05");
             //   optionsBuilder.UseSqlServer("Server= 10.127.209.5;Database= DB_CAFESALUD;Trusted_Connection=True;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalogo>(entity =>
            {
                entity.HasKey(e => e.IdCat);

                entity.ToTable("catalogo");

                entity.Property(e => e.IdCat)
                    .HasColumnType("decimal(11, 0)")
                    .HasColumnName("id_cat")
                    .HasComment("Identificador único del catálogo");

                entity.Property(e => e.DescTip)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("desc_tip")
                    .HasComment("Descripción del tipo de catálogo");

                entity.Property(e => e.IdRad)
                    .HasColumnType("decimal(11, 0)")
                    .HasColumnName("id_rad")
                    .HasComment("Identificador único de la factura");

                entity.Property(e => e.IdTip)
                    .HasColumnName("id_tip")
                    .HasComment("ID del tipo de catálogo");

                entity.Property(e => e.RutaSan)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ruta_san")
                    .HasComment("Ruta SAN del catálogo");

                entity.Property(e => e.San)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("san")
                    .HasComment("ruta SAN principal del catálogo");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("facturas");

                //entity.Property(e => e.CantHoj)
                //    .HasColumnName("cant_hoj")
                //    .HasComment("Cantidad de hojas de la factura");

                entity.Property(e => e.CodiEst)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codi_est")
                    .IsFixedLength()
                    .HasComment("Código del estado de la factura");

                entity.Property(e => e.CodiReg)
                    .HasColumnName("codi_reg")
                    .HasComment("Código de regional");

                entity.Property(e => e.DescEst)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("desc_est")
                    .HasComment("Descripción del estado de la factura");

                entity.Property(e => e.DescEstEps)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("desc_est_eps")
                    .HasComment("Descripción del estado agrupador para la EPS");

                entity.Property(e => e.DescTramite)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("desc_tramite")
                    .HasComment("Descripción del trámite");

                entity.Property(e => e.FechFact)
                    .HasColumnType("date")
                    .HasColumnName("fech_fact")
                    .HasComment("Fecha de la factura");

                entity.Property(e => e.FechReg)
                    .HasColumnType("datetime")
                    .HasColumnName("fechReg")
                    .HasComment("Fecha de registro de la factura");

                entity.Property(e => e.FechaEstado)
                    .HasColumnType("datetime")
                    .HasComment("Fecha del estado de la factura");

                entity.Property(e => e.IdEps)
                    .HasColumnName("id_eps")
                    .HasComment("Identificador de la EPS");

                entity.Property(e => e.IdModalidad)
                    .HasColumnName("id_modalidad")
                    .HasComment("ID de la modalidad");

                entity.Property(e => e.IdRad)
                    .HasColumnType("decimal(11, 0)")
                    .HasColumnName("id_rad")
                    .HasComment("Identificador único de la factura");

                entity.Property(e => e.Modalidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Modalidad de la factura");

                entity.Property(e => e.MunIdmunicipio)
                    .HasColumnName("munIDMunicipio")
                    .HasComment("ID del municipio");

                entity.Property(e => e.MunNomMunicipio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("munNomMunicipio")
                    .HasComment("Nombre del municipio");

                entity.Property(e => e.NitEps)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit_eps")
                    .HasComment("NIT de la EPS");

                entity.Property(e => e.NombEps)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nomb_eps")
                    .HasComment("Nombre de la EPS");

                entity.Property(e => e.NombIps)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nomb_ips")
                    .HasComment("Nombre de la IPS");

                entity.Property(e => e.NombReg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nomb_reg")
                    .HasComment("Nombre de regional");

                entity.Property(e => e.NumDocIps)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("num_doc_ips")
                    .HasComment("Número de documento de la IPS");

                entity.Property(e => e.NumFact)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("num_fact")
                    .HasComment("Número de la factura");

                entity.Property(e => e.NumeRad)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nume_rad")
                    .HasComment("Identificador único de la factura cliente");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Origen de la factura");

                entity.Property(e => e.PrefFact)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("pref_fact")
                    .HasComment("Prefijo de la factura");

                entity.Property(e => e.RadReingreso)
                    .HasColumnType("decimal(11, 0)")
                    .HasComment("Identificador de la factura de reingreso (Radicado Anterior)");

                entity.Property(e => e.StickerCm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("StickerCM")
                    .HasComment("Etiqueta CM de la factura");

                entity.Property(e => e.UsuarioRadica)
                    .HasMaxLength(203)
                    .IsUnicode(false)
                    .HasComment("Usuario que radica la factura");

                entity.Property(e => e.ValBruto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("val_bruto")
                    .HasComment("Valor bruto de la factura");

                entity.Property(e => e.ValCop)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("val_cop")
                    .HasComment("Valor copago de la factura");

                entity.Property(e => e.ValDesc)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("val_desc")
                    .HasComment("Valor descuento de la factura");

                entity.Property(e => e.ValMod)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("val_mod")
                    .HasComment("Valor moderadora de la factura");

                entity.Property(e => e.ValNeto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("val_neto")
                    .HasComment("Valor neto de la factura");

                entity.Property(e => e.ValorGlosado)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Valor glosado de la factura");

                entity.Property(e => e.VlrGlosaInicial)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vlrGlosaInicial")
                    .HasComment("Valor de la glosa inicial de la factura");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pacientes");

                entity.Property(e => e.Ape1Pac)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ape1_pac")
                    .HasComment("Primer apellido del paciente");

                entity.Property(e => e.Ape2Pac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ape2_pac")
                    .HasComment("Segundo apellido del paciente");

                entity.Property(e => e.FechIng)
                    .HasColumnType("date")
                    .HasColumnName("fech_ing")
                    .HasComment("Fecha de ingreso del paciente");

                entity.Property(e => e.FechSal)
                    .HasColumnType("date")
                    .HasColumnName("fech_sal")
                    .HasComment("Fecha de salida del paciente");

                entity.Property(e => e.IdRad)
                    .HasColumnType("decimal(11, 0)")
                    .HasColumnName("id_rad")
                    .HasComment("Identificador único de la factura");

                entity.Property(e => e.NdocPac)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ndoc_pac")
                    .HasComment("Número de documento del paciente");

                entity.Property(e => e.Nomb1Pac)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomb1_pac")
                    .HasComment("Primer nombre del paciente");

                entity.Property(e => e.Nomb2Pac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomb2_pac")
                    .HasComment("Segundo nombre del paciente");

                entity.Property(e => e.TdocPac)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tdoc_pac")
                    .IsFixedLength()
                    .HasComment("Tipo de documento del paciente");
            });

            modelBuilder.Entity<VwImagCy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwImagCYS");

                entity.Property(e => e.Ape1Pac)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ape1_pac");

                entity.Property(e => e.Ape2Pac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ape2_pac");

                //entity.Property(e => e.CantHoj).HasColumnName("cant_hoj");

                entity.Property(e => e.CodiEst)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codi_est")
                    .IsFixedLength();

                entity.Property(e => e.CodiReg).HasColumnName("codi_reg");

                entity.Property(e => e.DescEst)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("desc_est");

                entity.Property(e => e.DescEstEps)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("desc_est_eps");

                entity.Property(e => e.DescTip)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("desc_tip");

                entity.Property(e => e.DescTramite)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("desc_tramite");

                entity.Property(e => e.FechFact)
                    .HasColumnType("date")
                    .HasColumnName("fech_fact");

                entity.Property(e => e.FechIng)
                    .HasColumnType("date")
                    .HasColumnName("fech_ing");

                entity.Property(e => e.FechReg)
                    .HasColumnType("datetime")
                    .HasColumnName("fechReg");

                entity.Property(e => e.FechSal)
                    .HasColumnType("date")
                    .HasColumnName("fech_sal");

                entity.Property(e => e.FechaEstado).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCat)
                    .HasColumnType("decimal(11, 0)")
                    .HasColumnName("id_cat");

                entity.Property(e => e.IdRad)
                    .HasColumnType("decimal(11, 0)")
                    .HasColumnName("id_rad");

                entity.Property(e => e.Modalidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MunIdmunicipio).HasColumnName("munIDMunicipio");

                entity.Property(e => e.MunNomMunicipio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("munNomMunicipio");

                entity.Property(e => e.NdocPac)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ndoc_pac");

                entity.Property(e => e.NitEps)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit_eps");

                entity.Property(e => e.Nomb1Pac)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomb1_pac");

                entity.Property(e => e.Nomb2Pac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomb2_pac");

                entity.Property(e => e.NombEps)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nomb_eps");

                entity.Property(e => e.NombIps)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nomb_ips");

                entity.Property(e => e.NombReg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nomb_reg");

                entity.Property(e => e.NumDocIps)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("num_doc_ips");

                entity.Property(e => e.NumFact)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("num_fact");

                entity.Property(e => e.NumeRad)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nume_rad");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrefFact)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("pref_fact");

                entity.Property(e => e.RadReingreso).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.RutaSan)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ruta_san");

                entity.Property(e => e.San)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("san");

                entity.Property(e => e.StickerCm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("StickerCM");

                entity.Property(e => e.TdocPac)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tdoc_pac")
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRadica)
                    .HasMaxLength(203)
                    .IsUnicode(false);

                entity.Property(e => e.ValBruto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("val_bruto");

                entity.Property(e => e.ValCop)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("val_cop");

                entity.Property(e => e.ValDesc)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("val_desc");

                entity.Property(e => e.ValMod)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("val_mod");

                entity.Property(e => e.ValNeto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("val_neto");

                entity.Property(e => e.ValorGlosado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlrGlosaInicial)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vlrGlosaInicial");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

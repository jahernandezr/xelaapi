using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Xela_api_pariss.Controllers;

namespace Xela_api_pariss.Models.Correpondenciabd
{
    public partial class Correspondencia_dbContext : DbContext
    {
        public Correspondencia_dbContext()
        {
        }

        public Correspondencia_dbContext(DbContextOptions<Correspondencia_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TutResponsable> TutResponsables { get; set; }
        public virtual DbSet<TutResponsablesEstado> TutResponsablesEstados { get; set; }
        public virtual DbSet<TutSolicitude> TutSolicitudes { get; set; }
        public virtual DbSet<TutSolicitudesEstado> TutSolicitudesEstados { get; set; }
        public virtual DbSet<VwoficiosDestinatarios> VwoficiosDestinatarios { get; set; }   
        public virtual DbSet<Vwlistadoterceros> Vwlistadoterceros { get; set; } 
        public virtual DbSet<VWsolicitudesParametro> VWsolicitudesParametro { get; set; }
        public virtual DbSet<Vw_seg_usuarios> Vw_seg_usuarios { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
          //   optionsBuilder.UseSqlServer("Server=5CD746D1P5\\SQLEXPRESS;Database=correspondencia_db;Trusted_Connection=True;");
             optionsBuilder.UseSqlServer("Server = 10.1.10.102; Database = correspondencia_db; Trusted_Connection = false; User ID = correspondencia_adm; Password = Correspondencia1.");

                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TutResponsable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tut_responsables");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("comentario");

                entity.Property(e => e.DetalleConCopia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("detalleConCopia");

                entity.Property(e => e.DetalleRta)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("detalle_rta");

                entity.Property(e => e.EstadoAsignacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estadoAsignacion");

                entity.Property(e => e.FhAsignacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fh_asignacion");

                entity.Property(e => e.FhDevolucion)
                    .HasColumnType("datetime")
                    .HasColumnName("fh_devolucion");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdResponsable).HasColumnName("id_responsable");

                entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");

                entity.Property(e => e.IdUsuarioAsignado).HasColumnName("id_usuario_asignado");

                entity.Property(e => e.IdUsuarioAsignador).HasColumnName("id_usuario_asignador");

                entity.Property(e => e.PrioridadRta).HasColumnName("prioridad_rta");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<TutResponsablesEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__tut_resp__86989FB2627BF1B2");

                entity.ToTable("tut_responsables_estados");

                entity.HasIndex(e => e.IdEstado, "UQ__tut_resp__86989FB358B81BBE")
                    .IsUnique();

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("alias");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TutSolicitude>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tut_solicitudes");

                entity.Property(e => e.AFavorDe).HasColumnName("aFavorDe");

                entity.Property(e => e.AntiguedadInicial).HasColumnName("antiguedadInicial");

                entity.Property(e => e.BankCuenta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_cuenta");

                entity.Property(e => e.CityCuenta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_cuenta");

                entity.Property(e => e.Codigoramajudicial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigoramajudicial");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comentario");

                entity.Property(e => e.Controlprocesoejecutivo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("controlprocesoejecutivo");

                entity.Property(e => e.DeptoCuenta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("depto_cuenta");

                entity.Property(e => e.FReg)
                    .HasColumnType("datetime")
                    .HasColumnName("f_reg");

                entity.Property(e => e.FRta)
                    .HasColumnType("datetime")
                    .HasColumnName("f_rta");

                entity.Property(e => e.FStart)
                    .HasColumnType("datetime")
                    .HasColumnName("f_start");

                entity.Property(e => e.FStop)
                    .HasColumnType("datetime")
                    .HasColumnName("f_stop");

                entity.Property(e => e.FechaRadicacionFisico)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRadicacionFisico");

                entity.Property(e => e.FechaRtaEntExt)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRtaEntExt");

                entity.Property(e => e.FhAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fh_act");

                entity.Property(e => e.IdCanal).HasColumnName("idCanal");

                entity.Property(e => e.IdCaso).HasColumnName("id_caso");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdEstadoFinal).HasColumnName("idEstadoFinal");

                entity.Property(e => e.IdModoRecepcion).HasColumnName("id_modo_recepcion");

                entity.Property(e => e.IdMotivo).HasColumnName("idMotivo");

                entity.Property(e => e.IdMotivoPtd).HasColumnName("idMotivoPTD");

                entity.Property(e => e.IdOrigen).HasColumnName("id_origen");

                entity.Property(e => e.IdPreradicado).HasColumnName("id_preradicado");

                entity.Property(e => e.IdPretension).HasColumnName("id_pretension");

                entity.Property(e => e.IdRecepcion).HasColumnName("id_recepcion");

                entity.Property(e => e.IdSeccional).HasColumnName("id_seccional");

                entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.IdUsuarioApoderado).HasColumnName("id_usuario_apoderado");

                entity.Property(e => e.IdUsuarioPeticionario).HasColumnName("id_usuario_peticionario");

                entity.Property(e => e.IdUsuarioRadicador).HasColumnName("id_usuario_radicador");

                entity.Property(e => e.Lectura)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lectura");

                entity.Property(e => e.NombreEntidadExt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_entidad_ext");

                entity.Property(e => e.Notificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("notificacion");

                entity.Property(e => e.NroOficio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nro_oficio");

                entity.Property(e => e.NroRadicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nro_radicacion");

                entity.Property(e => e.NumArchCopias).HasColumnName("numArchCopias");

                entity.Property(e => e.NumArchOriginales).HasColumnName("numArchOriginales");

                entity.Property(e => e.NumArchTotal).HasColumnName("numArchTotal");

                entity.Property(e => e.NumCuenta).HasColumnName("num_cuenta");

                entity.Property(e => e.NumFolios).HasColumnName("numFolios");

                entity.Property(e => e.NumOficio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numOficio");

                entity.Property(e => e.Respuesta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("respuesta");

                entity.Property(e => e.RespuestaFinal)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("respuesta_final");

                entity.Property(e => e.SolicitudDuplicada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("solicitudDuplicada");

                entity.Property(e => e.Termino).HasColumnName("termino");

                entity.Property(e => e.TerminoInicial).HasColumnName("terminoInicial");

                entity.Property(e => e.TipoCuenta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo_cuenta");

                entity.Property(e => e.ValTotalReclamacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("valTotalReclamacion");
            });

            modelBuilder.Entity<TutSolicitudesEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__tut_soli__86989FB200B2AEE2");

                entity.ToTable("tut_solicitudes_estados");

                entity.HasIndex(e => e.IdEstado, "UQ__tut_soli__86989FB36FFC5629")
                    .IsUnique();

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("alias");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

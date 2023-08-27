using System;
using System.Collections.Generic;

namespace Xela_api_pariss.Models.Correpondenciabd
{
    public partial class TutSolicitude
    {
        public int? IdSolicitud { get; set; }
        public DateTime? FReg { get; set; }
        public DateTime? FRta { get; set; }
        public DateTime? FhAct { get; set; }
        public string Lectura { get; set; }
        public string Notificacion { get; set; }
        public string NroOficio { get; set; }
        public string NroRadicacion { get; set; }
        public string RespuestaFinal { get; set; }
        public int? Termino { get; set; }
        public int? NumCuenta { get; set; }
        public string BankCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public string DeptoCuenta { get; set; }
        public string CityCuenta { get; set; }
        public int? IdUsuarioPeticionario { get; set; }
        public int? IdUsuarioApoderado { get; set; }
        public int? IdCaso { get; set; }
        public int? IdOrigen { get; set; }
        public int? IdModoRecepcion { get; set; }
        public int? IdEstado { get; set; }
        public int? IdTipo { get; set; }
        public int? IdPretension { get; set; }
        public int? IdUsuarioRadicador { get; set; }
        public int? IdRecepcion { get; set; }
        public int? IdSeccional { get; set; }
        public int? IdPreradicado { get; set; }
        public string Codigoramajudicial { get; set; }
        public string Controlprocesoejecutivo { get; set; }
        public DateTime? FechaRadicacionFisico { get; set; }
        public int? NumArchCopias { get; set; }
        public int? NumArchOriginales { get; set; }
        public int? NumArchTotal { get; set; }
        public string ValTotalReclamacion { get; set; }
        public string Comentario { get; set; }
        public string NombreEntidadExt { get; set; }
        public DateTime? FechaRtaEntExt { get; set; }
        public int? NumFolios { get; set; }
        public string NumOficio { get; set; }
        public string Respuesta { get; set; }
        public int? IdCanal { get; set; }
        public int? IdMotivo { get; set; }
        public string SolicitudDuplicada { get; set; }
        public int? AntiguedadInicial { get; set; }
        public DateTime? FStart { get; set; }
        public DateTime? FStop { get; set; }
        public int? TerminoInicial { get; set; }
        public int? AFavorDe { get; set; }
        public int? IdEstadoFinal { get; set; }
        public int? IdMotivoPtd { get; set; }
    }
}

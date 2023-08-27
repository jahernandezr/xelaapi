using System;
using System.Collections.Generic;

namespace Xela_api_pariss.Models.Correpondenciabd
{
    public partial class TutResponsable
    {
        public int? IdResponsable { get; set; }
        public string Comentario { get; set; }
        public string DetalleRta { get; set; }
        public DateTime? FhAsignacion { get; set; }
        public DateTime? FhDevolucion { get; set; }
        public int? PrioridadRta { get; set; }
        public string Tipo { get; set; }
        public int? IdEstado { get; set; }
        public int? IdSolicitud { get; set; }
        public int? IdUsuarioAsignado { get; set; }
        public int? IdUsuarioAsignador { get; set; }
        public string EstadoAsignacion { get; set; }
        public string DetalleConCopia { get; set; }
    }
}

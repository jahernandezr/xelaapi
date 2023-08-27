using DocumentFormat.OpenXml.Office2010.Excel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xela_api_pariss.Models.ProyectosApp
{
    public class Proyecto_soportes
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile NombreImg { get; set; }   
        public string NombreImg2 { get; set; }
        public string CorreoContratante { get; set; }    
        public string TipoSoporte { get; set; } 
        public  string ObservacionSoporte { get; set; } 
    }
}

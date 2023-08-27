using DocumentFormat.OpenXml.Office2010.Excel;

namespace Xela_api_pariss.Models.Correpondenciabd
{
    public class VWsolicitudesParametro
    {
        public int Id { get; set; }
        public int id_preradicado { get; set; }

        public string fecha_respuesta { get; set; }
        public string estado { get; set; }
        public string fecha_asignacion { get; set; }
        public string nombre_usuario { get; set; }
        public  int id_usuario_asignado { get; set; }   
        public  int fh_asignacio { get; set; }  
        public int fh_asignacion { get; set; }
    }
}

namespace Xela_api_pariss.Models.ProyectosApp
{
    public class Nomina_nomina
    {
        public int Id { get; set; } 
        public string NombreContratante { get; set; }    
        public string CorreoContratante { get; set; } 
        public string NitContratante { get; set;}
        public string NombreContratista { get; set; }
        public string NitContratista { get; set; }
        public string ObjetoContrato { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public int Id_prorroga { get; set; }
        public  int Id_soporte { get; set; }

    }
}

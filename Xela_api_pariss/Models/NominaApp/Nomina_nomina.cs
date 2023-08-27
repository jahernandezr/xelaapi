namespace Xela_api_pariss.Models.NominaApp
{
    public class Nomina_nomina
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }    
        public string Apellido { get; set; } 
        public string Tipo_de_documento { get; set;}
        public string Numero_identificacion { get; set; }
        public string Correo_electronico { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Sede { get; set; }
        public string Cargo { get; set; }
        public string Liquidado { get; set; }
        public  string Estado { get; set; }
        public string Informacion_completa { get; set; }
        public int ValorSueldo { get; set; }
        public string SedeSecundaria { get; set; }  
        public string Observaciones { get; set; }    

    }
}

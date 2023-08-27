namespace Xela_api_pariss.Models
{
    public class Usuario
    {
        public int id { get; set; }
		public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string UsuarioRed { get; set; }
        public string Empre { get; set; }
        public string Password { get; set; }	
    }
}

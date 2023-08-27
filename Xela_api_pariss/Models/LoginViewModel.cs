using System.ComponentModel.DataAnnotations;

namespace Xela_api_pariss.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "el  campos {0} , es requerido")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "el  campos {0} , es requerido")]
        public string Password { get; set; }
        [Required(ErrorMessage = "el  campos {0} , es requerido")]
        [Display(Name = "Recuerdame")]
        public bool Recuerdame { get; set; }
    }
}

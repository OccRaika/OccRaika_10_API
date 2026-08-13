using System.ComponentModel.DataAnnotations;

namespace Raika_OCC_10_API.DTOs
{
    public class CredencialesUsuario
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "El campo {0} debe ser un email")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Password { get; set; } = null!;
    }
}

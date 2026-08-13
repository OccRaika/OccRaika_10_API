using Raika_OCC_10_API.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Raika_OCC_10_API.DTOs.UserDTO_s
{
    public class EditarPerfilInterno
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string ApellidoPaterno { get; set; } = string.Empty;
        [Required]
        public string ApellidoMaterno { get; set; } = string.Empty;
        public string? Calle { get; set; }
        public int? ColoniaId { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Municipio { get; set; }
        public int? EntidadFederativaId { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? Celular { get; set; }
        public string? CondicionVida { get; set; }
        public string? Sexo { get; set; }
        public string? FechaNacimiento { get; set; }
        public int? EstadoCivilId { get; set; }
        public string? Nacionalidad { get; set; }

    }
}

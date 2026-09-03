using System.ComponentModel.DataAnnotations;

namespace Raika_OCC_10_API.Entidades.EstructuraEclesial
{
    public class Colonia
    {
        public int ColoniaId { get; set; }
        [Required]
        public string Clave{ get; set; } = string.Empty;
        [Required]
        public string CodigoPostal { get; set; } = string.Empty;
        [Required]
        public string Nombre { get; set; } = string.Empty;
        public Decanato? Decanato { get; set; }
    }
}

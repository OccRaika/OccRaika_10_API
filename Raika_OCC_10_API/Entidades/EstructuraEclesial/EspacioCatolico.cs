using System.ComponentModel.DataAnnotations;

namespace Raika_OCC_10_API.Entidades.EstructuraEclesial
{
    public class EspacioCatolico
    {
        public int EspacioCatolicoId { get; set; }
        [Required]
        public string Clave{ get; set; } = string.Empty;
        [Required]
        public string Nombre { get; set; } = string.Empty;
        public Decanato? Decanato { get; set; }
    }
}

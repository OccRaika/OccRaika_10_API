using System.ComponentModel.DataAnnotations;

namespace Raika_OCC_10_API.Entidades
{
    public class EspacioCatolico
    {
        public int EspacioCatolicoId { get; set; }
        [Required]
        public string ClaveEspacioCatolico { get; set; } = string.Empty;
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string ClaveDecanato { get; set; } = string.Empty;
        public Decanato? Decanato { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Raika_OCC_10_API.Entidades.EstructuraEclesial
{
    public class Decanato
    {
        public int DecanatoId { get; set; }
        [Required]
        public string Clave { get; set; } = string.Empty;
        [Required]
        public string Nombre { get; set; } = string.Empty;
        public ZonaPastoral? ZonaPastoral { get; set; }
        public ICollection<Capilla>? Capillas { get; set; }
        public ICollection<EspacioCatolico>? EspacioCatolicos { get; set; }
        public ICollection<Colonia>? Colonias { get; set; }
    }
}

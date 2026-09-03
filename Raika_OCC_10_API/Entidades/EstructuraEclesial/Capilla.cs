using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Raika_OCC_10_API.Entidades.EstructuraEclesial
{
    public class Capilla
    {
        public int CapillaId { get; set; }
        [Required]
        public string Clave{ get; set; } = string.Empty;
        [Required]
        public string Nombre { get; set; } = string.Empty;
        public Decanato? Decanato { get; set; }
        
    }
}

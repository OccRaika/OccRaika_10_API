using System;

namespace Raika_OCC_10_API.DTOs
{
    public class LaicoDTO
    {
        public Guid LaicoId { get; set; } = Guid.Empty!;
        public string? DesarrolloApostolado { get; set; }
        public string? DireccionApostolado { get; set; }
    }
}

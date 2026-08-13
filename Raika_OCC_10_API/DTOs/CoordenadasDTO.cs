using System;

namespace Raika_OCC_10_API.DTOs
{
    public class CoordenadasDTO
    {
        public Guid CoordenadasId { get; set; } = Guid.Empty!;
        public string? latitud { get; set; }
        public string? longitud { get; set; }
        public string? descripcion { get; set; }
    }
}

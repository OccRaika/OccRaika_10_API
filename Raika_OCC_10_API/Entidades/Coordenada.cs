using System;

namespace Raika_OCC_10_API.Entidades
{
    public class Coordenada
    {
        public Guid CoordenadaId { get; set; } = Guid.Empty!;
        public string? latitud { get; set; }
        public string? longitud { get; set; }
        public string? descripcion { get; set; }
    }
}

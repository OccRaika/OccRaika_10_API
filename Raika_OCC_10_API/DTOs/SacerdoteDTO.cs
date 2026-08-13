using System;

namespace Raika_OCC_10_API.DTOs
{
    public class SacerdoteDTO
    {
        public Guid SacerdoteId { get; set; } = Guid.Empty!;
        public Guid UserId { get; set; } = Guid.Empty!;
        public string? Nombramiento { get; set; }
        public string? Ministerio { get; set; }
        public string? DireccionMinisterio { get; set; }
        public string? ColoniaMinisterio { get; set; }
    }
}

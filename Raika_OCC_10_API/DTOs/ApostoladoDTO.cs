using System;

namespace Raika_OCC_10_API.DTOs
{
    public class ApostoladoDTO
    {
            public Guid ApostoladoId { get; set; } = Guid.Empty!;
            public Guid UserId { get; set; } = Guid.Empty!;
            public string? GrupoApostolico { get; set; }
            public string? SubEquipoNombre { get; set; }
            public string? ServicioPrestado { get; set; }
            public string? NombrePuesto { get; set; }
            public bool? CoordinadorApostolico { get; set; }
            public bool? CoordinadorSubEquipo { get; set; }
            public bool? MiembrosSubEquipo { get; set; }
            public string? ComisionDiocesana { get; set; }
            public string? Dimension { get; set; }
            public string? ParticipacionAsambleasDiocesanas { get; set; }
            public string? IntegracionDeAparecida { get; set; }
    }
}

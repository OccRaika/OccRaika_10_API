using Microsoft.AspNetCore.Identity;
using Raika_OCC_10_API.Entidades.Catalogos;
using Raika_OCC_10_API.Entidades.EstructuraEclesial;
using System;
using System.Collections.Generic;

namespace Raika_OCC_10_API.Entidades.Perfil
{
    public class Laico
    {
        public Guid PerfilId { get; set; }          // PK y FK a la vez
        public Perfil Perfil { get; set; } = null!;
        public string? DesarrolloApostolado { get; set; }
        public string? DireccionApostolado { get; set; }
    }

}

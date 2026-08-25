using Microsoft.AspNetCore.Identity;
using Raika_OCC_10_API.Entidades.Catalogos;
using Raika_OCC_10_API.Entidades.EstructuraEclesial;
using System;
using System.Collections.Generic;

namespace Raika_OCC_10_API.Entidades.Perfil
{
   public class Sacerdote
    {
        public Guid PerfilId { get; set; }
        public Perfil Perfil { get; set; } = null!;
        public string? Nombramiento { get; set; }
        public string? Ministerio { get; set; }
        public string? DireccionMinisterio { get; set; }
        public string? ColoniaMinisterio { get; set; }
    }
}

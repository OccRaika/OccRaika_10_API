using Microsoft.AspNetCore.Identity;
using Raika_OCC_10_API.Entidades.Catalogos;
using Raika_OCC_10_API.Entidades.EstructuraEclesial;
using System;
using System.Collections.Generic;

namespace Raika_OCC_10_API.Entidades.Perfil
{
    public class Perfil : IdentityUser<Guid>
    {
        public string Nombre { get; set; } = string.Empty;
        public string APaterno { get; set; } = string.Empty;
        public string AMaterno { get; set; } = string.Empty;

        public DateOnly FechaNacimiento { get; set; }
        public string? Nacionalidad { get; set; }
        public string? Foto { get; set; }
        public string? SantoPatron { get; set; }
        public string? CondicionVida { get; set; }

        public string? Telefono { get; set; }
        public string? Celular { get; set; }

        // Domicilio
        public string? Calle { get; set; }

        // Catálogos
        public int? SexoId { get; set; }
        public Sexo? Sexo { get; set; }
        public int? EstadoCivilId { get; set; }
        public EstadoCivil? EstadoCivil { get; set; }

        //// Estructura eclesial
        ///public int? ColoniaId { get; set; }
        //public Colonia? Colonia { get; set; }
        //public int? ZonaPastoralId { get; set; }
        //public ZonaPastoral? ZonaPastoral { get; set; }
        //public int? DecanatoId { get; set; }
        //public Decanato? Decanato { get; set; }
        //public int? ParroquiaId { get; set; }
        //public Parroquia? Parroquia { get; set; }

        // Expedientes opcionales
        public Laico? Laico { get; set; }
        public Sacerdote? Sacerdote { get; set; }
    }

    public class Rol : IdentityRole<Guid> { }
}

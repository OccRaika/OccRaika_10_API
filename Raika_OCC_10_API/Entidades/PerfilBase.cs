using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Raika_OCC_10_API.Entidades
{
    public class PerfilBase: IdentityUser<Guid>
    {
        public string Nombre { get; set; } = string.Empty!;
        public string APaterno { get; set; } = string.Empty!;
        public string AMaterno { get; set; } = string.Empty!;
        public string? Calle { get; set; }
        public int? ColoniaId { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Municipio { get; set; }
        public int? EntidadFederativaId { get; set; }
        public string? Telefono { get; set; }
        public string? Celular { get; set; } 
        public string? CondicionVida { get; set; }
        public int? SexoId { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public int? EstadoCivilId { get; set; }
        public string? Nacionalidad { get; set; }
        public string? Foto { get; set; }
        public string? SantoPatron { get; set; }
        public int? ZonaPastoralId { get; set; }
        public int? ParroquiaId { get; set; }
        public int? DecanatoId { get; set; }
        public Laico? Laico { get; set; }
        public Sacerdote? Sacerdote { get; set; }
        public EntidadFederativa? EntidadFederativa { get; set; }
        public EstadoCivil? EstadoCivil { get; set; }
        public Colonia? Colonia { get; set; }
    }

    public class Laico: PerfilBase
    {
        public string? DesarrolloApostolado { get; set; }
        public string? DireccionApostolado { get; set; }
    }

    public class Sacerdote: PerfilBase
    {
        public string? Nombramiento { get; set; }
        public string? Ministerio { get; set; }
        public string? DireccionMinisterio { get; set; }
        public string? ColoniaMinisterio { get; set; }
    }
}

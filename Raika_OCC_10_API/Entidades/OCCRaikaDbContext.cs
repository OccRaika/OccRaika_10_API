using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Raika_OCC_10_API.Entidades;
using Raika_OCC_10_API.Entidades.Catalogos;
using Raika_OCC_10_API.Entidades.Domicilios;
using Raika_OCC_10_API.Entidades.EstructuraEclesial;
using Raika_OCC_10_API.Entidades.Perfil;
using System;

namespace Raika_OCC_10_API_10_API.Entidades
{
    public class OCCRaikaDbContext : IdentityDbContext<Perfil, IdentityRole<Guid>, Guid>
    {
        public OCCRaikaDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // ----- Expedientes de perfil (1:1 opcional por clave primaria compartida) -----
            // Laico y Sacerdote reutilizan el Guid del Perfil como PK y FK a la vez.
            builder.Entity<Laico>(laico =>
            {
                laico.HasKey(l => l.PerfilId);
                laico.HasOne(l => l.Perfil)
                     .WithOne(p => p.Laico)
                     .HasForeignKey<Laico>(l => l.PerfilId)
                     .OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<Sacerdote>(sacerdote =>
            {
                sacerdote.HasKey(s => s.PerfilId);
                sacerdote.HasOne(s => s.Perfil)
                         .WithOne(p => p.Sacerdote)
                         .HasForeignKey<Sacerdote>(s => s.PerfilId)
                         .OnDelete(DeleteBehavior.Cascade);
            });

            // ----- Estructura eclesial: se une por la clave de negocio (Clave*), no por el PK int -----
            builder.Entity<ZonaPastoral>()
                .HasIndex(zona => zona.ClaveZonaPastoral)
                .IsUnique();

            builder.Entity<Decanato>()
                .HasIndex(deca => deca.ClaveDecanato)
                .IsUnique();

            builder.Entity<Capilla>()
                .HasIndex(capilla => capilla.ClaveCapilla)
                .IsUnique();

            builder.Entity<EspacioCatolico>()
                .HasIndex(espacio => espacio.ClaveEspacioCatolico)
                .IsUnique();

            builder.Entity<Colonia>()
                .HasIndex(colonia => colonia.ClaveColonia)
                .IsUnique();

            builder.Entity<Decanato>()
                .HasOne(deca => deca.ZonaPastoral)
                .WithMany(zona => zona.Decanatos)
                .HasForeignKey(deca => deca.ClaveZonaPastoral)
                .HasPrincipalKey(zona => zona.ClaveZonaPastoral);

            builder.Entity<Capilla>()
                .HasOne(capilla => capilla.Decanato)
                .WithMany(deca => deca.Capillas)
                .HasForeignKey(capilla => capilla.ClaveDecanato)
                .HasPrincipalKey(deca => deca.ClaveDecanato);

            builder.Entity<EspacioCatolico>()
                .HasOne(espacio => espacio.Decanato)
                .WithMany(deca => deca.EspacioCatolicos)
                .HasForeignKey(espacio => espacio.ClaveDecanato)
                .HasPrincipalKey(deca => deca.ClaveDecanato);

            builder.Entity<Colonia>()
                .HasOne(colonia => colonia.Decanato)
                .WithMany(deca => deca.Colonias)
                .HasForeignKey(colonia => colonia.ClaveDecanato)
                .HasPrincipalKey(deca => deca.ClaveDecanato);
        }

        // ----- Expedientes de perfil -----
        public DbSet<Laico> Laicos { get; set; }
        public DbSet<Sacerdote> Sacerdotes { get; set; }

        // ----- Estructura eclesial -----
        public DbSet<ZonaPastoral> ZonasPastorales { get; set; }
        public DbSet<Decanato> Decanatos { get; set; }
        public DbSet<Capilla> Capillas { get; set; }
        public DbSet<EspacioCatolico> EspaciosCatolicos { get; set; }
        public DbSet<Colonia> Colonias { get; set; }

        // ----- Domicilios / geo -----
        public DbSet<EntidadFederativa> EntidadesFederativas { get; set; }
        public DbSet<Coordenada> Coordenadas { get; set; }

        // ----- Catálogos -----
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<EstadoCivil> EstadosCiviles { get; set; }
    }
}

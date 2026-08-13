using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Raika_OCC_10_API.Entidades;
using System;
using System.Reflection.Emit;

namespace Raika_OCC_10_API_10_API.Entidades
{
    public class OCCRaikaDbContext : IdentityDbContext<PerfilBase, IdentityRole<Guid>, Guid>
    {
        public OCCRaikaDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PerfilBase>()
                .HasOne(pi => pi.PerfilExternoLaico)
                .WithOne(pel => pel.PerfilInterno)
                .HasForeignKey<PerfilExternoLaico>(u => u.PerfilExternoLaicoId);

            builder.Entity<PerfilBase>()
                .HasOne(pi => pi.PerfilExternoPadre)
                .WithOne(pep => pep.PerfilInterno)
                .HasForeignKey<PerfilExternoPadre>(pep => pep.UserId);

            builder.Entity<Apostolado>()
                .HasOne(a => a.PerfilInterno)
                .WithMany(pi => pi.Apostolados)
                .HasForeignKey(a => a.UserId);

            builder.Entity<PerfilExternoLaico>()
                .HasOne(pel => pel.Capilla)
                .WithMany()
                .HasForeignKey(pel => pel.ParroquiaId);

            builder.Entity<ZonaPastoral>()
                .HasIndex(zona => zona.ClaveZonaPastoral)
                .IsUnique();

            builder.Entity<Decanato>()
                .HasIndex(deca => deca.ClaveDecanato)
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

        public DbSet<Apostolado> Apostolados { get; set; }
        public DbSet<PerfilExternoLaico> PerfilExternoLaicos { get; set; }
        public DbSet<PerfilExternoPadre> PerfilExternoPadres { get; set; }
        public DbSet<Coordenada> Coordenadas { get; set; }
        public DbSet<Colonia> Colonias { get; set; }
        public DbSet<Decanato> Decanatos { get; set; }
        public DbSet<EntidadFederativa> EntidadesFederativas { get; set; }
        public DbSet<EspacioCatolico> EspaciosCatolicos { get; set; }
        public DbSet<EstadoCivil> EstadosCiviles { get; set; }
        public DbSet<Capilla> Capillas { get; set; }
        public DbSet<ZonaPastoral> ZonasPastorales { get; set; }
    }
}


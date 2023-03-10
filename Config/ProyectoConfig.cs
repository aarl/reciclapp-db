using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class ProyectoConfig : IEntityTypeConfiguration<Proyecto>
{
    public void Configure(EntityTypeBuilder<Proyecto> builder)
    {
        builder
           .Property(c => c.Id)
           .HasDefaultValueSql("newid()");

        builder
           .Property(c => c.Titulo)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Descripcion)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.FechaInicio)
           .HasDefaultValueSql("getutcdate()");

        builder
           .Property(c => c.Gustan)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.NoGustan)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.TiempoEstimado)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.ProgresoEstimado)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.ProgresoReal)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.Evaluacion)
           .HasDefaultValueSql("0.0");

        builder
           .Property(c => c.TotalArticulos)
           .HasDefaultValueSql("1");

        builder
           .Property(c => c.CostoEstimado)
           .HasDefaultValueSql("0.0");

        builder
           .Property(c => c.TipoCambioCostoEstimado)
           .HasDefaultValueSql("0.0");

        builder
           .Property(c => c.CostoReal)
           .HasDefaultValueSql("0.0");

        builder
           .Property(c => c.TipoCambioCostoReal)
           .HasDefaultValueSql("0.0");

        builder
           .Property(c => c.FechaCreacion)
           .HasDefaultValueSql("getutcdate()");

        builder
           .Property(c => c.FechaModificacion)
           .HasDefaultValueSql("getutcdate()");

        builder
           .Property(c => c.Activo)
           .HasDefaultValueSql("1");

        builder
           .Property(c => c.VersionApi)
           .HasDefaultValueSql("''");

        builder
            .HasOne(p => p.MonedaCostoReal)
            .WithMany()
            .HasForeignKey(p => p.IdMonedaCostoReal)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.MonedaCostoEstimado)
            .WithMany()
            .HasForeignKey(p => p.IdMonedaCostoEstimado)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.ImagenPrincipal)
            .WithMany()
            .HasForeignKey(p => p.IdImagenPrincipal)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Gerente)
            .WithMany()
            .HasForeignKey(p => p.IdGerente)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Revisor)
            .WithMany()
            .HasForeignKey(p => p.IdRevisor)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.RevisadaPor)
            .WithMany()
            .HasForeignKey(p => p.IdRevisadaPor)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.EstatusProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdEstatusProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.EstatusPublicacion)
            .WithMany()
            .HasForeignKey(p => p.IdEstatusPublicacion)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.FaseAnterior)
            .WithMany()
            .HasForeignKey(p => p.IdFaseAnterior)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.FaseSiguiente)
            .WithMany()
            .HasForeignKey(p => p.IdFaseSiguiente)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.RutaProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdRutaProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.TipoProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdTipoProyecto)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

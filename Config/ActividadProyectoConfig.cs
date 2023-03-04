using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class ActividadProyectoConfig : IEntityTypeConfiguration<ActividadProyecto>
{
    public void Configure(EntityTypeBuilder<ActividadProyecto> builder)
    {
        builder
           .Property(c => c.FechaFinalizacion)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.IdEjecutor)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.IdRevisor)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.IdRevisadaPor)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.TiempoEstimado)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.ProgresoEstimado)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.Evaluacion)
           .HasDefaultValueSql("0.0");

        builder
           .Property(c => c.FechaDisponible)
           .HasDefaultValueSql("NULL");

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
           .Property(c => c.IdCreador)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.FechaCreacion)
           .HasDefaultValueSql("getutcdate()");

        builder
           .Property(c => c.IdModificador)
           .HasDefaultValueSql("NULL");

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
            .HasOne(p => p.ActividadRuta)
            .WithMany()
            .HasForeignKey(p => p.IdActividadRuta)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.MonedaCostoEstimado)
            .WithMany()
            .HasForeignKey(p => p.IdMonedaCostoEstimado)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.MonedaCostoReal)
            .WithMany()
            .HasForeignKey(p => p.IdMonedaCostoReal)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Proyecto)
            .WithMany()
            .HasForeignKey(p => p.IdProyecto)
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
            .HasOne(p => p.Revisor)
            .WithMany()
            .HasForeignKey(p => p.IdRevisor)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Ejecutor)
            .WithMany()
            .HasForeignKey(p => p.IdEjecutor)
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
            .HasOne(p => p.RutaProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdRutaProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.TipoActividad)
            .WithMany()
            .HasForeignKey(p => p.IdTipoActividad)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

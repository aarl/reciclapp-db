using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class PublicacionConfig : IEntityTypeConfiguration<Publicacion>
{
    public void Configure(EntityTypeBuilder<Publicacion> builder)
    {
        builder
           .Property(c => c.Id)
           .HasDefaultValueSql("newid()");

        builder
           .Property(c => c.Fecha)
           .HasDefaultValueSql("getutcdate()");

        builder
           .Property(c => c.Gustan)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.NoGustan)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.IdRevisadaPor)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.IdImagenPrincipal)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.TiempoEstimado)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.Posicionamiento)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.Vistas)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.Evaluacion)
           .HasDefaultValueSql("0.0");

        builder
           .Property(c => c.DireccionIpCreacion)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Direccion)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.ReferenciasDireccion)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.FechaDisponible)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.TotalArticulos)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.IdProyecto)
           .HasDefaultValueSql("NULL");

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
           .Property(c => c.MontoInversion)
           .HasDefaultValueSql("0.0");

        builder
           .Property(c => c.CostoRealTraslado)
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
            .HasOne(p => p.ImagenPrincipal)
            .WithMany()
            .HasForeignKey(p => p.IdImagenPrincipal)
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
            .HasOne(p => p.Publicador)
            .WithMany()
            .HasForeignKey(p => p.IdPublicador)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.RevisadaPor)
            .WithMany()
            .HasForeignKey(p => p.IdRevisadaPor)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.ClasePublicacion)
            .WithMany()
            .HasForeignKey(p => p.IdClasePublicacion)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.EstatusPublicacion)
            .WithMany()
            .HasForeignKey(p => p.IdEstatusPublicacion)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.FasePublicacion)
            .WithMany()
            .HasForeignKey(p => p.IdFasePublicacion)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.TipoPublicacion)
            .WithMany()
            .HasForeignKey(p => p.IdTipoPublicacion)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

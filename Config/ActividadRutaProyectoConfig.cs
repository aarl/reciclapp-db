using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class ActividadRutaProyectoConfig : IEntityTypeConfiguration<ActividadRutaProyecto>
{
    public void Configure(EntityTypeBuilder<ActividadRutaProyecto> builder)
    {
        builder
           .Property(c => c.Descripcion)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Secuencia)
           .HasDefaultValueSql("1");

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
            .HasOne(p => p.RutaProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdRutaProyecto)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

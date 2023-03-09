using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class VersionApiConfig : IEntityTypeConfiguration<VersionApi>
{
    public void Configure(EntityTypeBuilder<VersionApi> builder)
    {
        builder
           .Property(c => c.Version)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.VigenteDesde)
           .HasDefaultValueSql("getutcdate()");

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
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

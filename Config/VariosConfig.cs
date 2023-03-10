using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class VariosConfig : IEntityTypeConfiguration<Varios>
{
    public void Configure(EntityTypeBuilder<Varios> builder)
    {
        builder
           .Property(c => c.Descripcion)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Referencia)
           .HasDefaultValueSql("''");

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
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Tabla)
            .WithMany()
            .HasForeignKey(p => p.IdTabla)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Padre)
            .WithMany()
            .HasForeignKey(p => p.IdPadre)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

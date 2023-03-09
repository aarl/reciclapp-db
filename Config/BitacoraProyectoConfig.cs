using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class BitacoraProyectoConfig : IEntityTypeConfiguration<BitacoraProyecto>
{
    public void Configure(EntityTypeBuilder<BitacoraProyecto> builder)
    {
        builder
           .Property(c => c.Fecha)
           .HasDefaultValueSql("getutcdate()");

        builder
           .Property(c => c.Comentarios)
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
            .HasOne(p => p.ActividadProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdActividadProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Proyecto)
            .WithMany()
            .HasForeignKey(p => p.IdProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
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
            .HasOne(p => p.TipoBitacora)
            .WithMany()
            .HasForeignKey(p => p.IdTipoBitacora)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

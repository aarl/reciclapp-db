using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class RastreoPublicacionConfig : IEntityTypeConfiguration<RastreoPublicacion>
{
    public void Configure(EntityTypeBuilder<RastreoPublicacion> builder)
    {
        builder
           .Property(c => c.Fecha)
           .HasDefaultValueSql("getutcdate()");

        builder
           .Property(c => c.TiempoEstimado)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.IdFaseAnterior)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.IdFaseSiguiente)
           .HasDefaultValueSql("NULL");

        builder
           .Property(c => c.Comentarios)
           .HasDefaultValueSql("''");

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
            .HasOne(p => p.Publicacion)
            .WithMany()
            .HasForeignKey(p => p.IdPublicacion)
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
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.FasePublicacion)
            .WithMany()
            .HasForeignKey(p => p.IdFasePublicacion)
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
    }
}

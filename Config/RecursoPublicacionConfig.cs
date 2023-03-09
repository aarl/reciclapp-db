using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class RecursoPublicacionConfig : IEntityTypeConfiguration<RecursoPublicacion>
{
    public void Configure(EntityTypeBuilder<RecursoPublicacion> builder)
    {
        builder
           .Property(c => c.Id)
           .HasDefaultValueSql("newid()");

        builder
           .Property(c => c.Secuencia)
           .HasDefaultValueSql("1");

        builder
           .Property(c => c.Fecha)
           .HasDefaultValueSql("getutcdate()");

        builder
           .Property(c => c.Orden)
           .HasDefaultValueSql("1");

        builder
           .Property(c => c.Nombre)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Tamano)
           .HasDefaultValueSql("0");

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
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.EstatusRecurso)
            .WithMany()
            .HasForeignKey(p => p.IdEstatusRecurso)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.TipoCatalogo)
            .WithMany()
            .HasForeignKey(p => p.IdTipoCatalogo)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.TipoRecurso)
            .WithMany()
            .HasForeignKey(p => p.IdTipoRecurso)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

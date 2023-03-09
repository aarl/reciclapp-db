using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class ComentarioConfig : IEntityTypeConfiguration<Comentario>
{
    public void Configure(EntityTypeBuilder<Comentario> builder)
    {
        builder
           .Property(c => c.Id)
           .HasDefaultValueSql("newid()");

        builder
           .Property(c => c.Fecha)
           .HasDefaultValueSql("getutcdate()");

        builder
           .Property(c => c.Texto)
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
            .HasOne(p => p.Chat)
            .WithMany()
            .HasForeignKey(p => p.IdChat)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Cita)
            .WithMany()
            .HasForeignKey(p => p.IdCita)
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
    }
}

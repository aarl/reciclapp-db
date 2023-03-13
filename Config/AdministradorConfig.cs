using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class AdministradorConfig : IEntityTypeConfiguration<Administrador>
{
    public void Configure(EntityTypeBuilder<Administrador> builder)
    {
        builder
           .Property(c => c.Id)
           .HasDefaultValueSql("newid()");

        builder
           .Property(c => c.Nombre)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Apellido)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Telefono)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Email)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Clave)
           .HasDefaultValueSql("''");

        builder
            .HasOne(p => p.Grupo)
            .WithMany()
            .HasForeignKey(p => p.IdGrupo)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

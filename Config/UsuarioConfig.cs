using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades;

namespace Config;

internal class UsuarioConfig : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
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
           .Property(c => c.SegundoNombre)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.SegundoApellido)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Perfil)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Direccion)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Telefono)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Telefono2)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Email)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Clave)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.Email2)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.MaximoPublicaciones)
           .HasDefaultValueSql("0");

        builder
           .Property(c => c.Estatus)
           .HasDefaultValueSql("''");

        builder
           .Property(c => c.UltimaIp)
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
            .HasOne(p => p.Ciudad)
            .WithMany()
            .HasForeignKey(p => p.IdCiudad)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Grupo)
            .WithMany()
            .HasForeignKey(p => p.IdGrupo)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.TipoUsuario)
            .WithMany()
            .HasForeignKey(p => p.IdTipoUsuario)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Profesion)
            .WithMany()
            .HasForeignKey(p => p.IdProfesion)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.Rol)
            .WithMany()
            .HasForeignKey(p => p.IdRol)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

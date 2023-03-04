
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Entidades;

namespace DB;

public class SSDBContext : DbContext
{
    public DbSet<ActividadProyecto> ActividadesProyectos { get; set; } = null!;
    public DbSet<ActividadRutaProyecto> ActividadesRutasProyectos { get; set; } = null!;
    public DbSet<BitacoraProyecto> BitacorasProyectos { get; set; } = null!;
    public DbSet<Chat> Chats { get; set; } = null!;
    public DbSet<Comentario> Comentarios { get; set; } = null!;
    public DbSet<Moneda> Monedas { get; set; } = null!;
    public DbSet<Personal> Personal { get; set; } = null!;
    public DbSet<Proyecto> Proyectos { get; set; } = null!;
    public DbSet<Publicacion> Publicaciones { get; set; } = null!;
    public DbSet<RastreoPublicacion> RastreoPublicaciones { get; set; } = null!;
    public DbSet<RecursoPublicacion> RecursosPublicaciones { get; set; } = null!;
    public DbSet<Secuencia> Secuencias { get; set; } = null!;
    public DbSet<Tabla> Tablas { get; set; } = null!;
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Varios> Varias { get; set; } = null!;
    public DbSet<VersionApi> VersionesApi { get; set; } = null!;

    public SSDBContext(DbContextOptions<SSDBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // Indices
        CrearIndices(mb);
    }

    private void CrearIndices(ModelBuilder mb)
    {
        mb.Entity<ActividadRutaProyecto>()
            .HasIndex(p => p.Descripcion).IsUnique();

        mb.Entity<Chat>()
            .HasIndex(p => p.Titulo).IsUnique();

        mb.Entity<Moneda>()
            .HasIndex(p => p.Nombre).IsUnique();

        mb.Entity<Personal>()
           .HasKey(c => new { c.IdPublicacion, c.IdUsuario });

        mb.Entity<Personal>()
            .HasIndex(p => new { p.IdPublicacion, p.IdRol }).IsUnique();

        mb.Entity<Proyecto>()
            .HasIndex(c => c.Titulo).IsUnique();

        mb.Entity<Publicacion>()
            .HasIndex(p => p.Titulo).IsUnique();

        mb.Entity<Secuencia>()
            .HasIndex(p => p.Prefijo).IsUnique();

        mb.Entity<Usuario>()
            .HasIndex(p => new { p.Nombre, p.SegundoNombre, p.Apellido, p.SegundoApellido }).IsUnique();

        mb.Entity<Usuario>()
            .HasIndex(p => p.Email).IsUnique();

        mb.Entity<Varios>()
            .HasIndex(p => new { p.IdTabla, p.Descripcion }).IsUnique();
    }
}

using Microsoft.EntityFrameworkCore;
using Entidades;

namespace DB;

public class SSDBContext : DbContext
{
    public DbSet<ActividadProyecto> ActividadesProyectos { get; set; } = null!;
    public DbSet<ActividadRutaProyecto> ActividadesRutasProyectos { get; set; } = null!;
    public DbSet<Administrador> Administradores { get; set; } = null!;
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

    public SSDBContext(DbContextOptions<SSDBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        // Valores por defecto
        ActividadProyectoValoresPorDefecto(mb);
        ActividadRutaProyectoValoresPorDefecto(mb);
        AdministradorValoresPorDefecto(mb);
        BitacoraProyectoValoresPorDefecto(mb);
        ChatValoresPorDefecto(mb);
        ComentarioValoresPorDefecto(mb);
        MonedaValoresPorDefecto(mb);
        PersonalValoresPorDefecto(mb);
        ProyectoValoresPorDefecto(mb);
        PublicacionValoresPorDefecto(mb);
        RastreoPublicacionValoresPorDefecto(mb);
        RecursoPublicacionValoresPorDefecto(mb);
        SecuenciaValoresPorDefecto(mb);
        TablaValoresPorDefecto(mb);
        UsuarioValoresPorDefecto(mb);
        VariosValoresPorDefecto(mb);

        // Indices
        CrearIndices(mb);

        // Relaciones
        ActividadProyectoRelaciones(mb);
        ActividadRutaProyectoRelaciones(mb);
        AdministradorRelaciones(mb);
        BitacoraProyectoRelaciones(mb);
        ChatRelaciones(mb);
        ComentarioRelaciones(mb);
        MonedaRelaciones(mb);
        PersonalRelaciones(mb);
        ProyectoRelaciones(mb);
        PublicacionRelaciones(mb);
        RastreoPublicacionRelaciones(mb);
        RecursoPublicacionRelaciones(mb);
        SecuenciaRelaciones(mb);
        TablaRelaciones(mb);
        UsuarioRelaciones(mb);
        VariosRelaciones(mb);
    }

    // Valores por defecto
    private void ActividadProyectoValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<ActividadProyecto>()
           .Property(c => c.Id)
           .UseIdentityColumn();

        mb.Entity<ActividadProyecto>()
           .Property(c => c.Descripcion)
           .HasDefaultValueSql("''");

        mb.Entity<ActividadProyecto>()
           .Property(c => c.FechaInicio)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<ActividadProyecto>()
           .Property(c => c.FechaFinalizacion)
           .HasDefaultValueSql("null");

        mb.Entity<ActividadProyecto>()
           .Property(c => c.TiempoEstimado)
           .HasDefaultValue(0);

        mb.Entity<ActividadProyecto>()
           .Property(c => c.ProgresoEstimado)
           .HasDefaultValue(0);

        mb.Entity<ActividadProyecto>()
           .Property(c => c.Evaluacion)
           .HasDefaultValue(0);

        mb.Entity<ActividadProyecto>()
           .Property(c => c.FechaDisponible)
           .HasDefaultValueSql("null");

        mb.Entity<ActividadProyecto>()
           .Property(c => c.TotalArticulos)
           .HasDefaultValue(0.0);

        mb.Entity<ActividadProyecto>()
           .Property(c => c.CostoEstimado)
           .HasDefaultValue(0.0);

        mb.Entity<ActividadProyecto>()
           .Property(c => c.MonedaCostoEstimado)
           .HasDefaultValueSql("''");

        mb.Entity<ActividadProyecto>()
           .Property(c => c.TipoCambioCostoEstimado)
           .HasDefaultValue(0.0);

        mb.Entity<ActividadProyecto>()
           .Property(c => c.CostoReal)
           .HasDefaultValue(0.0);

        mb.Entity<ActividadProyecto>()
           .Property(c => c.MonedaCostoReal)
           .HasDefaultValueSql("''");

        mb.Entity<ActividadProyecto>()
           .Property(c => c.TipoCambioCostoReal)
           .HasDefaultValue(0.0);

        mb.Entity<ActividadProyecto>()
           .Property(c => c.FechaCreacion)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<ActividadProyecto>()
           .Property(c => c.FechaModificacion)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<ActividadProyecto>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<ActividadProyecto>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void ActividadRutaProyectoValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<ActividadRutaProyecto>()
           .Property(c => c.Descripcion)
           .HasDefaultValueSql("''");

        mb.Entity<ActividadRutaProyecto>()
           .Property(c => c.Secuencia)
           .HasDefaultValue(1);

        mb.Entity<ActividadRutaProyecto>()
           .Property(c => c.Descripcion)
           .HasDefaultValueSql("''");

        mb.Entity<ActividadRutaProyecto>()
           .Property(c => c.FechaCreacion)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<ActividadRutaProyecto>()
           .Property(c => c.FechaModificacion)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<ActividadRutaProyecto>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<ActividadRutaProyecto>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void AdministradorValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Administrador>()
           .Property(c => c.Id)
           .HasDefaultValueSql("newid()");

        mb.Entity<Administrador>()
            .Property(c => c.Nombre)
            .HasDefaultValueSql("''");

        mb.Entity<Administrador>()
            .Property(c => c.Telefono)
            .HasDefaultValueSql("''");

        mb.Entity<Administrador>()
             .Property(c => c.Email)
             .HasDefaultValueSql("''");

        mb.Entity<Administrador>()
            .Property(c => c.FechaRegistro)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Administrador>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Administrador>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void BitacoraProyectoValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<BitacoraProyecto>()
            .Property(c => c.Fecha)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<BitacoraProyecto>()
            .Property(c => c.FechaCreacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<BitacoraProyecto>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<BitacoraProyecto>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<BitacoraProyecto>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void ChatValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Chat>()
            .Property(c => c.Id)
            .HasDefaultValueSql("newid()");

        mb.Entity<Chat>()
            .Property(c => c.Titulo)
            .HasDefaultValueSql("''");

        mb.Entity<Chat>()
            .Property(c => c.Fecha)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Chat>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Chat>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Chat>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Chat>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void ComentarioValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Comentario>()
            .Property(c => c.Id)
            .HasDefaultValueSql("newid()");

        mb.Entity<Comentario>()
             .Property(c => c.Fecha)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Comentario>()
            .Property(c => c.Texto)
            .HasDefaultValueSql("''");

        mb.Entity<Comentario>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Comentario>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Comentario>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Comentario>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void MonedaValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Moneda>()
            .Property(c => c.TipoCambio)
            .HasDefaultValue(0.0);

        mb.Entity<Moneda>()
           .Property(c => c.FechaCreacion)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<Moneda>()
           .Property(c => c.FechaModificacion)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<Moneda>()
            .Property(c => c.EsLocal)
            .HasDefaultValueSql("0");

        mb.Entity<Moneda>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Moneda>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void PersonalValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Personal>()
             .Property(c => c.Fecha)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Personal>()
            .Property(c => c.IdCreador)
            .HasDefaultValueSql("null");

        mb.Entity<Personal>()
            .Property(c => c.IdModificador)
            .HasDefaultValueSql("null");

        mb.Entity<Personal>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Personal>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Personal>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Personal>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void ProyectoValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Proyecto>()
           .Property(c => c.Id)
           .HasDefaultValueSql("newid()");

        mb.Entity<Proyecto>()
           .Property(c => c.Titulo)
           .HasDefaultValueSql("''");

        mb.Entity<Proyecto>()
           .Property(c => c.Descripcion)
           .HasDefaultValueSql("''");

        mb.Entity<Proyecto>()
           .Property(c => c.FechaInicio)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<Proyecto>()
           .Property(c => c.Gustan)
           .HasDefaultValue(0);

        mb.Entity<Proyecto>()
           .Property(c => c.NoGustan)
           .HasDefaultValue(0);

        mb.Entity<Proyecto>()
           .Property(c => c.TiempoEstimado)
           .HasDefaultValue(0);

        mb.Entity<Proyecto>()
           .Property(c => c.ProgresoEstimado)
           .HasDefaultValue(0);

        mb.Entity<Proyecto>()
           .Property(c => c.ProgresoReal)
           .HasDefaultValue(0);

        mb.Entity<Proyecto>()
           .Property(c => c.Evaluacion)
           .HasDefaultValue(0);

        mb.Entity<Proyecto>()
           .Property(c => c.FechaDisponible)
           .HasDefaultValueSql("null");

        mb.Entity<Proyecto>()
           .Property(c => c.TotalArticulos)
           .HasDefaultValue(0.0);

        mb.Entity<Proyecto>()
           .Property(c => c.CostoEstimado)
           .HasDefaultValue(0.0);

        mb.Entity<Proyecto>()
           .Property(c => c.MonedaCostoEstimado)
           .HasDefaultValueSql("''");

        mb.Entity<Proyecto>()
           .Property(c => c.TipoCambioCostoEstimado)
           .HasDefaultValue(0.0);

        mb.Entity<Proyecto>()
           .Property(c => c.CostoReal)
           .HasDefaultValue(0.0);

        mb.Entity<Proyecto>()
           .Property(c => c.MonedaCostoReal)
           .HasDefaultValueSql("''");

        mb.Entity<Proyecto>()
           .Property(c => c.TipoCambioCostoReal)
           .HasDefaultValue(0.0);

        mb.Entity<Proyecto>()
           .Property(c => c.FechaCreacion)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<Proyecto>()
           .Property(c => c.FechaModificacion)
           .HasDefaultValueSql("getutcdate()");

        mb.Entity<Proyecto>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Proyecto>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void PublicacionValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Publicacion>()
            .Property(c => c.Id)
            .HasDefaultValueSql("newid()");

        mb.Entity<Publicacion>()
            .Property(c => c.Titulo)
            .HasDefaultValueSql("''");

        mb.Entity<Publicacion>()
            .Property(c => c.Descripcion)
            .HasDefaultValueSql("''");

        mb.Entity<Publicacion>()
             .Property(c => c.Fecha)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Publicacion>()
            .Property(c => c.Gustan)
            .HasDefaultValue(0);

        mb.Entity<Publicacion>()
            .Property(c => c.NoGustan)
            .HasDefaultValue(0);

        mb.Entity<Publicacion>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Publicacion>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Publicacion>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Publicacion>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void RastreoPublicacionValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<RastreoPublicacion>()
            .Property(p => p.Id)
            .UseIdentityColumn();

        mb.Entity<RastreoPublicacion>()
             .Property(c => c.Fecha)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<RastreoPublicacion>()
             .Property(c => c.TiempoEstimado)
             .HasDefaultValue(0);

        mb.Entity<RastreoPublicacion>()
             .Property(c => c.Comentarios)
             .HasDefaultValueSql("''");

        mb.Entity<RastreoPublicacion>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<RastreoPublicacion>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<RastreoPublicacion>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<RastreoPublicacion>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void RecursoPublicacionValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<RecursoPublicacion>()
            .Property(c => c.Id)
            .HasDefaultValueSql("newid()");

        mb.Entity<RecursoPublicacion>()
             .Property(c => c.Fecha)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<RecursoPublicacion>()
             .Property(c => c.Orden)
             .HasDefaultValue(1);

        mb.Entity<RecursoPublicacion>()
             .Property(c => c.Nombre)
             .HasDefaultValueSql("''");

        mb.Entity<RecursoPublicacion>()
             .Property(c => c.Tamaño)
             .HasDefaultValue(0);

        mb.Entity<RecursoPublicacion>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<RecursoPublicacion>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<RecursoPublicacion>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<RecursoPublicacion>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void SecuenciaValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Secuencia>()
           .Property(c => c.Prefijo)
           .HasDefaultValueSql("''");

        mb.Entity<Secuencia>()
           .Property(c => c.Serie)
           .HasDefaultValue(1);

        mb.Entity<Secuencia>()
           .Property(c => c.Incremento)
           .HasDefaultValue(1);

        mb.Entity<Secuencia>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Secuencia>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Secuencia>()
            .Property(p => p.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Secuencia>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void TablaValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Tabla>()
           .Property(c => c.Descripcion)
           .HasDefaultValueSql("''");

        mb.Entity<Tabla>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Tabla>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Tabla>()
            .Property(p => p.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Tabla>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void UsuarioValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Usuario>()
           .Property(c => c.Id)
           .HasDefaultValueSql("newid()");

        mb.Entity<Usuario>()
            .Property(c => c.Nombre)
            .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
            .Property(c => c.Nombre2)
            .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
            .Property(c => c.Apellido)
            .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
            .Property(c => c.Apellido2)
            .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
            .Property(c => c.Perfil)
            .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
            .Property(c => c.Direccion)
            .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
            .Property(c => c.Telefono)
            .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
            .Property(c => c.Telefono2)
            .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
             .Property(c => c.Email)
             .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
            .Property(c => c.Email2)
            .HasDefaultValueSql("''");

        mb.Entity<Usuario>()
            .Property(c => c.MaximoPublicaciones)
            .HasDefaultValue(0);

        mb.Entity<Usuario>()
            .Property(c => c.IdProfesion)
            .HasDefaultValueSql("null");

        mb.Entity<Usuario>()
            .Property(c => c.IdCreador)
            .HasDefaultValueSql("null");

        mb.Entity<Usuario>()
            .Property(c => c.IdModificador)
            .HasDefaultValueSql("null");

        mb.Entity<Usuario>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Usuario>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Usuario>()
            .Property(c => c.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Usuario>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    private void VariosValoresPorDefecto(ModelBuilder mb)
    {
        mb.Entity<Varios>()
            .Property(p => p.Descripcion)
            .HasDefaultValueSql("''");

        mb.Entity<Varios>()
            .Property(p => p.Referencia)
            .HasDefaultValueSql("''");

        mb.Entity<Varios>()
             .Property(c => c.FechaCreacion)
             .HasDefaultValueSql("getutcdate()");

        mb.Entity<Varios>()
            .Property(c => c.FechaModificacion)
            .HasDefaultValueSql("getutcdate()");

        mb.Entity<Varios>()
            .Property(p => p.Activo)
            .HasDefaultValueSql("1");

        mb.Entity<Varios>()
            .Property(c => c.VersionAPI)
            .HasDefaultValueSql("''");
    }

    // Indices
    private void CrearIndices(ModelBuilder mb)
    {
        mb.Entity<ActividadRutaProyecto>()
            .HasIndex(p => p.Descripcion).IsUnique();

        mb.Entity<Administrador>()
            .HasIndex(p => p.Nombre).IsUnique();

        mb.Entity<Administrador>()
            .HasIndex(p => p.Email).IsUnique();

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

        mb.Entity<Usuario>()
            .HasIndex(p => new { p.Nombre, p.Nombre2, p.Apellido, p.Apellido2 }).IsUnique();

        mb.Entity<Usuario>()
            .HasIndex(p => p.Email).IsUnique();

        mb.Entity<Varios>()
            .HasIndex(p => new { p.IdTabla, p.Descripcion }).IsUnique();
    }

    // Relaciones
    private void ActividadProyectoRelaciones(ModelBuilder mb)
    {
        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.ActividadRuta)
            .WithMany()
            .HasForeignKey(p => p.IdActividadRuta)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.Ejecutor)
            .WithMany()
            .HasForeignKey(p => p.IdEjecutor)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.EstatusProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdEstatusProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.EstatusPublicacion)
            .WithMany()
            .HasForeignKey(p => p.IdEstatusPublicacion)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.Proyecto)
            .WithMany()
            .HasForeignKey(p => p.IdProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.RevisadaPor)
            .WithMany()
            .HasForeignKey(p => p.IdRevisadaPor)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.Revisor)
            .WithMany()
            .HasForeignKey(p => p.IdRevisor)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.RutaProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdRutaProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadProyecto>()
            .HasOne(p => p.TipoActividad)
            .WithMany()
            .HasForeignKey(p => p.IdTipoActividad)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void ActividadRutaProyectoRelaciones(ModelBuilder mb)
    {
        mb.Entity<ActividadRutaProyecto>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ActividadRutaProyecto>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void AdministradorRelaciones(ModelBuilder mb)
    {
        mb.Entity<Administrador>()
          .HasOne(p => p.Grupo)
          .WithMany()
          .HasForeignKey(p => p.IdGrupo)
          .OnDelete(DeleteBehavior.NoAction);
    }

    private void BitacoraProyectoRelaciones(ModelBuilder mb)
    {
        mb.Entity<BitacoraProyecto>()
            .HasOne(p => p.ActividadProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdActividadProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<BitacoraProyecto>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<BitacoraProyecto>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<BitacoraProyecto>()
            .HasOne(p => p.Proyecto)
            .WithMany()
            .HasForeignKey(p => p.IdProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<BitacoraProyecto>()
            .HasOne(p => p.TipoBitacora)
            .WithMany()
            .HasForeignKey(p => p.IdTipoBitacora)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<BitacoraProyecto>()
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void ChatRelaciones(ModelBuilder mb)
    {
        mb.Entity<Chat>()
            .HasMany(p => p.Comentarios)
            .WithOne(p => p.Chat)
            .HasForeignKey(p => p.IdChat)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Chat>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Chat>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void ComentarioRelaciones(ModelBuilder mb)
    {
        mb.Entity<Comentario>()
            .HasMany(p => p.Citas)
            .WithOne()
            .HasForeignKey(p => p.IdComentario)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Comentario>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Comentario>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void MonedaRelaciones(ModelBuilder mb)
    {
        mb.Entity<Moneda>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Moneda>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void PersonalRelaciones(ModelBuilder mb)
    {
        mb.Entity<Personal>()
            .HasOne(p => p.Publicacion)
            .WithMany(p => p.UsuariosLink)
            .HasForeignKey(p => p.IdPublicacion)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Personal>()
            .HasOne(p => p.Usuario)
            .WithMany(p => p.PublicacionesLink)
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Personal>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Personal>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Personal>()
            .HasOne(p => p.Rol)
            .WithMany()
            .HasForeignKey(p => p.IdRol)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void ProyectoRelaciones(ModelBuilder mb)
    {
        mb.Entity<Proyecto>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasOne(p => p.EstatusProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdEstatusProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasOne(p => p.EstatusPublicacion)
            .WithMany()
            .HasForeignKey(p => p.IdEstatusPublicacion)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasOne(p => p.Gerente)
            .WithMany()
            .HasForeignKey(p => p.IdGerente)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasOne(p => p.RevisadaPor)
            .WithMany()
            .HasForeignKey(p => p.IdRevisadaPor)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasOne(p => p.ImagenPrincipal)
            .WithMany()
            .HasForeignKey(p => p.IdImagenPrincipal)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasOne(p => p.Revisor)
            .WithMany()
            .HasForeignKey(p => p.IdRevisor)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasOne(p => p.RutaProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdRutaProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasOne(p => p.TipoProyecto)
            .WithMany()
            .HasForeignKey(p => p.IdTipoProyecto)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Proyecto>()
            .HasMany(p => p.ActividadesProyecto)
            .WithOne()
            .HasForeignKey(p => p.IdProyecto)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void PublicacionRelaciones(ModelBuilder mb)
    {
        mb.Entity<Publicacion>()
            .HasMany(p => p.Chats)
            .WithOne(p => p.Publicacion)
            .HasForeignKey(p => p.IdPublicacion)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Publicacion>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Publicacion>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void RastreoPublicacionRelaciones(ModelBuilder mb)
    {
        mb.Entity<RastreoPublicacion>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<RastreoPublicacion>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<RastreoPublicacion>()
            .HasOne(p => p.Publicacion)
            .WithMany()
            .HasForeignKey(p => p.IdPublicacion)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<RastreoPublicacion>()
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void RecursoPublicacionRelaciones(ModelBuilder mb)
    {
        mb.Entity<RecursoPublicacion>()
            .HasOne(p => p.TipoCatalogo)
            .WithMany()
            .HasForeignKey(p => p.IdTipoCatalogo)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<RecursoPublicacion>()
            .HasOne(p => p.Secuencia)
            .WithMany()
            .HasForeignKey(p => p.IdSecuencia)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<RecursoPublicacion>()
            .HasOne(p => p.TipoRecurso)
            .WithMany()
            .HasForeignKey(p => p.IdTipoRecurso)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<RecursoPublicacion>()
            .HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<RecursoPublicacion>()
            .HasOne(p => p.EstatusRecurso)
            .WithMany()
            .HasForeignKey(p => p.IdEstatusRecurso)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<RecursoPublicacion>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<RecursoPublicacion>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void SecuenciaRelaciones(ModelBuilder mb)
    {
        mb.Entity<Secuencia>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Secuencia>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void TablaRelaciones(ModelBuilder mb)
    {
        mb.Entity<Tabla>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Tabla>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void UsuarioRelaciones(ModelBuilder mb)
    {
        mb.Entity<Usuario>()
          .HasOne(p => p.Ciudad)
          .WithMany()
          .HasForeignKey(p => p.IdCiudad)
          .OnDelete(DeleteBehavior.ClientNoAction);

        mb.Entity<Usuario>()
          .HasOne(p => p.Grupo)
          .WithMany()
          .HasForeignKey(p => p.IdGrupo)
          .OnDelete(DeleteBehavior.ClientNoAction);

        mb.Entity<Usuario>()
          .HasOne(p => p.Profesion)
          .WithMany()
          .HasForeignKey(p => p.IdProfesion)
          .OnDelete(DeleteBehavior.ClientNoAction);

        mb.Entity<Usuario>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Usuario>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Usuario>()
            .HasMany(p => p.Comentarios)
            .WithOne(p => p.Usuario)
            .HasForeignKey(p => p.IdUsuario)
            .OnDelete(DeleteBehavior.NoAction);
    }

    private void VariosRelaciones(ModelBuilder mb)
    {
        mb.Entity<Varios>()
            .HasOne(p => p.Tabla)
            .WithMany()
            .HasForeignKey(p => p.IdTabla)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Varios>()
            .HasOne(p => p.Padre)
            .WithMany()
            .HasForeignKey(p => p.IdPadre)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Varios>()
            .HasOne(p => p.Creador)
            .WithMany()
            .HasForeignKey(p => p.IdCreador)
            .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Varios>()
            .HasOne(p => p.Modificador)
            .WithMany()
            .HasForeignKey(p => p.IdModificador)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

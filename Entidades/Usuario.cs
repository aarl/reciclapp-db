using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

[Table("usuarios")]
public class Usuario : Entidad
{
    [Column("id")]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("nombre")]
    [MaxLength(100)]
    public string Nombre { get; set; } = "";
    [MaxLength(100)]
    [Column("apellido")]
    public string Apellido { get; set; } = "";
    [Column("segundo_nombre")]
    [MaxLength(50, ErrorMessage = "El segundo nombre no debe exceder los 50 caracteres")]
    public string Nombre2 { get; set; } = "";
    [Column("segundo_apellido")]
    [MaxLength(50, ErrorMessage = "El segundo apellido no debe exceder los 50 caracteres")]
    public string Apellido2 { get; set; } = "";
    [Column("perfil")]
    [MaxLength(200, ErrorMessage = "La descripción del perfil no debe exceder los 200 caracteres")]
    public string Perfil { get; set; } = "";
    [Column("direccion")]
    [MaxLength(300, ErrorMessage = "La dirección no debe exceder los 300 caracteres")]
    public string Direccion { get; set; } = "";
    [Column("id_ciudad")]
    public int? IdCiudad { get; set; }
    [Column("telefono")]
    [Phone]
    [MaxLength(20)]
    public string Telefono { get; set; } = "";
    [Column("telefono2")]
    [MaxLength(20, ErrorMessage = "El número telefónico opcional no debe exceder los 20 caracteres")]
    public string? Telefono2 { get; set; } = "";
    [Column("email")]
    [EmailAddress]
    [MaxLength(300)]
    public string Email { get; set; } = "";
    [JsonIgnore]
    [Column("clave")]
    [MaxLength(256)]
    public string Clave { get; set; } = "";
    [Column("email2")]
    [MaxLength(250, ErrorMessage = "La dirección de correo opcional no debe exceder los 250 caracteres")]
    public string Email2 { get; set; } = "";
    [Column("id_profesion")]
    public int? IdProfesion { get; set; }
    [Column("max_publicaciones")]
    public int MaximoPublicaciones { get; set; } = 0;
    [Column("id_grupo")]
    public int? IdGrupo { get; set; }
    [Column("estatus")]
    [MaxLength(2)]
    public string Estatus { get; set; } = "";
    [Column("id_tipo_usuario")]
    public int? IdTipoUsuario { get; set; } = 0;      // 0 = Normal, 1 = Verificado
    [Column("id_rol")]
    public int? IdRol { get; set; }      // Publicador, evaluador, proyectista, orfebre, etc...
    [Column("ultima_ip")]
    [MaxLength(20)]
    public string UltimaIP { get; set; } = "";

    [JsonIgnore]
    public virtual Varios? Ciudad { get; set; }
    [JsonIgnore]
    public virtual Varios? Grupo { get; set; }
    [JsonIgnore]
    public virtual Varios? Profesion { get; set; }
    [JsonIgnore]
    public virtual Varios? Tipousuario { get; set; }
    [JsonIgnore]
    public virtual Varios? Rol { get; set; }
    [JsonIgnore]
    public virtual ICollection<Comentario>? Comentarios { get; set; }
    [JsonIgnore]
    public virtual ICollection<Personal>? PublicacionesLink { get; set; }
}

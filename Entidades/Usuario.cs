using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("usuarios")]
public class Usuario : EntidadAdmin
{
	[Column("id")]
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();

	[Column("nombre")]
	[MaxLength(100)]
	public string Nombre { get; set; } = "";

	[Column("apellido")]
	[MaxLength(100)]
	public string Apellido { get; set; } = "";

	[Column("segundo_nombre")]
	public string? SegundoNombre { get; set; } = "";

	[Column("segundo_apellido")]
	public string? SegundoApellido { get; set; } = "";

	[Column("perfil")]
	public string? Perfil { get; set; } = "";

	[Column("direccion")]
	[MaxLength(300)]
	public string Direccion { get; set; } = "";

	[Column("id_ciudad")]
	public int IdCiudad { get; set; }

	[Column("telefono")]
	[MaxLength(20)]
	public string Telefono { get; set; } = "";

	[Column("telefono2")]
	public string? Telefono2 { get; set; } = "";

	[Column("email")]
	[MaxLength(300)]
	public string Email { get; set; } = "";

	[Column("clave")]
	[MaxLength(256)]
	[IsProjected(false)]
	public string Clave { get; set; } = "";

	[Column("email2")]
	public string? Email2 { get; set; } = "";

	[Column("id_profesion")]
	public int? IdProfesion { get; set; }

	[Column("maximo_publicaciones")]
	public int? MaximoPublicaciones { get; set; } = 0;

	[Column("id_grupo")]
	public int IdGrupo { get; set; }

	[Column("estatus")]
	public string? Estatus { get; set; } = "";

	[Column("id_tipo_usuario")]
	public int IdTipoUsuario { get; set; }

	[Column("id_rol")]
	public int? IdRol { get; set; }

	[Column("ultima_ip")]
	public string? UltimaIp { get; set; } = "";


	[JsonIgnore]
	public virtual Varios? Ciudad { get; set; }

	[JsonIgnore]
	public virtual Varios? Profesion { get; set; }

	[JsonIgnore]
	public virtual Varios? Grupo { get; set; }

	[JsonIgnore]
	public virtual Varios? TipoUsuario { get; set; }

	[JsonIgnore]
	public virtual Varios? Rol { get; set; }
}

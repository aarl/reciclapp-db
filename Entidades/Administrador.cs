using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("administradores")]
public class Administrador 
{
	[Column("id")]
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();

	[Column("nombre")]
	[MaxLength(50)]
	public string Nombre { get; set; } = "";

	[Column("apellido")]
	[MaxLength(50)]
	public string Apellido { get; set; } = "";

	[Column("telefono")]
	[MaxLength(20)]
	public string Telefono { get; set; } = "";

	[Column("email")]
	[MaxLength(300)]
	public string Email { get; set; } = "";

	[Column("clave")]
	[MaxLength(256)]
	[IsProjected(false)]
	public string Clave { get; set; } = "";

	[Column("id_grupo")]
	public int? IdGrupo { get; set; }


	[JsonIgnore]
	public virtual Varios? Grupo { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("varios")]
public class Varios : EntidadAdmin
{
	[Column("id")]
	[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	[Column("id_tabla")]
	[MaxLength(10)]
	public string IdTabla { get; set; } = "";

	[Column("descripcion")]
	[MaxLength(1000)]
	public string Descripcion { get; set; } = "";

	[Column("referencia")]
	public string? Referencia { get; set; } = "";

	[Column("id_padre")]
	public int? IdPadre { get; set; }


	[JsonIgnore]
	public virtual Tabla? Tabla { get; set; }

	[JsonIgnore]
	public virtual Varios? Padre { get; set; }
}

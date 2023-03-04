using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("recursos_publicaciones")]
public class RecursoPublicacion : Entidad
{
	[Column("id")]
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();

	[Column("id_tipo_catalogo")]
	public int IdTipoCatalogo { get; set; }

	[Column("id_catalogo")]
	public Guid IdCatalogo { get; set; }

	[Column("secuencia")]
	public int Secuencia { get; set; }

	[Column("id_tipo_recurso")]
	public int IdTipoRecurso { get; set; }

	[Column("fecha")]
	public DateTime Fecha { get; set; } = DateTime.UtcNow;

	[Column("id_usuario")]
	public Guid IdUsuario { get; set; }

	[Column("orden")]
	public int Orden { get; set; } = 1;

	[Column("nombre")]
	[MaxLength(100)]
	public string Nombre { get; set; } = "";

	[Column("id_estatus_recurso")]
	public int IdEstatusRecurso { get; set; }

	[Column("fecha_expiracion")]
	public DateTime? FechaExpiracion { get; set; } = null;

	[Column("tamano")]
	public long Tamano { get; set; } = 0;


	[JsonIgnore]
	public virtual Varios? TipoCatalogo { get; set; }

	[JsonIgnore]
	public virtual Varios? TipoRecurso { get; set; }

	[JsonIgnore]
	public virtual Usuario? Usuario { get; set; }

	[JsonIgnore]
	public virtual Varios? EstatusRecurso { get; set; }
}

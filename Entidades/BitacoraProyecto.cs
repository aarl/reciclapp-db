using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("bitacoras_proyectos")]
public class BitacoraProyecto : Entidad
{
	[Column("id")]
	[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public long Id { get; set; }

	[Column("id_proyecto")]
	public Guid IdProyecto { get; set; }

	[Column("id_actividad_proyecto")]
	public long IdActividadProyecto { get; set; }

	[Column("fecha")]
	public DateTime Fecha { get; set; } = DateTime.UtcNow;

	[Column("id_usuario")]
	public Guid IdUsuario { get; set; }

	[Column("id_tipo_bitacora")]
	public int IdTipoBitacora { get; set; }

	[Column("comentarios")]
	public string Comentarios { get; set; } = "";


	[JsonIgnore]
	public virtual Proyecto? Proyecto { get; set; }

	[JsonIgnore]
	public virtual ActividadProyecto? ActividadProyecto { get; set; }

	[JsonIgnore]
	public virtual Usuario? Usuario { get; set; }

	[JsonIgnore]
	public virtual Varios? TipoBitacora { get; set; }
}

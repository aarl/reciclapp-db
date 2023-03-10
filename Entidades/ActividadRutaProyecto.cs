using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("actividades_rutas_proyectos")]
public class ActividadRutaProyecto : Entidad
{
	[Column("id")]
	[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	[Column("id_ruta_proyecto")]
	public int IdRutaProyecto { get; set; }

	[Column("descripcion")]
	[MaxLength(450)]
	public string Descripcion { get; set; } = "";

	[Column("secuencia")]
	public int Secuencia { get; set; } = 1;


	[JsonIgnore]
	public virtual Varios? RutaProyecto { get; set; }
}

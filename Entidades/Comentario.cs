using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("comentarios")]
public class Comentario : Entidad
{
	[Column("id")]
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();

	[Column("id_chat")]
	public Guid IdChat { get; set; }

	[Column("id_usuario")]
	public Guid IdUsuario { get; set; }

	[Column("fecha")]
	public DateTime Fecha { get; set; } = DateTime.UtcNow;

	[Column("texto")]
	public string Texto { get; set; } = "";

	[Column("id_cita")]
	public Guid? IdCita { get; set; }


	[JsonIgnore]
	public virtual Chat? Chat { get; set; }

	[JsonIgnore]
	public virtual Usuario? Usuario { get; set; }

	[JsonIgnore]
	public virtual Comentario? Cita { get; set; }
}

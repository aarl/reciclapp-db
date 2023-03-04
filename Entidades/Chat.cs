using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("chats")]
public class Chat : Entidad
{
	[Column("id")]
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();

	[Column("id_publicacion")]
	public Guid IdPublicacion { get; set; }

	[Column("titulo")]
	[MaxLength(300)]
	public string Titulo { get; set; } = "";

	[Column("fecha")]
	public DateTime Fecha { get; set; } = DateTime.UtcNow;


	[JsonIgnore]
	public virtual Publicacion? Publicacion { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("versiones_api")]
public class VersionApi : EntidadAdmin
{
	[Column("id")]
	[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	[Column("version")]
	[MaxLength(15)]
	public string Version { get; set; } = "";

	[Column("vigente_desde")]
	public DateTime VigenteDesde { get; set; } = DateTime.UtcNow;



}

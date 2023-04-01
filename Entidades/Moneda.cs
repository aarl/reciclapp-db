using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("monedas")]
public class Moneda : EntidadAdmin
{
	[Column("id")]
	[Key]
	[MaxLength(3)]
	public string Id { get; set; } = "";

	[Column("nombre")]
	[MaxLength(20)]
	public string Nombre { get; set; } = "";

	[Column("simbolo")]
	[MaxLength(5)]
	public string Simbolo { get; set; } = "";

	[Column("tipo_cambio")]
	[Precision(10, 2)]
	public decimal TipoCambio { get; set; } = 0.0M;

	[Column("es_local")]
	public bool? EsLocal { get; set; } = false;



}

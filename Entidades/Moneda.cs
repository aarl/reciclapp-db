using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("monedas")]
public class Moneda : Entidad
{
    [Column("id")]
    [MaxLength(3)]
    [Key]
    public string Id { get; set; } = "";
    [Column("nombre")]
    [MaxLength(20)]
    public string Nombre { get; set; } = "";
    [Column("tipo_cambio")]
    [Precision(10, 2)]
    public decimal TipoCambio { get; set; } = 0.0M;
    [Column("es_local")]
    public Boolean? EsLocal { get; set; } = false;
}
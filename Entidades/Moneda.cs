using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("monedas")]
public class Moneda
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
    [Column("id_creador")]
    public Guid IdCreador { get; set; }
    [Column("fecha_creacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    [Column("id_modificador")]
    public Guid IdModificador { get; set; }
    [Column("fecha_modificacion")]
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
    [Column("activo")]
    public bool? Activo { get; set; } = true;
    [Column("version_api")]
    public string VersionAPI { get; set; } = "";

    [JsonIgnore]
    public virtual Usuario? Creador { get; set; }
    [JsonIgnore]
    public virtual Usuario? Modificador { get; set; }
}
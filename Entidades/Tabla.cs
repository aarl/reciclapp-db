using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

[Table("tablas")]
public class Tabla : Entidad
{
    [Column("id")]
    [Key]
    [MaxLength(10)]
    public string Id { get; set; } = "";
    [Column("descripcion")]
    public string Descripcion { get; set; } = "";
}
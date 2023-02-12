using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

[Table("secuencias")]
public class Secuencia : Entidad
{
    [Column("id")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column("prefijo")]
    [MaxLength(10)]
    public string Prefijo { get; set; } = "";
    [Column("serie")]
    public long Serie { get; set; } = 1;
    [Column("incremento")]
    public int Incremento { get; set; } = 1;
}
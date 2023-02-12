using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

[Table("administradores")]
public class Administrador : Persona
{
    [Column("fecha_registro")]
    public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
    [Column("id_grupo")]
    public int? IdGrupo { get; set; } = null;

    [JsonIgnore]
    public virtual Varios? Grupo { get; set; }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

[Table("personal")]
public class Personal : Entidad
{
    [Column("id_publicacion")]
    public Guid IdPublicacion { get; set; }
    [Column("id_usuario")]
    public Guid IdUsuario { get; set; }
    [Column("fecha")]
    public DateTime Fecha { get; set; } = DateTime.UtcNow;
    [Column("id_rol")]
    public int IdRol { get; set; }

    [JsonIgnore]
    public virtual Publicacion? Publicacion { get; set; }
    [JsonIgnore]
    public virtual Usuario? Usuario { get; set; }
    [JsonIgnore]
    public virtual Varios? Rol { get; set; }
}

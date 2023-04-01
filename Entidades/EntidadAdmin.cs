using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

public class EntidadAdmin
{
    [Column("id_creador")]
    public Guid? IdCreador { get; set; }
    [Column("fecha_creacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    [Column("id_modificador")]
    public Guid? IdModificador { get; set; }
    [Column("fecha_modificacion")]
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
    [Column("activo")]
    public bool? Activo { get; set; } = true;
    [Column("version_api")]
    [MaxLength(15)]
    public string VersionApi { get; set; } = "";

    [JsonIgnore]
    public virtual Administrador? Creador { get; set; }
    [JsonIgnore]
    public virtual Administrador? Modificador { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

[Table("recursos_publicaciones")]
public class RecursoPublicacion : Entidad
{
    [Column("id")]
    [Key]
    public Guid Id { get; set; }
    [Column("id_tipo_catalogo")]
    public int IdTipoCatalogo { get; set; }     // Publicacion o Proyecto
    [Column("id_catalogo")]
    public Guid IdCatalogo { get; set; }        // Id de publicacion o proyecto
    [Column("secuencia")]
    public int Secuencia { get; set; }          // Secuencia del registro segun catalogo
    [Column("id_tipo_recurso")]
    public int IdTipoRecurso { get; set; }
    [Column("fecha")]
    public DateTime Fecha { get; set; } = DateTime.UtcNow;  // Fecha creacion recurso
    [Column("id_usuario")]
    public Guid IdUsuario { get; set; }         // Id del usuario que lo movió a este estado
    [Column("orden")]
    public int Orden { get; set; } = 1;         // Orden del recurso en la vista del usuario
    [Column("nombre")]
    public string Nombre { get; set; } = "";    // Nombre visible del recurso
    [Column("id_estatus_recurso")]
    public int IdEstatusRecurso { get; set; }   // 0 = En proceso de aprobacion, 10 = Aprobado, 20 = No mostrar, etc.
    [Column("fecha_expiracion")]
    public DateTime? FechaExpiracion { get; set; } = null;
    [Column("tamano")]
    public long Tamaño { get; set; } = 0;       // Tamaño del recurso en MB

    [JsonIgnore]
    public virtual Varios? TipoCatalogo { get; set; }
    [JsonIgnore]
    public virtual Varios? TipoRecurso { get; set; }
    [JsonIgnore]
    public virtual Usuario? Usuario { get; set; }
    [JsonIgnore]
    public virtual Varios? EstatusRecurso { get; set; }
}

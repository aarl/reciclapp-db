using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

[Table("rastreo_publicaciones")]
public class RastreoPublicacion : Entidad
{
    [Column("id")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    [Column("id_publicacion")]
    public Guid IdPublicacion { get; set; }
    [Column("id_fase_publicacion")]
    public int IdFasePublicacion { get; set; }
    [Column("fecha")]
    public DateTime Fecha { get; set; } = DateTime.UtcNow;
    [Column("id_usuario")]
    public Guid IdUsuario { get; set; }
    [Column("tiempo_estimado")]
    public long TiempoEstimado { get; set; } = 0;
    [Column("id_fase_anterior")]
    public int IdFaseAnterior { get; set; }
    [Column("id_fase_siguiente")]
    public int IdFaseSiguiente { get; set; }
    [Column("comentarios")]
    [MaxLength(100)]
    public string Comentarios { get; set; } = "";

    [JsonIgnore]
    public virtual Publicacion? Publicacion { get; set; }
    [JsonIgnore]
    public virtual Varios? FasePublicacion { get; set; }
    [JsonIgnore]
    public virtual Usuario? Usuario { get; set; }
    [JsonIgnore]
    public virtual Varios? FaseAnterior { get; set; }
    [JsonIgnore]
    public virtual Varios? FaseSiguiente { get; set; }

}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("publicaciones")]
public class Publicacion
{
    [Column("id")]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("titulo")]
    [MaxLength(200, ErrorMessage = "El título de la publicación no debe exceder los 200 caracteres")]
    public string Titulo { get; set; } = "";
    [Column("descripcion")]
    public string Descripcion { get; set; } = "";
    [Column("fecha")]
    public DateTime Fecha { get; set; } = DateTime.UtcNow;
    [Column("gustan")]
    public int Gustan { get; set; } = 0;
    [Column("no_gustan")]
    public int NoGustan { get; set; } = 0;
    [Column("id_estatus_publicacion")]
    public Guid IdEstatusPublicacion { get; set; }
    [Column("id_tipo_publicacion")]
    public Guid IdTipoPublicacion { get; set; }
    [Column("fase")]
    public int Fase { get; set; } = 0;  // 0 = iniciada, 10 = Subida, 20 = En revision, 30 = Con observaciones, 100 = Aprobada, 200 = Vencida, etc.
    [Column("revisada_por")]
    public Guid IdRevisadoPor { get; set; }
    [Column("imagen_principal")]
    public Guid IdImagenPrincipal { get; set; }
    [Column("tiempo_estimado")]
    public int TiempoEstimado { get; set; } = 0;
    [Column("posicionamiento")]
    public int Posicionamiento { get; set; } = 0;
    [Column("vistas")]
    public int Vistas { get; set; }
    [Column("evaluacion")]
    [Precision(2, 1)]
    public decimal Evaluacion { get; set; } = 0.0M;
    [Column("ultima_direccion_ip")]
    [MaxLength(20)]
    public string UltimaDireccionIP { get; set; } = "";
    [Column("dispositivo")]
    public string Dispositivo { get; set; } = "";
    [Column("direccion")]
    [MaxLength(200)]
    public string Direccion { get; set; } = "";
    [Column("direccion_referencias")]
    [MaxLength(100)]
    public string DireccionReferencias { get; set; } = "";
    [Column("fecha_disponible")]
    public DateTime FechaDisponible { get; set; }
    [Column("total_articulos")]
    [Precision(10, 2)]
    public int TotalArticulos { get; set; } = 0;
    [Column("id_proyecto")]
    public Guid IdProyecto { get; set; }
    [Column("costo_estimado")]
    [Precision(20, 3)]
    public decimal CostoEstimado { get; set; } = 0.0M;
    [Column("costo_estimado_moneda")]
    [MaxLength(3)]
    public string MonedaCostoEstimado { get; set; } = "";
    [Column("costo_estimado_tipo_cambio")]
    [Precision(20, 3)]
    public decimal TipoCambioCostoEstimado { get; set; } = 0.0M;
    [Column("costo_real")]
    [Precision(20, 3)]
    public decimal CostoReal { get; set; } = 0.0M;
    [Column("monto_inversion")]
    [Precision(20, 3)]
    public decimal MontoInversion { get; set; } = 0.0M;
    [Column("costo_real_traslado")]
    [Precision(20, 3)]
    public decimal CostoRealTraslado { get; set; } = 0.0M;
    [Column("moneda_costo_real")]
    [MaxLength(3)]
    public string MonedaCostoReal { get; set; } = "";
    [Column("tipo_cambio_costo_real")]
    [Precision(20, 3)]
    public decimal TipoCambioCostoReal { get; set; } = 0.0M;
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

    [JsonIgnore]
    public virtual Varios? EstatusPublicacion { get; set; }
    [JsonIgnore]
    public virtual Varios? TipoPublicacion { get; set; }
    [JsonIgnore]
    public virtual Usuario? RevisadoPor { get; set; }
    [JsonIgnore]
    public virtual Proyecto? Proyecto { get; set; }
    [JsonIgnore]
    public virtual Usuario? Creador { get; set; }
    [JsonIgnore]
    public virtual Usuario? Modificador { get; set; }
    [JsonIgnore]
    public virtual ICollection<Chat>? Chats { get; set; }
    [JsonIgnore]
    public virtual ICollection<Personal>? UsuariosLink { get; set; }
}

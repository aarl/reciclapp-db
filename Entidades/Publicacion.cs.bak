using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("publicaciones")]
public class Publicacion : Entidad
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
    [Column("consecutivo")]
    public long Consecutivo { get; set; } = 1;       // Tomar de tabla 'secuencias'
    [Column("id_publicador")]
    public Guid IdPublicador { get; set; }
    [Column("gustan")]
    public int Gustan { get; set; } = 0;
    [Column("no_gustan")]
    public int NoGustan { get; set; } = 0;
    [Column("id_estatus_publicacion")]
    public int IdEstatusPublicacion { get; set; }
    [Column("id_fase_publicacion")]
    public int IdFasePublicacion { get; set; }       // 0 = iniciada, 10 = Subida, 20 = En revision, 30 = Con observaciones, 100 = Aprobada, 200 = Vencida, etc.
    [Column("id_tipo_publicacion")]
    public int IdTipoPublicacion { get; set; }
    [Column("id_clase_publicacion")]
    public int IdClasePublicacion { get; set; }
    [Column("revisada_por")]
    public Guid IdRevisadaPor { get; set; }
    [Column("id_imagen_principal")]
    public Guid IdImagenPrincipal { get; set; }
    [Column("tiempo_estimado")]
    public int TiempoEstimado { get; set; } = 0;
    [Column("posicionamiento")]
    public int Posicionamiento { get; set; } = 0;
    [Column("secuencia")]
    public int Secuencia { get; set; }
    [Column("vistas")]
    public int Vistas { get; set; }
    [Column("evaluacion")]
    [Precision(2, 1)]
    public decimal Evaluacion { get; set; } = 0.0M;
    [Column("direccion_ip_creacion")]
    [MaxLength(20)]
    public string DireccionIPCreacion { get; set; } = "";
    [Column("dispositivo")]
    public string Dispositivo { get; set; } = "";
    [Column("direccion")]
    [MaxLength(200)]
    public string Direccion { get; set; } = "";
    [Column("referencias_direccion")]
    [MaxLength(100)]
    public string ReferenciasDireccion { get; set; } = "";
    [Column("fecha_disponible")]
    public DateTime? FechaDisponible { get; set; }
    [Column("total_articulos")]
    [Precision(10, 2)]
    public decimal TotalArticulos { get; set; } = 0;
    [Column("id_proyecto")]
    public Guid IdProyecto { get; set; }
    [Column("costo_estimado")]
    [Precision(20, 3)]
    public decimal CostoEstimado { get; set; } = 0.0M;
    [Column("id_moneda_costo_estimado")]
    [MaxLength(3)]
    public string IdMonedaCostoEstimado { get; set; } = "";
    [Column("tipo_cambio_costo_estimado")]
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
    [Column("id_moneda_costo_real")]
    [MaxLength(3)]
    public string IdMonedaCostoReal { get; set; } = "";
    [Column("tipo_cambio_costo_real")]
    [Precision(20, 3)]
    public decimal TipoCambioCostoReal { get; set; } = 0.0M;

    [JsonIgnore]
    public virtual Usuario? Publicador { get; set; }
    [JsonIgnore]
    public virtual Varios? EstatusPublicacion { get; set; }
    [JsonIgnore]
    public virtual Varios? FasePublicacion { get; set; }
    [JsonIgnore]
    public virtual Varios? TipoPublicacion { get; set; }
    [JsonIgnore]
    public virtual Varios? ClasePublicacion { get; set; }
    [JsonIgnore]
    public virtual Usuario? RevisadaPor { get; set; }
    [JsonIgnore]
    public virtual RecursoPublicacion? ImagenPrincipal { get; set; }
    [JsonIgnore]
    public virtual Proyecto? Proyecto { get; set; }
    [JsonIgnore]
    public virtual Moneda? MonedaCostoEstimado { get; set; }
    [JsonIgnore]
    public virtual Moneda? MonedaCostoReal { get; set; }
    [JsonIgnore]
    public virtual ICollection<Chat>? Chats { get; set; }
    [JsonIgnore]
    public virtual ICollection<Personal>? UsuariosLink { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("actividades_proyectos")]
public class ActividadProyecto
{
    [Column("id")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    [Column("id_proyecto")]
    public Guid IdProyecto { get; set; }
    [Column("id_ruta_proyecto")]
    public int IdRutaProyecto { get; set; }
    [Column("secuencia")]
    public int Secuencia { get; set; } = 1;
    [Column("id_actividad_ruta")]
    public int IdActividadRuta { get; set; }
    [Column("descripcion")]
    public string Descripcion { get; set; } = "";
    [Column("fecha_inicio")]
    public DateTime FechaInicio { get; set; } = DateTime.UtcNow;
    [Column("fecha_finalizacion")]
    public DateTime? FechaFinalizacion { get; set; }
    [Column("id_ejecutor")]
    public Guid IdEjecutor { get; set; }
    [Column("id_revisor")]
    public Guid IdRevisor { get; set; }
    [Column("id_estatus_publicacion")]
    public int IdEstatusPublicacion { get; set; }
    [Column("id_estatus_proyecto")]
    public int IdEstatusProyecto { get; set; }
    [Column("id_revisada_por")]
    public Guid? IdRevisadaPor { get; set; }
    [Column("id_tipo_actividad")]
    public int IdTipoActividad { get; set; }
    [Column("tiempo_estimado")]
    public int TiempoEstimado { get; set; } = 0;
    [Column("progreso_estimado")]
    public int ProgresoEstimado { get; set; } = 0;
    [Column("evaluacion")]
    [Precision(2, 1)]
    public decimal Evaluacion { get; set; } = 0.0M;
    [Column("fecha_disponible")]
    public DateTime? FechaDisponible { get; set; }
    [Precision(10, 2)]
    [Column("total_articulos")]
    public decimal TotalArticulos { get; set; } = 0.0M;
    [Column("costo_estimado")]
    [Precision(20, 3)]
    public decimal CostoEstimado { get; set; } = 0.0M;
    [Column("moneda_costo_estimado")]
    public string MonedaCostoEstimado { get; set; } = "";
    [Column("tipo_cambio_costo_estimado")]
    [Precision(20, 3)]
    public decimal TipoCambioCostoEstimado { get; set; } = 0.0M;
    [Column("costo_real")]
    [Precision(20, 3)]
    public decimal CostoReal { get; set; } = 0.0M;
    [Column("moneda_costo_real")]
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
    public virtual Varios? RutaProyecto { get; set; }
    [JsonIgnore]
    public virtual ActividadRutaProyecto? ActividadRuta { get; set; }
    [JsonIgnore]
    public virtual Varios? EstatusPublicacion { get; set; }
    [JsonIgnore]
    public virtual Varios? EstatusProyecto { get; set; }
    [JsonIgnore]
    public virtual Proyecto? Proyecto { get; set; }
    [JsonIgnore]
    public virtual Usuario? Ejecutor { get; set; }
    [JsonIgnore]
    public virtual Usuario? Revisor { get; set; }
    [JsonIgnore]
    public virtual Usuario? RevisadaPor { get; set; }
    [JsonIgnore]
    public virtual Varios? TipoActividad { get; set; }
    [JsonIgnore]
    public virtual Usuario? Creador { get; set; }
    [JsonIgnore]
    public virtual Usuario? Modificador { get; set; }
}

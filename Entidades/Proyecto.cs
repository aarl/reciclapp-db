using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Entidades;

[Table("proyectos")]
public class Proyecto : Entidad
{
	[Column("id")]
	[Key]
	public Guid Id { get; set; } = Guid.NewGuid();

	[Column("titulo")]
	[MaxLength(450)]
	public string Titulo { get; set; } = "";

	[Column("descripcion")]
	public string Descripcion { get; set; } = "";

	[Column("fecha_inicio")]
	public DateTime FechaInicio { get; set; } = DateTime.UtcNow;

	[Column("id_gerente")]
	public Guid IdGerente { get; set; }

	[Column("id_revisor")]
	public Guid? IdRevisor { get; set; }

	[Column("gustan")]
	public int Gustan { get; set; } = 0;

	[Column("no_gustan")]
	public int NoGustan { get; set; } = 0;

	[Column("id_estatus_publicacion")]
	public int IdEstatusPublicacion { get; set; }

	[Column("id_estatus_proyecto")]
	public int IdEstatusProyecto { get; set; }

	[Column("id_revisada_por")]
	public Guid? IdRevisadaPor { get; set; }

	[Column("id_imagen_principal")]
	public Guid? IdImagenPrincipal { get; set; }

	[Column("id_tipo_proyecto")]
	public int IdTipoProyecto { get; set; }

	[Column("tiempo_estimado")]
	public int TiempoEstimado { get; set; } = 0;

	[Column("progreso_estimado")]
	public int ProgresoEstimado { get; set; } = 0;

	[Column("progreso_real")]
	public int ProgresoReal { get; set; } = 0;

	[Column("evaluacion")]
	[Precision(2, 1)]
	public decimal Evaluacion { get; set; } = 0.0M;

	[Column("id_ruta_proyecto")]
	public int IdRutaProyecto { get; set; }

	[Column("id_fase_anterior")]
	public int? IdFaseAnterior { get; set; }

	[Column("id_fase_siguiente")]
	public int? IdFaseSiguiente { get; set; }

	[Column("fecha_disponible")]
	public DateTime? FechaDisponible { get; set; }

	[Column("total_articulos")]
	[Precision(10, 2)]
	public decimal TotalArticulos { get; set; } = 1M;

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

	[Column("id_moneda_costo_real")]
	[MaxLength(3)]
	public string IdMonedaCostoReal { get; set; } = "";

	[Column("tipo_cambio_costo_real")]
	[Precision(20, 3)]
	public decimal TipoCambioCostoReal { get; set; } = 0.0M;


	[JsonIgnore]
	public virtual Usuario? Gerente { get; set; }

	[JsonIgnore]
	public virtual Usuario? Revisor { get; set; }

	[JsonIgnore]
	public virtual Varios? EstatusPublicacion { get; set; }

	[JsonIgnore]
	public virtual Varios? EstatusProyecto { get; set; }

	[JsonIgnore]
	public virtual Usuario? RevisadaPor { get; set; }

	[JsonIgnore]
	public virtual RecursoPublicacion? ImagenPrincipal { get; set; }

	[JsonIgnore]
	public virtual Varios? TipoProyecto { get; set; }

	[JsonIgnore]
	public virtual Varios? RutaProyecto { get; set; }

	[JsonIgnore]
	public virtual Varios? FaseAnterior { get; set; }

	[JsonIgnore]
	public virtual Varios? FaseSiguiente { get; set; }

	[JsonIgnore]
	public virtual Moneda? MonedaCostoEstimado { get; set; }

	[JsonIgnore]
	public virtual Moneda? MonedaCostoReal { get; set; }
}

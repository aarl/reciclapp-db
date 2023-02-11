using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades;

public class Persona : Entidad
{
    [Column("id")]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("nombre")]
    [MaxLength(100)]
    public string Nombre { get; set; } = "";
    [MaxLength(100)]
    [Column("apellido")]
    public string Apellido { get; set; } = "";
    [Column("telefono")]
    [Phone]
    [MaxLength(20)]
    public string Telefono { get; set; } = "";
    [Column("email")]
    [EmailAddress]
    [MaxLength(300)]
    public string Email { get; set; } = "";
    [Column("clave")]
    [MaxLength(256)]
    public string Clave { get; set; } = "";
}

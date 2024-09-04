using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaSD.Entities.Entities;

public class Usuario
{
	[Key]
	[Column("usuID",TypeName = "numeric(18, 0)")]
	public int? UsuID { get; set; }

	[Column("nombre")]
	[MaxLength(100)]
	public string Nombre { get; set; } = string.Empty;

	[Column("apellido")]
	[MaxLength(100)]
	public string Apellido { get; set; } = string.Empty;
}

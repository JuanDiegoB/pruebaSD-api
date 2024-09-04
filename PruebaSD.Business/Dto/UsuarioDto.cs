using System.ComponentModel.DataAnnotations;

namespace PruebaSD.Business.Dto;

public class UsuarioDto
{
	public int? UsuID { get; set; }

	[MaxLength(100)]
	public string Nombre { get; set; } = string.Empty;

	[MaxLength(100)]
	public string Apellido { get; set; } = string.Empty;
}

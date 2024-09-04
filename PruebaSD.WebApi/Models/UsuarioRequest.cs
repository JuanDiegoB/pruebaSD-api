using System.ComponentModel.DataAnnotations;

namespace PruebaSD.WebApi.Models;

public class UsuarioRequest
{
	/// <summary>
	///		ID del usuario
	/// </summary>
	public int? UsuID { get; set; }

	/// <summary>
	///		Nombre del usuario
	/// </summary>
	[MaxLength(100)]
	public string Nombre { get; set; } = string.Empty;

	/// <summary>
	///  Apellido del usuairo
	/// </summary>
	[MaxLength(100)]
	public string Apellido { get; set; } = string.Empty;
}

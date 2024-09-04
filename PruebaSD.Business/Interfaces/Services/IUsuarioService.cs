using PruebaSD.Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSD.Business.Interfaces.Services;

public interface IUsuarioService
{
	/// <summary>
	///		Crea Usuario
	/// </summary>
	/// <param name="usuarioDto"></param>
	/// <returns></returns>
	Task Create(UsuarioDto usuarioDto);

	/// <summary>
	///		Actualiza Usuario
	/// </summary>
	/// <param name="usuarioDto"></param>
	/// <returns></returns>
	Task Update(int usuID, UsuarioDto usuarioDto);

	/// <summary>
	///		Borra Usuario
	/// </summary>
	/// <returns></returns>
	Task Delete(int usuID);

	/// <summary>
	///		Encuentra usuario por ID
	/// </summary>
	/// <param name="ID"></param>
	/// <returns></returns>
	Task<UsuarioDto> FindById(int usuID);

	/// <summary>
	///		Obtener todos los usuarios
	/// </summary>
	/// <returns></returns>
	Task<IEnumerable<UsuarioDto>> GetAll();
}

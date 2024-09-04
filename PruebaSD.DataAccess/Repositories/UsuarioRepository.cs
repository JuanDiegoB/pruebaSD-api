using Microsoft.EntityFrameworkCore;
using PruebaSD.Business.Dto;
using PruebaSD.Business.Interfaces.Repositories;
using PruebaSD.Entities.Entities;

namespace PruebaSD.DataAccess.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
	readonly DatabaseContext _databaseContext;

	public UsuarioRepository(DatabaseContext databaseContext)
	{
		_databaseContext = databaseContext;
	}

	public async Task Create(Usuario usuario)
	{
		await _databaseContext.AddAsync(usuario);
	}

	public void Update(Usuario usuario)
	{
		_databaseContext.Update(usuario);
	}

	public void Delete(Usuario usuario)
	{
		_databaseContext.Remove(usuario);
	}

	public async Task<Usuario> FindById(int usuID)
	{
		var usuario = await _databaseContext.Usuarios
			.Where(u => u.UsuID.Equals(usuID))
			.SingleOrDefaultAsync();

		if (usuario == null)
		{
			throw new Exception($"Usuario con el ID {usuID} no encontrado.");
		}

		return usuario;
	}

	public async Task<IEnumerable<UsuarioDto>> GetAll()
	{
		return await _databaseContext.Usuarios
			.Select(u => new UsuarioDto
			{
				UsuID = u.UsuID,
				Nombre = u.Nombre,
				Apellido = u.Apellido
			}).ToListAsync();
	}
}

using AutoMapper;
using PruebaSD.Business.Dto;
using PruebaSD.Business.Interfaces.Repositories;
using PruebaSD.Business.Interfaces.Services;
using PruebaSD.Entities.Entities;

namespace PruebaSD.Business;

public class UsuarioService : IUsuarioService
{
	public readonly IMapper _mapper;
	public readonly IUsuarioRepository _usuarioRepository;

	public UsuarioService(IMapper mapper, IUsuarioRepository usuarioRepository)
	{
		_mapper = mapper;
		_usuarioRepository = usuarioRepository;
	}
	
	public async Task Create(UsuarioDto usuarioDto)
	{
		Usuario newUsuario = _mapper.Map(usuarioDto, new Usuario());

		newUsuario.UsuID = null;

		await _usuarioRepository.Create(newUsuario);
	}

	public async Task Update(int usuID, UsuarioDto usuarioDto)
	{
		Usuario usuario = await _usuarioRepository.FindById(usuID);

		usuario.Nombre = usuarioDto.Nombre;
		usuario.Apellido = usuarioDto.Apellido;

		_usuarioRepository.Update(usuario);
	}

	public async Task Delete(int usuID)
	{
		Usuario usuario = await _usuarioRepository.FindById(usuID);

		_usuarioRepository.Delete(usuario);
	}

	public async Task<UsuarioDto> FindById(int usuID)
	{
		Usuario usuario = await _usuarioRepository.FindById(usuID);

		return _mapper.Map<UsuarioDto>(usuario);
	}

	public async Task<IEnumerable<UsuarioDto>> GetAll()
	{
		return await _usuarioRepository.GetAll();
	}
}

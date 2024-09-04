using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaSD.Business.Dto;
using PruebaSD.Business.Interfaces;
using PruebaSD.Business.Interfaces.Services;
using PruebaSD.WebApi.Models;

namespace PruebaSD.WebApi.Controllers;

[Route("api/usuarios")]
[ApiController]
public class UsuarioController : ControllerBase
{
	private readonly IMapper _mapper;
	private readonly IUnitOfWork _unitOfWork;
	private readonly IUsuarioService _usuarioService;

	public UsuarioController(IMapper mapper, IUnitOfWork unitOfWork, IUsuarioService usuarioService)
	{
		_mapper = mapper;
		_unitOfWork = unitOfWork;
		_usuarioService = usuarioService;
	}

	/// <summary>
	///		Creación del usuario
	/// </summary>
	/// <param name="usuarioRequest"></param>
	/// <returns></returns>
	[HttpPost]
	public async Task<IActionResult> Create([FromBody] UsuarioRequest usuarioRequest)
	{
		await using var transaction = await _unitOfWork.BeginTransactionAsync();

		try
		{
			await _usuarioService.Create(_mapper.Map<UsuarioDto>(usuarioRequest));

			await _unitOfWork.SaveChangesAsync();
			await transaction.CommitAsync();

			return Ok();
		}
		catch
		{
			await transaction.RollbackAsync();
			throw;
		}
	}

	/// <summary>
	///		Actualización del usuario según su ID
	/// </summary>
	/// <param name="id"></param>
	/// <param name="usuarioRequest"></param>
	/// <returns></returns>
	[HttpPut]
	[Route("{id:int}")]
	public async Task<IActionResult> Update(int id, [FromBody] UsuarioRequest usuarioRequest)
	{
		await using var transaction = await _unitOfWork.BeginTransactionAsync();

		try
		{
			if (id != usuarioRequest.UsuID)
			{
				return BadRequest();
			}

			await _usuarioService.Update(id, _mapper.Map<UsuarioDto>(usuarioRequest));

			await _unitOfWork.SaveChangesAsync();
			await transaction.CommitAsync();

			return Ok();
		}
		catch
		{
			await transaction.RollbackAsync();
			throw;
		}
	}

	/// <summary>
	///		Borrar usuario según su ID
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	[HttpDelete]
	[Route("{id:int}")]
	public async Task<IActionResult> Delete(int id)
	{
		await using var transaction = await _unitOfWork.BeginTransactionAsync();

		try
		{
			await _usuarioService.Delete(id);

			await _unitOfWork.SaveChangesAsync();
			await transaction.CommitAsync();

			return Ok();
		}
		catch
		{
			await transaction.RollbackAsync();
			throw;
		}
	}

	/// <summary>
	///		Encontrar un usuario por medio de su ID
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	[HttpGet]
	[Route("{id:int}")]
	public async Task<IActionResult> FindById(int id)
	{
		return Ok(await _usuarioService.FindById(id));
	}

	/// <summary>
	///		Encontrar todos los usuarios
	/// </summary>
	/// <returns></returns>
	[HttpGet]
	[Route("")]
	public async Task<IActionResult> GetAll()
	{
		return Ok(await _usuarioService.GetAll());
	}
}

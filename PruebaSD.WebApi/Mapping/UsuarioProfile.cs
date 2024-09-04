using AutoMapper;
using PruebaSD.Business.Dto;
using PruebaSD.Entities.Entities;
using PruebaSD.WebApi.Models;

namespace PruebaSD.WebApi.Mapping
{
	/// <summary>
	///     Mapeo de la entidad Usuario
	/// </summary>
	public class UsuarioProfile : Profile
	{
		public UsuarioProfile()
		{
			CreateMap<UsuarioRequest, UsuarioDto>();
			CreateMap<Usuario, UsuarioDto>();
			CreateMap<UsuarioDto, Usuario>();
		}
	}
}

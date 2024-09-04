using PruebaSD.Business.Dto;
using PruebaSD.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSD.Business.Interfaces.Repositories;

public interface IUsuarioRepository
{
	Task Create(Usuario usuario);
	void Update(Usuario usuario);
	void Delete(Usuario usuario);
	Task<Usuario> FindById(int usuID);
	Task<IEnumerable<UsuarioDto>> GetAll();
}

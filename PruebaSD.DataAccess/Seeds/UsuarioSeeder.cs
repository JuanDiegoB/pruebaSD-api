using Microsoft.EntityFrameworkCore;
using PruebaSD.Entities.Entities;

namespace PruebaSD.DataAccess.Seeds;

public static class UsuarioSeeder
{
	public static void SeedData(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Usuario>().HasData(
			new Usuario { UsuID = 1, Nombre = "Juan", Apellido = "Pérez" },
			new Usuario { UsuID = 2, Nombre = "Ana", Apellido = "Gómez" },
			new Usuario { UsuID = 3, Nombre = "Carlos", Apellido = "Martínes" },
			new Usuario { UsuID = 4, Nombre = "María", Apellido = "Lopez" },
			new Usuario { UsuID = 5, Nombre = "Isabel", Apellido = "Marin" }
		);
	}
}

using Microsoft.EntityFrameworkCore;
using PruebaSD.DataAccess.Configurations;
using PruebaSD.DataAccess.Seeds;
using PruebaSD.Entities.Entities;

namespace PruebaSD.DataAccess;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
	public DbSet<Usuario> Usuarios { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		ArgumentNullException.ThrowIfNull(modelBuilder);

		base.OnModelCreating(modelBuilder);
		modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

		SeedData(modelBuilder);
	}

	private static void SeedData(ModelBuilder modelBuilder)
	{
		UsuarioSeeder.SeedData(modelBuilder);
	}
}

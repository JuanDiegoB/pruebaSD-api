using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaSD.Entities.Entities;

namespace PruebaSD.DataAccess.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
	public void Configure(EntityTypeBuilder<Usuario> builder)
	{
		builder.HasKey(u => u.UsuID);
		builder.Property(u => u.Nombre).IsRequired(false);
		builder.Property(u => u.Apellido).IsRequired(false);
	}
}

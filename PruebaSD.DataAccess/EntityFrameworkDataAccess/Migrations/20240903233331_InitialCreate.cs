using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaSD.DataAccess.EntityFrameworkDataAccess.Migrations
{
	/// <inheritdoc />
	public partial class InitialCreate : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Usuarios",
				columns: table => new
				{
					usuID = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Usuarios", x => x.usuID);
				});

			migrationBuilder.InsertData(
				table: "Usuarios",
				columns: new[] { "usuID", "apellido", "nombre" },
				values: new object[,]
				{
					{ 1m, "Pérez", "Juan" },
					{ 2m, "Gómez", "Ana" },
					{ 3m, "Martínes", "Carlos" },
					{ 4m, "Lopez", "María" },
					{ 5m, "Marin", "Isabel" }
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Usuarios");
		}
	}
}

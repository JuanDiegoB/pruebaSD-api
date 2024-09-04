# Prueba SD
Hola, Esta es mi prueba tecnica .Net. A continuación dejo las aplicaciones necesarias y utilizadas para el desarrollo de la misma cualquier cosa, estoy atento a cualquier inquietud, duda o sugerencia. Muchas gracias por la oportunidad y con animos de dar lo mejor de mi para esta compañia.

## Instalación

PruebaSD-api requiere [Visual Studio 2022](https://visualstudio.microsoft.com/es/vs/), [SQL Server 2019](https://www.microsoft.com/es-es/sql-server/sql-server-downloads) y [.Net Core 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) para ejecutarse.

Abrir la solucion con [Visual Studio 2022](https://visualstudio.microsoft.com/es/vs/)

Configure la conexión con su servidor de base de datos local en el archivo appsettings.json [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
```sh
{
	"ConnectionStrings": {
		"DefaultConnection": "server={{ SERVIDOR }}; database=PruebaSD; Integrated Security=True;"
  }
}
```

## Migraciones

Para crear el modelo de datos por primera vez realice lo siguiente: 
usando los comandos dotnet, en el proyecto dirijase al directorio `PruebaSD.DataAccess` desde el explorador de archivos, desde allí ejecute una consola de comandos con lo siguiente:

```sh
dotnet ef migrations add InitialMigration -s ../PruebaSD.WebApi/ -o "EntityFrameworkDataAccess/Migrations"
```

Para actualizar la base de datos con las migraciones use:

Comando dotnet
```sh
dotnet ef database update --project ..\PruebaSD.DataAccess --startup-project ..\PruebaSD.WebApi
```

Verifique que la base de datos este creada y las Migraciones esten hechas, a continuación puede ejecutar la proyecto WebApi y se lanzara el swagger con los endpoints utilizados para este proyecto

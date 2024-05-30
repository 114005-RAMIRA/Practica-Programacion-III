using DependencyInjection.Context; // Importa el espacio de nombres que contiene el contexto de base de datos.
using DependencyInjection.Repositories; // Importa el espacio de nombres que contiene los repositorios.
using Microsoft.EntityFrameworkCore; // Importa el espacio de nombres para usar Entity Framework Core.

var builder = WebApplication.CreateBuilder(args); // Crea un nuevo objeto WebApplicationBuilder con los argumentos de línea de comandos.

// Añadir servicios al contenedor.

builder.Services.AddControllers(); // Agrega los servicios de los controladores al contenedor de dependencias.
// Aprende más sobre cómo configurar Swagger/OpenAPI en https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); // Agrega servicios para explorar los endpoints de la API.
builder.Services.AddSwaggerGen(); // Agrega servicios para generar la documentación de Swagger.

// Las siguientes líneas configuran la inyección de dependencias para los repositorios.
//builder.Services.AddSingleton<ICountryRepository, InMemoryRepository>(); // Descomentar para una única instancia a lo largo de la aplicación.
//builder.Services.AddScoped<ICountryRepository, FileCountryRepository>(); // Descomentar para una instancia por cada alcance (por ejemplo, una instancia por cada solicitud en un controlador).
builder.Services.AddTransient<ICountryRepository, DbCountryRepository>(); // Agrega el repositorio DbCountryRepository con una nueva instancia cada vez que se solicita.

builder.Services.AddDbContext<CountryDbContext>((context) => // Configura el contexto de base de datos.
{
    context.UseSqlServer(builder.Configuration.GetConnectionString("CountryDb")); // Configura el contexto para usar SQL Server con la cadena de conexión especificada.
});

var app = builder.Build(); // Construye la aplicación.

// Configuración del pipeline de manejo de solicitudes HTTP.
if (app.Environment.IsDevelopment()) // Si el entorno es de desarrollo,
{
    app.UseSwagger(); // Habilita Swagger para generar la documentación de la API.
    app.UseSwaggerUI(); // Habilita la interfaz de usuario de Swagger.
}

app.UseHttpsRedirection(); // Fuerza el uso de HTTPS en las solicitudes.

app.UseAuthorization(); // Habilita la autorización en la aplicación.

app.MapControllers(); // Mapea los endpoints de los controladores.

app.Run(); // Ejecuta la aplicación.

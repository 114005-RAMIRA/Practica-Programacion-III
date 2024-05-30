using DependencyInjection.Repositories; // Importa el espacio de nombres que contiene las interfaces y clases de los repositorios.
using Microsoft.AspNetCore.Http; // Importa el espacio de nombres para manejar solicitudes HTTP.
using Microsoft.AspNetCore.Mvc; // Importa el espacio de nombres para usar las funcionalidades de MVC.

namespace DependencyInjection.Controllers // Define el espacio de nombres para los controladores.
{
    [Route("api/[controller]")] // Especifica la ruta base para este controlador. [controller] se reemplaza con el nombre del controlador sin "Controller".
    [ApiController] // Indica que esta clase es un controlador de API.
    public class CountryController : ControllerBase // Define la clase 'CountryController' que hereda de 'ControllerBase'.
    {
        private readonly ICountryRepository _countryRepository; // Campo privado solo de lectura para el repositorio de países.

        public CountryController(ICountryRepository countryRepository) // Constructor que recibe una instancia de ICountryRepository a través de la inyección de dependencias.
        {
            _countryRepository = countryRepository; // Inicializa el campo _countryRepository con la instancia proporcionada.
        }

        [HttpGet] // Indica que este método maneja solicitudes GET.
        public IActionResult Get() // Método que maneja solicitudes GET en "api/country".
        {
            //var countryRepository = new InMemoryRepository(); // Esto crea una nueva instancia del repositorio en memoria, no usando inyección de dependencias.
            // Corrección: Usar el repositorio inyectado en lugar de crear una nueva instancia.
            var countries = _countryRepository.GetAll(); // Usa el repositorio inyectado para obtener todos los países.

            return Ok(countries); // Retorna una respuesta HTTP 200 OK con la lista de países.
        }

        [HttpGet("v2")] // Indica que este método maneja solicitudes GET en "api/country/v2".
        public IActionResult GetV2() // Método que maneja solicitudes GET en "api/country/v2".
        {
            var countries = _countryRepository.GetAll(); // Usa el repositorio inyectado para obtener todos los países.

            return Ok(countries); // Retorna una respuesta HTTP 200 OK con la lista de países.
        }
    }
}

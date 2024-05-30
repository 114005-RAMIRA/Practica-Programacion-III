using DependencyInjection.Domain; // Importa el espacio de nombres que contiene las clases del dominio.
using Microsoft.AspNetCore.Hosting; // Importa el espacio de nombres para el entorno de hospedaje web.
using Newtonsoft.Json; // Importa la biblioteca Newtonsoft.Json para la serialización y deserialización de JSON.

namespace DependencyInjection.Repositories // Define el espacio de nombres para los repositorios.
{
    public class FileCountryRepository : ICountryRepository // Define la clase 'FileCountryRepository' que implementa la interfaz 'ICountryRepository'.
    {
        private readonly IWebHostEnvironment _webHostEnvironment; // Campo privado solo de lectura que contiene el entorno de hospedaje web.

        public FileCountryRepository(IWebHostEnvironment webHostEnvironment) // Constructor que recibe una instancia de 'IWebHostEnvironment' como parámetro.
        {
            _webHostEnvironment = webHostEnvironment; // Asigna el entorno de hospedaje web al campo privado '_webHostEnvironment'.
        }

        public List<Country> GetAll() // Método que devuelve una lista de todos los países.
        {
            var basePath = _webHostEnvironment.ContentRootPath; // Obtiene la ruta raíz del contenido del entorno de hospedaje web.

            var filePath = Path.Combine(basePath, "countries.json"); // Combina la ruta base con el nombre del archivo para obtener la ruta completa del archivo 'countries.json'.

            var countriesAsString = System.IO.File.ReadAllText(filePath); // Lee todo el contenido del archivo 'countries.json' como una cadena.

            var countries = JsonConvert.DeserializeObject<List<Country>>(countriesAsString); // Deserializa la cadena JSON en una lista de objetos 'Country'.

            return countries; // Retorna la lista de países.
        }
    }
}

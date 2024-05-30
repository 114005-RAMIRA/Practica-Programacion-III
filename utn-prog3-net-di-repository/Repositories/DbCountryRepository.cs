using DependencyInjection.Context; // Importa el espacio de nombres que contiene el contexto de la base de datos.
using DependencyInjection.Domain; // Importa el espacio de nombres que contiene las clases del dominio.
using Microsoft.EntityFrameworkCore; // Importa el espacio de nombres para Entity Framework Core.

namespace DependencyInjection.Repositories // Define el espacio de nombres para los repositorios.
{
    public class DbCountryRepository : ICountryRepository // Define la clase 'DbCountryRepository' que implementa la interfaz 'ICountryRepository'.
    {
        private readonly CountryDbContext _context; // Campo privado solo de lectura que contiene el contexto de la base de datos.

        public DbCountryRepository(CountryDbContext context) // Constructor que recibe una instancia de 'CountryDbContext' como parámetro.
        {
            _context = context; // Asigna el contexto de la base de datos al campo privado '_context'.
        }

        public List<Country> GetAll() // Método que devuelve una lista de todos los países.
        {
            return _context.Countries.ToList(); // Retorna la lista de países desde la tabla 'Countries' en la base de datos.
        }
    }
}

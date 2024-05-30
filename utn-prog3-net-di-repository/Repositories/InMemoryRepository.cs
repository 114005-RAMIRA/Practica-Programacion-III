using DependencyInjection.Domain; // Importa el espacio de nombres que contiene las clases del dominio.

namespace DependencyInjection.Repositories // Define el espacio de nombres para los repositorios.
{
    public class InMemoryRepository : ICountryRepository // Declara la clase 'InMemoryRepository' que implementa la interfaz 'ICountryRepository'.
    {
        private static List<Country> countries = new List<Country> // Campo estático que contiene una lista de objetos 'Country'.
        {
            new Country { Id = "1", Name = "Argentina" },
            new Country { Id = "2", Name = "Francia" },
            new Country { Id = "3", Name = "Brasil" },
        };

        public List<Country> GetAll() // Implementa el método 'GetAll' de la interfaz 'ICountryRepository'.
        {
            return countries; // Retorna la lista de países.
        }
    }
}

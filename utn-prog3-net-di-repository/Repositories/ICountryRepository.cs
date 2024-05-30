using DependencyInjection.Domain; // Importa el espacio de nombres que contiene las clases del dominio.

namespace DependencyInjection.Repositories // Define el espacio de nombres para los repositorios.
{
    public interface ICountryRepository // Declara la interfaz 'ICountryRepository'.
    {
        List<Country> GetAll(); // Declara el método 'GetAll' que devuelve una lista de objetos 'Country'.
    }
}

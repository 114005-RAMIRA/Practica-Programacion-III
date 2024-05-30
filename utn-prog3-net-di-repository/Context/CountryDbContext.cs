using DependencyInjection.Domain; // Importa el espacio de nombres que contiene las entidades del dominio, como 'Country'.
using Microsoft.EntityFrameworkCore; // Importa el espacio de nombres para usar Entity Framework Core.

namespace DependencyInjection.Context // Define el espacio de nombres para el contexto de la base de datos.
{
    public class CountryDbContext : DbContext // Define la clase 'CountryDbContext' que hereda de 'DbContext'.
    {
        public CountryDbContext(DbContextOptions dbContextOptions)
               : base(dbContextOptions) // Llama al constructor de la clase base 'DbContext' con las opciones proporcionadas.
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Método sobrescrito para configurar el modelo de la base de datos.
        {
            base.OnModelCreating(modelBuilder); // Llama al método de la clase base para cualquier configuración adicional.

            // Configura la entidad 'Country' y agrega datos iniciales.
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = "1", Name = "Argentina" },
                new Country { Id = "2", Name = "Francia" },
                new Country { Id = "3", Name = "Brasil" },
                new Country { Id = "4", Name = "Chile" },
                new Country { Id = "5", Name = "Paraguay" }
            );
        }

        public DbSet<Country> Countries { get; set; } // Define una propiedad DbSet para la entidad 'Country', lo que permite realizar operaciones CRUD en la tabla 'Countries'.
    }
}

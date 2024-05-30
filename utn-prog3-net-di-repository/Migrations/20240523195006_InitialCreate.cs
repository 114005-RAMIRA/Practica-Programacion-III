using Microsoft.EntityFrameworkCore.Migrations; // Importa el espacio de nombres necesario para trabajar con migraciones.

#nullable disable // Deshabilita la anotación de nulabilidad para compatibilidad con código antiguo o específico.

namespace DependencyInjection.Migrations // Define el espacio de nombres para las migraciones.
{
    public partial class InitialCreate : Migration // Define una clase parcial 'InitialCreate' que hereda de 'Migration'.
    {
        protected override void Up(MigrationBuilder migrationBuilder) // Método 'Up' se usa para definir las operaciones que deben aplicarse a la base de datos cuando se aplica la migración.
        {
            migrationBuilder.CreateTable( // Crea una nueva tabla en la base de datos.
                name: "Countries", // Nombre de la tabla.
                columns: table => new // Define las columnas de la tabla.
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false), // Columna 'Id' de tipo 'string' con un tamaño máximo de 450 caracteres y no permite valores nulos.
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false) // Columna 'Name' de tipo 'string' con un tamaño máximo ilimitado y no permite valores nulos.
                },
                constraints: table => // Define las restricciones de la tabla.
                {
                    table.PrimaryKey("PK_Countries", x => x.Id); // Define la clave primaria de la tabla en la columna 'Id'.
                });

            migrationBuilder.InsertData( // Inserta datos iniciales en la tabla.
                table: "Countries", // Nombre de la tabla.
                columns: new[] { "Id", "Name" }, // Columnas en las que se insertarán los datos.
                values: new object[,] // Valores a insertar.
                {
                    { "1", "Argentina" }, // Inserta un país con Id "1" y Name "Argentina".
                    { "2", "Francia" }, // Inserta un país con Id "2" y Name "Francia".
                    { "3", "Brasil" }, // Inserta un país con Id "3" y Name "Brasil".
                    { "4", "Chile" }, // Inserta un país con Id "4" y Name "Chile".
                    { "5", "Paraguay" } // Inserta un país con Id "5" y Name "Paraguay".
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) // Método 'Down' se usa para definir las operaciones que deben revertirse cuando se elimina la migración.
        {
            migrationBuilder.DropTable( // Elimina la tabla de la base de datos.
                name: "Countries"); // Nombre de la tabla a eliminar.
        }
    }
}

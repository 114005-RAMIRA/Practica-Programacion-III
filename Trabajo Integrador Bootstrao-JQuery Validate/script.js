// Función para cargar las provincias según el país seleccionado
function cargarProvincias() {
   
    var pais = document.getElementById("pais").value; // Corregir el ID
    
    var provinciaSelect = document.getElementById("provincia");

    // Limpiar todas las opciones actuales del selector de provincias
    provinciaSelect.innerHTML = "";

    // Array para almacenar las provincias según el país seleccionado
    var provincias = [];

    // Asignar las provincias dependiendo del país seleccionado
    if (pais === "argentina") {
        provincias = ["Buenos Aires", "Córdoba", "Santa Fe"];
    } else if (pais === "brasil") {
        provincias = ["São Paulo", "Rio de Janeiro", "Minas Gerais"];
    } else if (pais === "mexico") {
        provincias = ["Ciudad de México", "Jalisco", "Nuevo León"];
    }

    // Añadir las opciones de provincias al selector basado en el país seleccionado
    provincias.forEach(function(provincia) {
        // Crear un nuevo elemento <option> para cada provincia
        var option = document.createElement("option");
        // Establecer el texto del elemento como el nombre de la provincia
        option.text = provincia;
        // Establecer el valor del elemento a la versión en minúscula del nombre de la provincia
        option.value = provincia.toLowerCase();
        // Agregar el nuevo elemento <option> al selector de provincias
        provinciaSelect.appendChild(option);
    });
}

// Ejecutar código cuando el DOM está listo usando jQuery
$(document).ready(function() {
    
    $("#formulario").validate({
        // Definición de las reglas de validación para el formulario
        rules: {
            nombre: {
                required: true,
                maxlength: 100
            },
            apellido: {
                required: true, 
                maxlength: 100,
                minlength: 2 
            },
            nivel: {
                required: true 
            },
            pais: {
                required: true 
            },
            provincia: {
                required: true 
            }
        },
       
        messages: {
            nombre: {
                required: "El Nombre es requerido",
                maxlength: "El máximo largo es 100 caracteres" 
            },
            apellido: {
                required: "El Apellido es requerido", 
                maxlength: "El máximo largo es 100 caracteres", 
                minlength: "El mínimo largo es 2 caracteres" 
            },
            nivel: {
                required: "El Nivel es requerido" 
            },
            pais: {
                required: "El País es requerido" 
            },
            provincia: {
                required: "La Provincia es requerida" 
            }
        },
        // Función para manejar el envío del formulario si es válido
        submitHandler: function(form) {
           
            alert("Formulario válido");
            
            // Guardar datos en localStorage para uso posterior
            localStorage.setItem("nombre", $("#nombre").val());
            localStorage.setItem("apellido", $("#apellido").val());
            localStorage.setItem("nivel", $("input[name='nivel']:checked").val()); // Obtener el valor del radio seleccionado
            localStorage.setItem("pais", $("#pais").val()); // Guardar el país seleccionado
            localStorage.setItem("provincia", $("#provincia").val()); // Guardar la provincia seleccionada

            // Redirigir al usuario a otra página después de un envío exitoso
            window.location.href = "Card.html"; // Navegar a la página "Card.html"
        }
    });
});

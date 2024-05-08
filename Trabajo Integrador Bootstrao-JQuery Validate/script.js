function cargarProvincias() {
    var pais = document.getElementById("pais").value; // Corregir el ID
    var provinciaSelect = document.getElementById("provincia");

    // Limpiar las opciones actuales
    provinciaSelect.innerHTML = "";

    var provincias = [];

    // Asignar provincias según el país seleccionado
    if (pais === "argentina") {
        provincias = ["Buenos Aires", "Córdoba", "Santa Fe"];
    } else if (pais === "brasil") {
        provincias = ["São Paulo", "Rio de Janeiro", "Minas Gerais"];
    } else if (pais === "mexico") {
        provincias = ["Ciudad de México", "Jalisco", "Nuevo León"];
    }

    // Agregar nuevas opciones basadas en el país seleccionado
    provincias.forEach(function(provincia) {
        var option = document.createElement("option");
        option.text = provincia;
        option.value = provincia.toLowerCase(); // Puede ser útil para el envío de datos
        provinciaSelect.appendChild(option);
    });
}

$(document).ready(function() {
    $("#formulario").validate({
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
        submitHandler: function(form) {
            // Mensaje indicando que el formulario es válido
            alert("Formulario válido");

            // Guardar datos en localStorage
            localStorage.setItem("nombre", $("#nombre").val());
            localStorage.setItem("apellido", $("#apellido").val());
            localStorage.setItem("nivel", $("input[name='nivel']:checked").val()); // Obtener el radio seleccionado
            localStorage.setItem("pais", $("#pais").val()); // Correcto ID
            localStorage.setItem("provincia", $("#provincia").val()); // Correcto ID

            // Redirección a la página de destino
            window.location.href = "Card.html"; // Nombre correcto de la página de destino
        }
    });
});





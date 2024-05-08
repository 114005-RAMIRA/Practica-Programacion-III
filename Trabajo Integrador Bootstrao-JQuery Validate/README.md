[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/h7Bt-iEt)
# utn-prog3-js-jquery-practice

## Enunciado 

Elaborar un formulario el cual debe verificar que los datos sean válidos y de ser asi enviar dicha información a otro documento que la mostrará en un card centrado en la pantalla. Debe estar centrado y utilizar los estilos del framework de bootstrap. El nombre y apellido deben ocupar seis columnas cada uno. El nivel educativo debe ocupar doce columnas. Por ultimo el pais y la provincia deben ocupar la mitad cada uno (seis columnas). Y las observaciones el total de las columnas (doce).

### Datos:
* Nombre (requerido, max 100)
* Apellido (requerido, max 100, min 2)
* Nivel Educativo (requerido)
  * valores: primario, secundario, terciario, universitario
  * radio
* Pais (requerido)
  * combo
* Provincia (requerido)
  * combo (debe ser cargado en base a lo seleccionado en el pais: evento onChange)
* Observaciones (opcional)
  * textarea (4 filas)

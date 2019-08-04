$(document).ready(function () {
    /*Te deajaré un ejemplillo para que te guies :p
     Has de cuenta que tienes una etiqueta con un id
     <p id="idejemplo">Etiqueta con ID</p>
     Entonces el texto lo queremos cambiar de color con jquery, para eso lo mandamos a referenciar de la siguiente
     forma. Y para el color usanos la clase .css
     $('#idejemplo').css("color", "red");

     Ahora bien si esto fuera por medio de una clase entonces estaría de la siguiente forma.
     <p class="ejemplo">Etiqueta con classe</p>
     Entonces para cambiarle el color hacemos referencia a la clase de la siguiente forma
     $('.ejemplo').css("color", "red");

     MUCHO OJO: Si es por id recuerda que solo puede haber 1 solo. En caso de que sea una clase entonces pueden ser de 1 a n.

     Por ejemplo, si tuviera muchas clases 
     <p class="ejemplo">Una clase</p>
     <p class="ejemplo">otra clase</p>
     <p class="ejemplo">y otra</p>

     Por medio de una clase .each de jquery buscamos todas las etiquetas con la clase ejemplo e imprimos en consola su texto
     $.each('.ejemplo', function(index, value){
        console.log(value.value);
     });
     
     O bien agregarle un evento a todos los que tiene esa clase (si tiene un id no funciona ya que se supone que un id es unico y no puede haber varios)
     $('.ejemplo').click(function(){
        alert("Click");
     });
     
     */
});
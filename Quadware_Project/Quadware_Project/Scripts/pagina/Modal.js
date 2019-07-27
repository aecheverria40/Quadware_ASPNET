$(document).ready(function () {
    $('#enviar').click(function () {
        var contacto = {
            correo: $('#inputEmail').val(),
            mensaje: $('#textArea').val()
        };
    });
});

function EnviarCorreo(contacto) {
    $.ajax({
        url: "ContactarEmail",
        type: "POST",
        content: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(data),
        success: function (data) {
            if (data.response == "Ok") {
                console.log("Todo bien");
            }
            else {
                alert(data.response);
            }
        }
    });
}
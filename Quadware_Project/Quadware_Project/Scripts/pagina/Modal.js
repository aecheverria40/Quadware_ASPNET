$(document).ready(function () {
    $('#openmodal').click(function () {
        $('#contactoModal').modal('toggle');
    });
    $('#enviar').click(function () {
        var frm = new FormData();
        frm.append("correo", $('#inputEmail').val());
        frm.append("mensaje", $('#textArea').val());
        EnviarCorreo(frm);
    });

});

function EnviarCorreo(contacto) {
    $.ajax({
        url: "/Home/ContactarEmail",
        processData: false,
        contentType: false,
        type: "POST",
        dataType: "json",
        data: contacto,
        success: function (data) {
            if (data == "Ok") {
                console.log("Todo bien");
            }
            else {
                alert(data);
            }
        },
        error: function () {
            alert("Algo mal en el ajax");
        }
    });
}
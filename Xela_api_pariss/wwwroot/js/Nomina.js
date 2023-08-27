'use strict'

var getUrl = window.location;
var baseUrl = getUrl.protocol + "//" + getUrl.host + "/";


$(document).on('click', '#example .btntraeinfNomina', function () {
    var Id = $(this).parent().parent().parent().children('td:eq(0)').text();
    var pa = {'Id': Id };
    var par = JSON.stringify(pa);
    var t = $("input[name='__RequestVerificationToken']").val();
    $.ajax({
        headers: {
            "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
        },
        type: "POST",
        url: baseUrl + "Nomina/ParametroIndivial",
        data: par,
        processData: false,
        contentType: false,
        success: function (data, textStatus, jqXHR) {
            if (data === 'sininformacion') {
                Swal.fire({
                    position: 'top-end',
                    icon: 'info',
                    title: 'No se encuentra información',
                    showConfirmButton: false,
                    timer: 2500
                });
            } else {
                $('#datos1').html(
                    '<p>' + data.tipo_de_documento + '<br>' + data.numero_identificacion + '<br>' + data.nombre + '<br>' + data.apellido + '</p>'
                );
                $('#datos2').html(
                    '<p>' + data.correo_electronico + '<br>' + data.telefono + '<br> ' + data.sede + '  <br>' + data.direccion + '<br>' + data.sedeSecundaria + '</p>'
                );
                $('#datos3').html(
                    '<p>' + data.estado + '<br>' + data.cargo + '<br>$ ' + data.valorSueldo + '</p>'
                );
                $('#datos4').html(
                    '<p>Informacion_completa : ' + data.informacion_completa + '<br>Liquidado : ' + data.liquidado + '<br>Observacion : ' + data.observaciones + '</p>' 
                );
            //    ModelNMomina1(data);
            }
            // Eliminar la variable del localStorage
            localStorage.removeItem('miVariable_');
            // Guardar información en localStorage
            localStorage.setItem('miVariable_', JSON.stringify(data));
            // Obtener información de localStorage
            var data_ = localStorage.getItem('miVariable_');
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status, errorThrown);
            Swal.fire({
                position: 'top-end',
                icon: 'error',
                title: 'Tiempo de Respuesta insuficiente...Por favor Vuelva a generar la consulta',
                showConfirmButton: false,
                timer: 3000
            });
        }
    });
})




$(document).on('click', '.btnregistrarUpdateNom', function () {
    var t = $("input[name='__RequestVerificationToken']").val();
    var Nombre = document.getElementById('Nombre_').value;
    var Apellido = document.getElementById('Apellido_').value;
    var Tipo_de_documento = document.getElementById('Tipo_de_documento_').value;
    var Numero_identificacion = document.getElementById('Numero_identificacion_').value;
    var Correo_electronico = document.getElementById('Correo_electronico_').value;
    var Telefono = document.getElementById('Telefono_').value;
    var Sede = document.getElementById('Sede_').value;
    var Direccion = document.getElementById('Direccion_').value;
    var Estado = document.getElementById('Estado_').value;
    var Cargo = document.getElementById('Cargo_').value;
    var ValorSueldo = document.getElementById('ValorSueldo_').value;
    var Liquidado = document.getElementById('Liquidado_').value;
    var Id = document.getElementById('Id_').value;
    var Informacion_completa = document.getElementById('Informacion_completa_').value;
    var SedeSecundaria = document.getElementById('SedeSecundaria_').value;
    var Observaciones = document.getElementById('Observaciones_').value;
    var dat = {'SedeSecundaria': SedeSecundaria,'Observaciones' :Observaciones,'Id': Id, 'Nombre': Nombre, 'Apellido': Apellido, 'Tipo_de_documento': Tipo_de_documento, 'Numero_identificacion': Numero_identificacion, 'Correo_electronico': Correo_electronico, 'Telefono': Telefono, 'Sede': Sede, 'Direccion': Direccion, 'Estado': Estado, 'Cargo': Cargo, 'ValorSueldo': ValorSueldo, 'Liquidado': Liquidado, 'Informacion_completa': Informacion_completa };
    var Param = JSON.stringify(dat);
    // alert(Param);
    $.ajax({
        headers: {
            "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
        },
        type: "POST",
        url: baseUrl + "Nomina/Updateusuarionew",
        data: Param,
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            if (data == 'Registroactualizadocorrectamente') {
                Swal.fire({
                    position: 'top-end',
                    icon: 'success',
                    title: 'Registro actualizado correctamente !!!',
                    showConfirmButton: false,
                    timer: 2500
                });
                limpiarFormulario();
                location.reload();
            } else {
                Swal.fire({
                    position: 'top-end',
                    icon: 'warning',
                    title: 'Datos no validos..',
                    showConfirmButton: false,
                    timer: 2500
                })
            }

        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status + errorThrown);
        }
    })
});

function limpiarFormulario() {
    var formulario = document.getElementById("formudate");
    formulario.reset();
}
function limpiarFormularioforminsert() {
    var formulario = document.getElementById("forminsert");
    formulario.reset();
}



$(document).on('click', '.btnregistrarNuevNom', function () {
    var t = $("input[name='__RequestVerificationToken']").val();
    var Nombre = document.getElementById('Nombre').value;
    var Apellido = document.getElementById('Apellido').value;
    var Tipo_de_documento = document.getElementById('Tipo_de_documento').value;
    var Numero_identificacion = document.getElementById('Numero_identificacion').value;
    var Correo_electronico = document.getElementById('Correo_electronico').value;
    var Telefono = document.getElementById('Telefono').value;
    var Sede = document.getElementById('Sede').value;
    var Direccion = document.getElementById('Direccion').value;
    var Estado = document.getElementById('Estado').value;
    var Cargo = document.getElementById('Cargo').value;
    var ValorSueldo = document.getElementById('ValorSueldo').value;
    var Liquidado = document.getElementById('Liquidado').value;
    var Informacion_completa = document.getElementById('Informacion_completa').value;
    var SedeSecundaria = document.getElementById('SedeSecundaria').value;
    var Observaciones = document.getElementById('Observaciones').value;
    var dat = {'Observaciones':Observaciones,'SedeSecundaria' :SedeSecundaria,'Nombre': Nombre, 'Apellido': Apellido, 'Tipo_de_documento': Tipo_de_documento, 'Numero_identificacion': Numero_identificacion, 'Correo_electronico': Correo_electronico, 'Telefono': Telefono, 'Sede': Sede, 'Direccion': Direccion, 'Estado': Estado, 'Cargo': Cargo, 'ValorSueldo': ValorSueldo, 'Liquidado': Liquidado, 'Informacion_completa': Informacion_completa };
    var Param = JSON.stringify(dat);
   // alert(Param);
        $.ajax({
            headers: {
                "RequestVerificationToken": t,
                'Accept': 'application/json',
                'Content-Type': 'application/json; charset=utf-8'
            },
            type: "POST",
            url: baseUrl + "Nomina/Insertusuarionew",
            data: Param,
            dataType: "json",
            success: function (data, textStatus, jqXHR) {
                if (data == 'Noregistrado') {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'info',
                        title: 'No fue posible crear el usuario...Valide los campos..',
                        showConfirmButton: false,
                        timer: 2500
                    })
                } else {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Creado Correctamente..',
                        showConfirmButton: false,
                        timer: 2500
                    });
                    limpiarFormularioforminsert();
                }

            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(jqXHR.status + errorThrown);
            }
        })
    });

$(document).on('click', '.bi-pencil-square', function () {

    var data_ = localStorage.getItem('miVariable_'); // Obtiene la cadena de texto del localStorage
    var dataObj = JSON.parse(data_);

    $('#Nombre_').val(dataObj.nombre);
    $('#Apellido_').val(dataObj.apellido);
    $('#Tipo_de_documento_').val(dataObj.tipo_de_documento);
    $('#Numero_identificacion_').val(dataObj.numero_identificacion);
    $('#Correo_electronico_').val(dataObj.correo_electronico);
    $('#Telefono_').val(dataObj.telefono);
    $('#Sede_').val(dataObj.sede);
    $('#Direccion_').val(dataObj.direccion);
    $('#Estado_').val(dataObj.estado);
    $('#Cargo_').val(dataObj.cargo);
    $('#ValorSueldo_').val(dataObj.valorSueldo);
    $('#Liquidado_').val(dataObj.liquidado);
    $('#Informacion_completa_').val(dataObj.informacion_completa);
    $('#Id_').val(dataObj.id);
    $('#SedeSecundaria_').val(dataObj.sedeSecundaria);
    $('#Observaciones_').val(dataObj.observaciones);
})




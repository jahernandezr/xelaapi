'use strict'

var getUrl = window.location;
var baseUrl = getUrl.protocol + "//" + getUrl.host + "/";


$(document).ready(function () {
    $.ajax({
        headers: {
          //  "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
        },
        type: "GET",
        url: baseUrl + "Correspondencia/GetSolicitudes",
        //data : JSON.stringify({"IdPreradicado": IdPreradicado }),
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            Selectobservaciones(data);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status + errorThrown);
        }
    })
});

$(document).on('click', '#aSolicitudes', function () {
    $('#divsasolicitud').show();
    $('#divsalidresponsable').hide();
    $('#divsalidreportes').hide();
});
$(document).on('click', '#aResponsables', function () {
    $('#divsasolicitud').hide();
    $('#divsalidresponsable').show();
    $('#divsalidreportes').hide();
    $.ajax({
        headers: {
            //  "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
        },
        type: "GET",
        url: baseUrl + "Correspondencia/GetResponsables",
        //data : JSON.stringify({"IdPreradicado": IdPreradicado }),
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            Selectobservaciones2(data);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status + errorThrown);
        }
    })


});
$(document).on('click', '#aReportes', function () {
    $('#divsasolicitud').hide();
    $('#divsalidresponsable').hide();
    $('#divsalidreportes').show();
});


function Selectobservaciones(data) {
    $('.b1').remove
    $('#divsalidaestsolicit').html('<label for="Idsede" class="control-label b1"><b>Estados Solicitud</b></label><select id="idEstado" name="idEstado" class="form-control b1">' +
        '<option selected>Seleccione..</option>' +
        '</select>');
    $.each(data, function (i, item) {
        $('#idEstado').append('<option value="' + item.idEstado + '" >' + item.nombre + '</option>')
    });
}

function Selectobservaciones2(data) {
    $('.b2').remove
    $('#divsalidaestrespuesta').html('<label for="idEstados" class="control-label b2"><b>Estados Rsponsables</b></label><select id="idEstados" name="idEstados" class="form-control b1">' +
        '<option selected>Seleccione..</option>' +
        '</select>');
    $.each(data, function (i, item) {
        $('#idEstados').append('<option value="' + item.idEstado + '" >' + item.nombre + '</option>')
    });
}


$(document).on('click', '#btnIdPreradicado', function () {
   var id_preradicado = document.getElementById('IdPreradicado').value;
    var id_estado = document.getElementById('idEstado').value;
    var data = { 'id_preradicado': id_preradicado, 'id_estado': id_estado }
    var t = $("input[name='__RequestVerificationToken']").val();
    var intjson = JSON.stringify(data);

    Swal.fire({
        title: 'Esta seguro?',
        text: "Modificar el estado!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, actualizar!'
    }).then((result) => {
        if (result.isConfirmed) {
             $.ajax({
            headers: {
            "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
                },
                type: "POST",
                url: baseUrl + "Correspondencia/PostSolicitudesEstado",
                data: intjson,
                dataType: "json",
                 success: function (data, textStatus, jqXHR) {
                     if (data == 2) {
                         Swal.fire({
                             position: 'top-end',
                             icon: 'success',
                             title: 'Estado Actualziado Correctamente',
                             showConfirmButton: false,
                             timer: 2500
                         })
                         $('#IdPreradicado').val('');
                     }
                     else {
                         Swal.fire({
                             position: 'top-end',
                             icon: 'info',
                             title: 'Varide los datos Ingresados...',
                             showConfirmButton: false,
                             timer: 2500
                         })
                         $('#IdPreradicado').val('');
                     }

                 },
                error: function (jqXHR, textStatus, errorThrown) {
                    console.log(jqXHR.status + errorThrown);
                }
            })
        }
    })
});

$(document).on('click', '#btnactualizar', function () {
    var t = $("input[name='__RequestVerificationToken']").val();
    var Access = { 'AccessFailedCount' : 0 };
    var intjson = JSON.stringify(Access);
    $.ajax({
        headers: {
            "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
        },
        type: "POST",
        url: baseUrl + "Usuarios/Sp_execActualizUser",
        data: intjson,
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            if (data) {
                Swal.fire({
                    position: 'top-end',
                    icon: 'success',
                    title: 'Estado Actualziado Correctamente',
                    showConfirmButton: false,
                    timer: 2500
                })
                location.reload();
            } else {
                Swal.fire({
                    position: 'top-end',
                    icon: 'warning',
                    title: 'No Se actualizo el todo el proceso. Tbl afectadas',
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

$(document).on('change', '#id_usuario_asignado2', function () {
    var nombre = document.getElementById('id_usuario_asignado2').value;
    var nombres = nombre.toUpperCase();
    var t = $("input[name='__RequestVerificationToken']").val();
    var Access = { 'nombres': nombres };
    var intjson = JSON.stringify(Access);
  //  alert(t); alert(intjson);
    $.ajax({
        headers: {
            "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
        },
        type: "POST",
        url: baseUrl + "Correspondencia/SelectVw_seg_usuarios",
        data: intjson,
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
        //    alert(data);
            if (data) {
             //   $('#flotid_usuario_asignado').remove();
                $('#id_usuario_asignado').remove();
                $('.flotid_usuario_asignado2').html('<select class="form-select" id="id_usuario_asignado" name="id_usuario_asignado" aria - label="Año" ></select> ');

                $.each(data, function (i, item) {
                    $('#id_usuario_asignado').append('<option value="'+item.id_usuario+'">' + item.nombres + '</option>' 

                    )
                })
                

            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status + errorThrown);
        }
    })
});



$(document).on('click', '#btnExeSp_updateEstResponsable', function () {
    var id_solicitud = document.getElementById('IdPreradicados').value;
    var id_estado = document.getElementById('idEstados').value;
    var t = $("input[name='__RequestVerificationToken']").val();
    var Access = { 'id_solicitud': id_solicitud, 'id_estado': id_estado };
    var intjson = JSON.stringify(Access);
    //  alert(t); alert(intjson);
    Swal.fire({
        title: 'Esta seguro?',
        text: "Modificar el estado!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, actualizar!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                headers: {
                    "RequestVerificationToken": t,
                    'Accept': 'application/json',
                    'Content-Type': 'application/json; charset=utf-8'
                },
                type: "POST",
                url: baseUrl + "Correspondencia/ExeSp_updateEstResponsable",
                data: intjson,
                dataType: "json",
                success: function (data, textStatus, jqXHR) {
                  //  alert(data);
                    if (data == 1) {
                        Swal.fire({
                            position: 'top-end',
                            icon: 'success',
                            title: 'Estado Actualizado Correctamente',
                            showConfirmButton: false,
                            timer: 2500
                        })
                        $('#IdPreradicados').val('');
                    } else {
                        Swal.fire({
                            position: 'top-end',
                            icon: 'warning',
                            title: 'No Se actualizo el todo el proceso. Tbl afectadas',
                            showConfirmButton: false,
                            timer: 2500
                        })

                    }

                },
                error: function (jqXHR, textStatus, errorThrown) {
                    console.log(jqXHR.status + errorThrown);
                }
            })
        }
    })
});

//$(document).on('click', '#btnIdPreradicado', function () {
//    var IdPreradicado = document.getElementById('IdPreradicado').value;
//    var t = $("input[name='__RequestVerificationToken']").val();
//    var intjson = JSON.stringify(IdPreradicado);
//    $.ajax({
//        headers: {
//            "RequestVerificationToken": t,
//            'Accept': 'application/json',
//            'Content-Type': 'application/json; charset=utf-8'
//        },
//        type: "POST",
//        url: baseUrl + "Correspondencia/PostSolicitudes",
//        data: intjson,
//        dataType: "json",
//        success: function (data, textStatus, jqXHR) {
//            $('.b1').remove
//            $('#divsalidaestsolicit').html('<input id="Idsede" name="Idsede" class="form-control b1">' +
//                '<option selected>Seleccione..</option>' +
//                '</select>');
//            $.each(data, function (i, item) {
//                $('#Idsede').append('<option value="' + item.idEstado + '" >' + item.nombre + '</option>')
//            });

//        },
//        error: function (jqXHR, textStatus, errorThrown) {
//            console.log(jqXHR.status + errorThrown);
//        }
//    })
//});



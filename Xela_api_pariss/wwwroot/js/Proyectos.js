'use strict'

var getUrl = window.location;
var baseUrl = getUrl.protocol + "//" + getUrl.host + "/";




$(document).on('click', '.btnConsultacontratista', function () {
    var NitContratante = document.getElementById('floatingInputGrid').value;
    var dat = { 'NitContratante': NitContratante }
    var param = JSON.stringify(dat);

    // Eliminar la variable del localStorage
    localStorage.removeItem('miVariable');
    // Guardar información en localStorage
    localStorage.setItem('miVariable', NitContratante);
    // Obtener información de localStorage
    var variableglobalNit = localStorage.getItem('miVariable');
    //alert(variableglobalNit); // Imprimirá el valor almacenado, en este caso "Hola, esta es mi información almacenada"
    $('#NitContratante').val(variableglobalNit);
       $.ajax({
        headers: {
            //   "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
        },
        type: "POST",
        //  url: baseUrl + "CafesaludSYC/ConsultarprocedCYS",
        // url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp",
           url: baseUrl + "Proyectos/Buscarcontratante",
        data: param,
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            if (data == 'sininformacion') {
                Swal.fire({
                    position: 'top-end',
                    icon: 'warning',
                    title: 'No se encuentra informacion : Por favor Cree un proyecto Nuevo',
                    showConfirmButton: false,
                    timer: 2500
                });
                $('.cardsalidabody').remove();
            } else {
                $('.cardsalidabody').remove();
                $('#Bodysalida').append(
                    '<div class="accordion cardsalidabody" id="accordionExample">' +
                    '<div class="accordion-item">' +
                    '<h2 class="accordion-header" id="headingOne">' +
                    '<button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">' +
                    'Cliente' +
                    '</button>' +
                    '</h2>' +
                    '<div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample">' +
                    '<div class="accordion-body">' +
                    '<section class="section contact">' +
                    '<div class="row gy-6">' +
                    '<div class="col-xl-12">' +
                    '<div class="row">' +
                    '<div class="col-lg-4">' +
                    '<div class="info-box card">' +
                    '<i class="bi bi-filter-circle"></i>' +
                    '<h3>Datos</h3>' +
                    '<p>' + data.nombreContratante + ',<br>Estado : ' + data.estado + '</p>' +
                    '</div>' +
                    '</div>' +
                    '<div class="col-lg-4">' +
                    '<div class="info-box card">' +
                    '<i class="bi bi-envelope"></i>' +
                    '<h3>Email</h3>' +
                    '<p>' + data.correoContratante + '</p>' +
                    '</div>' +
                    '</div>' +
                    '<div class="col-lg-4">' +
                    '<div class="info-box card">' +
                    '<i class="bi bi-clock"></i>' +
                    '<h3>Fechas</h3>' +
                    '<p>FechaInicio - ' + data.fechaInicio + '<br>FechaFin - ' + data.fechaFin + '</p>' +
                    '</div>' +
                    ' </div>' +
                    '<div class="col-lg-12">' +
                    '<div class="info-box card">' +
                    '<i class="bi bi-bag"></i>' +
                    '<h3>Objeto del Contrato</h3>' +
                    '<p>' + data.objetoContrato + '</p>' +
                    '</div>' +
                    '</div>' +
                    '</div>' +
                    '</div>' +
                    '</div>' +
                    '</section>' +
                    '</div>' +
                    ' </div>' +
                    '<div class="accordion-item">' +
                    '<h2 class="accordion-header" id="headingTwo">' +
                    '<button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">' +
                    'Actas' +
                    '</button>' +
                    '</h2>' +
                    '<div id="collapseTwo" class="accordion-collapse collapse" aria-labelledby="headingTwo" data-bs-parent="#accordionExample">' +
                    '<div class="accordion-body">' +
                    '</div>' +
                    '</div>' +
                    '</div>' +
                    '<div class="accordion-item">' +
                    '<h2 class="accordion-header" id="headingThree">' +
                    '<button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">' +
                    'Prorrogas' +
                    '</button>' +
                    '</h2>' +
                    '<div id="collapseThree" class="accordion-collapse collapse" aria-labelledby="headingThree" data-bs-parent="#accordionExample">' +
                    '<div class="accordion-body">' +
                    '</div>' +
                    '</div>' +
                    '</div>' +
                    '<div class="accordion-item">' +
                    '<h2 class="accordion-header" id="headingford">' +
                    '<button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseford" aria-expanded="false" aria-controls="collapseford">' +
                    'Soportes' +
                    '</button>' +
                    '</h2>' +
                    '<div id="collapseford" class="accordion-collapse collapse" aria-labelledby="headingford" data-bs-parent="#accordionExample">' +
                    '</div>' +
                    '</div>' +
                    '</div>'
                   )
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status + errorThrown);
            Swal.fire({
                position: 'top-end',
                icon: 'error',
                title: 'Tiempo de Respuesta insuficiente...Por favor Vuelva a generar la consulta',
                showConfirmButton: false,
                timer: 3000
            })
        }
    })
})

$(document).on('click', '.classproyectos', function () {
    var variableglobalNit = localStorage.getItem('miVariable');
 //   alert(variableglobalNit);
    $('.cardsalidabody').remove();
    $('#Bodysalida').html(
        '<div class="card cardsalidabody">'+
        '<div class="card-body">' +
        '<h5 class="card-title">Registrar Proyecto</h5>' +
        '<form class="row g-3" id="formRegistrar" method="post" enctype="multipart/form-data" >' +
        '<div asp-validation-summary="ModelOnly" class="text-danger"></div>'+
        '<div class="col-md-6">' +
        '<div class="form-floating">' +
        '<input type="text" class="form-control" disabled="true" value="" id="NitContratante" name="NitContratante" placeholder="Nit Contratante">' +
        '<label for="NitContratante">Nit Contratante</label>' +
        '</div>' +
        '</div>' +
        '<div class="col-md-6">' +
        '<div class="form-floating">' +
        '<input type="text" class="form-control" id="NombreContratante" name="NombreContratante" placeholder="Nombre Contratante">' +
        '<label for="NombreContratante">Nombre Contratante</label>' +
        '</div>' +
        '</div>' +
        '<div class="col-md-4">' +
        '<div class="form-floating">' +
        '<input type="text" class="form-control" id="CorreoContratante" name="CorreoContratante" placeholder="Correo Contratante">' +
        '<label for="CorreoContratante">Correo Contratante</label>' +
        '</div>' +
        '</div>' +
        '<div class="col-md-4">' +
        '<div class="form-floating">' +
        '<input type="date" class="form-control" id="FechaInicio" name="FechaInicio" placeholder="Fecha Inicio">' +
        '<label for="FechaInicio">Fecha Inicio</label>' +
        '</div>' +
        '</div>' +
        '<div class="col-md-4">' +
        '<div class="form-floating">' +
        '<input type="date" class="form-control" id="FechaFin" name="FechaFin" placeholder="Fecha Fin">' +
        '<label for="FechaFin">Fecha Fin</label>' +
        '</div>' +
        '</div>' +
        '<div class="col-12">' +
        '<div class="form-floating">' +
        '<textarea class="form-control" placeholder="Objeto Contrato" id="ObjetoContrato" name="ObjetoContrato" style="height: 100px;"></textarea>' +
        '<label for="floatingTextarea">Objeto Contrato</label>' +
        '</div>' +
        '</div>' +
        '<div class="col-md-6">' +
        '<div class="form-floating">' +
        '<input type="email" class="form-control" id="NitContratista" name="NitContratista" placeholder="Nit Contratista">' +
        '<label for="NitContratista">Nit Contratista</label>' +
        '</div>' +
        '</div>' +
       '<button type="button"class="bt btn-success btnregistrarnuevo">Registrar</button>' +
        '</form>' +
        '</div>' +
        '</div>' 
    )
    $('#NitContratante').val(variableglobalNit);
});

$(document).on('click', '#formRegistrar .btnregistrarnuevo', function () {
    var variableglobalNit = localStorage.getItem('miVariable');
  //  alert(variableglobalNit);
    //var formData = new FormData(document.getElementById("formRegistrar")); 
    var NombreContratante = document.getElementById('NombreContratante').value;
    var CorreoContratante = document.getElementById('CorreoContratante').value;
    var FechaInicio = document.getElementById('FechaInicio').value;
    var FechaFin = document.getElementById('FechaFin').value;
    var ObjetoContrato = document.getElementById('ObjetoContrato').value;
    var NitContratista = document.getElementById('NitContratista').value;
    var para = { 'Estado': 'Vigente', 'NitContratista': NitContratista, 'ObjetoContrato': ObjetoContrato, 'FechaFin': FechaFin, 'FechaInicio': FechaInicio, 'CorreoContratante': CorreoContratante, 'NitContratante': variableglobalNit, 'NombreContratante': NombreContratante };
    var par = JSON.stringify(para);
    var conf = confirm('¿Esta seguro de crear el proyecto?');
    if (conf) {
        var t = $("input[name='__RequestVerificationToken']").val();
        $.ajax({
            headers: {
                "RequestVerificationToken": t,
                'Accept': 'application/json',
               'Content-Type': 'application/json; charset=utf-8'
            },
            type: "POST",
            url: baseUrl + "Proyectos/Insertproyecto",
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
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Proyecto Registrado Correctamente !!',
                        showConfirmButton: false,
                        timer: 3000
                    });
                    $('.cardsalidabody').remove();
                }
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
    }
});

$(document).on('click','.classsoportes', function () {
    $('.cardsalidabody').remove();

});








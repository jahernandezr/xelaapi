'use strict'

var getUrl = window.location;
var baseUrl = getUrl.protocol + "//" + getUrl.host + "/";


$(document).on('click', '.modalafiliaciones', function () {
    formafiliaciones();
})
//$(document).on('click', '.modalcuentasMedicas', function () {
//    formcuentaMed();
//})

////function formafiliaciones() {
////    $('#ocult').remove();
////    $('#ocult1').remove();
////    $('.BtnDarkconsultarproced').remove();
////    $('.spanafili').append('<div id="ocult">Consulta Basica </div>');
////    $('#modalafiliacionessalida').append('<div id="ocult1"><form>'+
////        '<div class= "row g-2" >' +
////        '<div class="col-md">' +
////        '<div class="form-floating">' +
////        '<input type="text" class="form-control" id="nume_rads" name="nume_rads" value="" />' +
////        '<label for="floatingInputGrid">Radicado</label>' +
////        '</div>' +
////        '</div>' +
////        '<div class="col-md">' +
////        '<div class="col-md">' +
////        '<div class="form-floating">' +
////        '<input type="text" class="form-control" id="num_facts" name="num_facts" value="" />' +
////        '<label for="floatingInputGrid">Factura</label>' +
////        '</div>' +
////        '</div>' +
////        '</div>' +
//        '</div >' +
//        '<div class="row g-2">' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="text" class="form-control" id="ndoc_pacs" name="ndoc_pacs" value="" />' +
//        '<label for="floatingInputGrid">Doc Afiliado</label>' +
//        '</div>' +
//        '</div>' +
//        '<div class="col-md">' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="text" class="form-control" id="num_doc_ipss" name="num_doc_ipss" value="" />' +
//        '<label for="floatingInputGrid">Documento Ips</label>' +
//        '</div>' +
//        '</div>' +
//        '</div>' +
//        '</div>' +
//        '<div class="row g-2">' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="date" class="form-control" id="fech_ings" name="fech_ings" value="" />' +
//        '<label for="floatingInputGrid">Fecha Inicio</label>' +
//        '</div>' +
//        '</div>' +
//        '<div class="col-md">' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="date" class="form-control" id="fech_sals" name="fech_sals" value="" />' +
//        '<label for="floatingInputGrid">Fecha Fin</label>' +
//        '</div>' +
//        '</div>' +
//        '</div>' +
//        '</div>' +
//        '</form >' +
//        '</div ></div>' +
//        '<div class="modal-footer BtnDarkconsultarproced">' +
//        '<button type="button" class="btn btn-dark ">Consultar</button>' +
//        '</div>')
//}
//function formcuentaMed() {
//    $('#ocult').remove();
//    $('#ocult1').remove();
//    $('.BtnDarkconsultarproced').remove();
//    $('.spanafili').append('<div id="ocult">Consulta Basica Cuentas Medicas</div>');
//    $('#modalafiliacionessalida').append('<div id="ocult1"><form>' +
//        '<div class= "row g-2" >' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="text" class="form-control" id="nume_rads" name="nume_rads" value="" />' +
//        '<label for="floatingInputGrid">Radicado</label>' +
//        '</div>' +
//        '</div>' +
//        '<div class="col-md">' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="text" class="form-control" id="num_facts" name="num_facts" value="" />' +
//        '<label for="floatingInputGrid">Factura</label>' +
//        '</div>' +
//        '</div>' +
//        '</div>' +
//        '</div >' +
//        '<div class="row g-2">' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="text" class="form-control" id="ndoc_pacs" name="ndoc_pacs" value="" />' +
//        '<label for="floatingInputGrid">Doc Afiliado</label>' +
//        '</div>' +
//        '</div>' +
//        '<div class="col-md">' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="text" class="form-control" id="num_doc_ipss" name="num_doc_ipss" value="" />' +
//        '<label for="floatingInputGrid">Documento Ips</label>' +
//        '</div>' +
//        '</div>' +
//        '</div>' +
//        '</div>' +
//        '<div class="row g-2">' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="date" class="form-control" id="fech_ings" name="fech_ings" value="" />' +
//        '<label for="floatingInputGrid">Fecha Inicio</label>' +
//        '</div>' +
//        '</div>' +
//        '<div class="col-md">' +
//        '<div class="col-md">' +
//        '<div class="form-floating">' +
//        '<input type="date" class="form-control" id="fech_sals" name="fech_sals" value="" />' +
//        '<label for="floatingInputGrid">Fecha Fin</label>' +
//        '</div>' +
//        '</div>' +
//        '</div>' +
//        '</div>' +
//        '</form >' +
//        '</div ></div>' +
//        '<div class="modal-footer BtnDarkconsultarproced">' +
//        '<button type="button" class="btn btn-dark ">Consultar</button>' +
//        '</div>')
//}


//$(document).on('click', '.BtnDarkconsultarproced', function () {
//    var t = $("input[name='__RequestVerificationToken']").val();
//    var nume_rad = document.getElementById('nume_rads').value;
//    var fech_ing = document.getElementById('fech_ings').value;
//    var fech_sal = document.getElementById('fech_sals').value;
//    var num_fact = document.getElementById('num_facts').value;
//    var ndoc_pac = document.getElementById('ndoc_pacs').value;
//    var num_doc_ips = document.getElementById('num_doc_ipss').value;
//    var dat = { 'nume_rad': nume_rad, 'fech_ing': fech_ing, 'fech_sal': fech_sal, 'num_fact': num_fact, 'ndoc_pac': ndoc_pac, 'num_doc_ips': num_doc_ips }
//    var dat2 = { 'nume_rad': nume_rad, 'num_fact': num_fact, 'ndoc_pac': ndoc_pac, 'num_doc_ips': num_doc_ips, 'fech_ing': '1999-01-01', 'fech_sal': '1999-01-01' }
//    var Param = JSON.stringify(dat);
//    var Param2 = JSON.stringify(dat2);
//   // alert(Param);
//    var f1 = fech_ing.length;
//    var f2 = fech_sal.length;
//    if (f1 > 0 || f2 > 0) {
//        $.ajax({
//            headers: {
//                "RequestVerificationToken": t,
//                'Accept': 'application/json',
//                'Content-Type': 'application/json; charset=utf-8'
//            },
//            type: "POST",
//          //  url: baseUrl + "CafesaludSYC/ConsultarprocedCYS",
//            url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp",
//            data: Param,
//            dataType: "json",
//            success: function (data, textStatus, jqXHR) {
//                if (data == 'Sin Informacion') {
//                    Swal.fire({
//                        position: 'top-end',
//                        icon: 'info',
//                        title: 'Sin Informacion...',
//                        showConfirmButton: false,
//                        timer: 2500
//                    })
//                } else {
//                    funtablesalidaSYC(data);
//                    $('#tablesalidaSYC1').DataTable();
//                    $('#staticBackdrop').modal('hide');
//                   // $('#modalafiliacionessalida').hide();
//                }

//            },
//            error: function (jqXHR, textStatus, errorThrown) {
//                console.log(jqXHR.status + errorThrown);
//            }
//        })
//    } else {
//        $.ajax({
//            headers: {
//                "RequestVerificationToken": t,
//                'Accept': 'application/json',
//                'Content-Type': 'application/json; charset=utf-8'
//            },
//            type: "POST",
//          //  url: baseUrl + "CafesaludSYC/ConsultarprocedCYS",
//            url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp",
//            data: Param2,
//            dataType: "json",
//            success: function (data, textStatus, jqXHR) {
//                var propiedades = Object.keys(data);
//                if (propiedades.length<1) {
//                    Swal.fire({
//                        position: 'top-end',
//                        icon: 'info',
//                        title: 'Sin Informacion...',
//                        showConfirmButton: false,
//                        timer: 2500
//                    })
//                } else {
//                    funtablesalidaSYC(data);
//                    $('#tablesalidaSYC1').DataTable();
//                    $('#staticBackdrop').modal('hide');
//                }
//            },
//            error: function (jqXHR, textStatus, errorThrown) {
//                console.log(jqXHR.status + errorThrown);
//            }
//        });
//    }
//});


$(document).on('click', '#Btnconsultparam', function () {
    var t = $("input[name='__RequestVerificationToken']").val();
    var ndoc_pac = document.getElementById('inputparam2').value;
    var par = document.getElementById('inputparam').value;
    var dat = { 'ndoc_pac': ndoc_pac }
    var dat2 = { 'nume_rad': ndoc_pac }
    var dat3 = { 'id_rad': ndoc_pac }
    var dat4 = { 'num_fact': ndoc_pac }
    var Param = JSON.stringify(dat);
    var Param2 = JSON.stringify(dat2);
    var Param3 = JSON.stringify(dat3);
    var Param4 = JSON.stringify(dat4);
   // alert(par);
    $('.salispan2').html('<div class="spinner-border text-primary" role="status">' +
        '<span class= "visually-hidden" >...</span >' +
        '</div > ');
    if (par == 1) {
        $.ajax({
            headers: {
                "RequestVerificationToken": t,
                'Accept': 'application/json',
                'Content-Type': 'application/json; charset=utf-8'
            },
            type: "POST",
            //  url: baseUrl + "CafesaludSYC/ConsultarprocedCYS",
            // url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp",
            url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp2",
            data: Param,
            dataType: "json",
            success: function (data, textStatus, jqXHR) {
                if (data == 'Sin Informacion') {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'info',
                        title: 'Sin Informacion...',
                        showConfirmButton: false,
                        timer: 2500
                    })
                } else {
                    funtablesalidaSYC(data);
                    $('#tablesalidaSYC1').DataTable();
                    $('#staticBackdrop').modal('hide');
                    $('.spansali2').remove();
                }

            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(jqXHR.status + errorThrown);
                Swal.fire({
                    position: 'top-end',
                    icon: 'error',
                    title: 'Tiempo de Respuesta insuficiente...Por favor Vuelva a consultar',
                    showConfirmButton: false,
                    timer: 3000
                })
            }
        })
    } else if (par == 2) {
        $.ajax({
            headers: {
                "RequestVerificationToken": t,
                'Accept': 'application/json',
                'Content-Type': 'application/json; charset=utf-8'
            },
            type: "POST",
            //  url: baseUrl + "CafesaludSYC/ConsultarprocedCYS",
            // url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp",
            url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp3",
            data: Param2,
            dataType: "json",
            success: function (data, textStatus, jqXHR) {
                if (data == 'Sin Informacion') {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'info',
                        title: 'Sin Informacion...',
                        showConfirmButton: false,
                        timer: 2500
                    })
                } else {
                    funtablesalidaSYC(data);
                    $('#tablesalidaSYC1').DataTable();
                    $('#staticBackdrop').modal('hide');
                    $('.spansali2').remove();
                }

            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(jqXHR.status + errorThrown);
                Swal.fire({
                    position: 'top-end',
                    icon: 'error',
                    title: 'Tiempo de Respuesta insuficiente...Por favor Vuelva a consultar',
                    showConfirmButton: false,
                    timer: 3000
                })
            }
        })
    } else if (par == 3) {
        $.ajax({
            headers: {
                "RequestVerificationToken": t,
                'Accept': 'application/json',
                'Content-Type': 'application/json; charset=utf-8'
            },
            type: "POST",
            //  url: baseUrl + "CafesaludSYC/ConsultarprocedCYS",
            // url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp",
            url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp4",
            data: Param3,
            dataType: "json",
            success: function (data, textStatus, jqXHR) {
                if (data == 'Sin Informacion') {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'info',
                        title: 'Sin Informacion...',
                        showConfirmButton: false,
                        timer: 2500
                    })
                } else {
                    funtablesalidaSYC(data);
                    $('#tablesalidaSYC1').DataTable();
                    $('#staticBackdrop').modal('hide');
                    $('.spansali2').remove();
                }

            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(jqXHR.status + errorThrown);
                Swal.fire({
                    position: 'top-end',
                    icon: 'error',
                    title: 'Tiempo de Respuesta insuficiente...Por favor Vuelva a consultar',
                    showConfirmButton: false,
                    timer: 3000
                })
            }
        })
    } else if (par == 4) {
        $.ajax({
            headers: {
                "RequestVerificationToken": t,
                'Accept': 'application/json',
                'Content-Type': 'application/json; charset=utf-8'
            },
            type: "POST",
            //  url: baseUrl + "CafesaludSYC/ConsultarprocedCYS",
            // url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp",
            url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp5",
            data: Param4,
            dataType: "json",
            success: function (data, textStatus, jqXHR) {
                if (data == 'Sin Informacion') {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'info',
                        title: 'Sin Informacion...',
                        showConfirmButton: false,
                        timer: 2500
                    })
                } else {
                    funtablesalidaSYC(data);
                    $('#tablesalidaSYC1').DataTable();
                    $('#staticBackdrop').modal('hide');
                    $('.spansali2').remove();
                }

            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(jqXHR.status + errorThrown);
                Swal.fire({
                    position: 'top-end',
                    icon: 'error',
                    title: 'Tiempo de Respuesta insuficiente...Por favor Vuelva a consultar',
                    showConfirmButton: false,
                    timer: 3000
                })
            }
        })
    } else {
        Swal.fire({
            position: 'top-end',
            icon: 'info',
            title: 'Seleccione un parametro...',
            showConfirmButton: false,
            timer: 2500
        })
    }

    });

function formafiliaciones() {
    $('#ocult').remove();
    $('#ocult1').remove();
    $('.BtnDarkconsultarproced').remove();
    $('.spanafili').append('<div id="ocult">Consulta Basica </div>');
    $('#modalafiliacionessalida').append('<div id="ocult1"><form>' +

        '<div class="input-group" style="padding:5%">' +
        '<div class="form-floating col-md-12 col-sm-2">' +
        '<input type="text" class="form-control col-md-12 col-sm-2" id="inputparam2" name="inputparam2" placeholder="" value="">' +
        '<label for="floatingInputGrid">Digite un parametro</label>' +
        '</div>' +
        '<div class="form-floating  col-md-12 col-sm-2">' +
        '<select class="form-select  col-md-12 col-sm-2" id="inputparam" name="inputparam" value="" aria-label="">' +
        '<option selected>Seleccione un parametro</option>' +
        '<option value="1">Documento del usuario</option>' +
        '<option value="2">Numero de radicado</option>' +
        '<option value="3">Id radicado</option>' +
        '<option value="4">Numero factura</option>' +
        '</select>' +
        '<label for="floatingSelect">Parametro</label>' +
        '</div>' +
        '</div>' +
        '<button class="btn btn-dark col-md-12 col-sm-2 " type="button" id="Btnconsultparam" width="100%">Consultar<span class="salispan2"></span></button>'+
        '</form >');

}

function funtablesalidaSYC(data) {
    $('#tablesalidaSYC1').remove();
    $('.tablesalidaSYC').html('<table class="table table-hover table-responsive" id="tablesalidaSYC1" style="font-size:10px">'+
       '<thead>'+
       ' <tr>'+
           ' <th style="display:none">Id</th>'+
           ' <th scope="col">Documento</th>'+
           ' <th scope="col">PrimerNombre </th>'+
            '<th scope="col">SegundoNombre</th>'+
           ' <th scope="col">PrimerApellido </th>'+
           ' <th scope="col">SegundoApellido</th>'+
           ' <th scope="col">DocumentoIps</th>'+
           ' <th scope="col" style="width:100px">NombreIps</th>'+
          // ' <th scope="col">Regional</th>'+
           //' <th scope="col">Estado</th>'+
           //' <th scope="col">Tramite</th>'+
           ' <th scope="col">FechaFactura</th>'+
           ' <th scope="col">FechaIngreso</th>'+
           ' <th scope="col">FechaSalida</th>'+
           //' <th scope="col">Modalidad</th>'+
           ' <th scope="col">PrefFactura</th>'+
           ' <th scope="col">Numerofactura</th>'+
           ' <th scope="col">StickerCM</th>'+
           ' <th scope="col">ValorBruto</th>'+
           ' <th scope="col">ValorNeto</th>'+
           ' <th scope="col">ValorGlosado</th>'+
           ' <th scope="col">ValorGlosaInicial</th>'+
           ' <th scope="col">Soporte</th>'+
        '</tr>'+
        '</thead>'+
        '<tbody></tbody></table>');
        $.each(data, function (i, item) {
        $('#tablesalidaSYC1').append('<tr>'+
            '<td style="display:none">' + item.id_rad + '</td>'+
            ' <td> ' + item.ndoc_pac + '</td> '+
            ' <td> ' + item.nomb1_pac +'</td> '+
            ' <td> ' + item.nomb2_pac +'</td> '+
                   ' <td> ' + item.ape1_pac +'</td> '+
                   ' <td> ' + item.ape2_pac +'</td> '+
                   ' <td> ' + item.num_doc_ips +'</td> '+
                   ' <th style="width:100px; font-size:6px" scope="col"> ' + item.nomb_ips +'</th> '+
                 //  ' <td> ' + item.nomb_reg +'</td> '+
                  // ' <td> ' + item.desc_est +'</td> '+
                  // ' <td> ' + item.desc_tramite +'</td> '+
                   ' <td> ' + item.fech_fact +'</td> '+
                   ' <td> ' + item.fech_ing +'</td> '+
                   ' <td> ' + item.fech_sal +'</td> '+
                  // ' <td> ' + item.modalidad +'</td> '+
                   ' <td> ' + item.pref_fact +'</td> '+
                   ' <td> ' + item.num_fact +'</td> '+
                   ' <td> ' + item.stickerCM +'</td> '+
                   ' <td> ' + item.val_bruto +'</td> '+
                   ' <td> ' + item.val_neto +'</td> '+
            ' <td> ' + item.valorGlosado + '</td> ' +
                   ' <td> ' + item.vlrGlosaInicial +'</td> '+
                   ' <td><button  type="button"  id="btnbusim" data-bs-toggle="modal" data-bs-target="#staticBackdrop">buscar</button></td> '+
                ' </tr>');
    });
}
$(document).on('click','#btnbusim', function () {   
    var id_rad = $(this).parent().parent().children('td:eq(0)').text();
    var dat = { 'id_rad': id_rad }
    var param = JSON.stringify(dat);
    $('#ocult').remove();
    $('#ocult1').remove();
    $('.BtnDarkconsultarproced').remove();
    $('.spanafili').append('<div id="ocult"><span class="salispan2"></span>Soportes Relacionados al radicado : ' + id_rad +'</div>');
    $('.salispan2').html('<div class="spinner-border text-primary" role="status">' +
        '<span class= "visually-hidden" >...</span >' +
        '</div > ');

    $.ajax({
        headers: {
         //   "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
        },
        type: "POST",
        //  url: baseUrl + "CafesaludSYC/ConsultarprocedCYS",
        // url: baseUrl + "CafesaludSYC/ConsultarprocedCYSsp",
        url: baseUrl + "CafesaludSYC/TraerImagen",
        data: param,
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
            if (data == 'Sin Informacion') {
                Swal.fire({
                    position: 'top-end',
                    icon: 'info',
                    title: 'No se encontro ninguna Imagen...',
                    showConfirmButton: false,
                    timer: 2500
                })
            } else {
                
                TablesalidaSYCIMG(data);
                $('#tablesalidaSYC1IMG').DataTable();
                $('.salispan2').remove();
             }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status + errorThrown);
            Swal.fire({
                position: 'top-end',
                icon: 'error',
                title: 'Tiempo de Respuesta insuficiente...Por favor Vuelva a generar el soporte',
                showConfirmButton: false,
                timer: 3000
            })
        }
    })
})

function TablesalidaSYCIMG(data) {
    $('#tablesalidaSYC1IMG').remove();
    $('#modalafiliacionessalida').html('<table class="table table-hover table-responsive" id="tablesalidaSYC1IMG" style="font-size:10px">' +
        '<thead>' +
        ' <tr>' +
        ' <th scope="col">Soporte</th>' +
        ' <th scope="col">Descripcion </th>' +
        '</tr>' +
        '</thead>' +
        '<tbody></tbody></table>');
    $.each(data, function (i, item) {
        $('#tablesalidaSYC1IMG').append('<tr>' +
            '<td scope = "row"><a href="http://10.127.209.5/' + item.ruta_san + '" target="_blank" class="btn btn-outline-primary btn-sm">ver</a></td>' +
            ' <td> ' + item.desc_tip + '</td> ' +
            ' </tr>');
    });
}

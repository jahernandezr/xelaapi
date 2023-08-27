'use strict'

var getUrl = window.location;
var baseUrl = getUrl.protocol + "//" + getUrl.host + "/";


$(document).on('click','.efectojquery', function () {
    $('.salidatoack').toggle(1000);
});
$(document).on('click', '#btnconsultarNro', function () {
    $('#showepnner').show();
    var IdentificationNumber = document.getElementById('IdentificationNumber').value;
    var data = { 'IdentificationNumber': IdentificationNumber}
    var t = $("input[name='__RequestVerificationToken']").val();
    var intjson = JSON.stringify(data);
   // alert(intjson); alert(t);
        $.ajax({
                    headers: {
                        "RequestVerificationToken": t,
                        'Accept': 'application/json',
                        'Content-Type': 'application/json; charset=utf-8'
                    },
                    type: "POST",
                    url: baseUrl + "Usuarios/PosConsultaDocImagen",
                  //url: baseUrl + "Vwimagenes/PosConsultaDocImagen",
                    data: intjson,
                    dataType: "json",
            success: function (data, textStatus, jqXHR) {
              //  var dat = data[0].id;
  
                    tabladetalleimagen(data);
                    $('#tabladetalleimg').dataTable();   
                      $('#showepnner').hide();
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        console.log(jqXHR.status + errorThrown);
                    }
                })
              });

function tabladetalleimagen(data) { 

    $('#tabladetalleimg').remove();
    $('#saldiv1').html('<table class="table" id="tabladetalleimg"> '+
        '<thead >'+
            '<tr>'+
        '<th style="display:none">id</th>' +
        '<th scope="col">Img</th>' +
                '<th scope="col">FatherLastName</th>'+
                '<th scope="col">MotherLastName</th>'+
                '<th scope="col">Description</th>' +
                '<th scope="col">RequestDate</th>' +
      //          '<th scope="col">Imagen</th>' +
            '</tr>'+
        '</thead >'+
        '<tbody></tbody>'+
    '</table >');
    $.each(data, function (i, item) {
     //   var base64Data = btoa(String.fromCharCode.apply(null, item.Image));
        $('#tabladetalleimg').append('<tr>' +
            '<td style="display:none">' + item.ctcDigitalizationId + '</td>' +
            '<td scope = "row"><a href="#" class="btn btn-dark btn-sm" id="btnbvwer">ver</a></td>' +
            '<td >' + item.fatherLastName +'</td>'+
            '<td>' + item.motherLastName +'</td>' +
            '<td>' + item.description +'</td>' +
            '<td>' + item.requestDate + '</td>' +
         //   '<td>' + btoa(String.fromCharCode.apply(null, item.Image)) + '</td>' +
          '</tr>'
        );
    })
};

$(document).on('click', '#tabladetalleimg #btnbvwer', function () {
    var ctcDigitalizationId = $(this).parent().parent().children('td:eq(0)').text();
    var data = { 'CTCDigitalizationId': ctcDigitalizationId }
  //  var t = $("input[name='__RequestVerificationToken']").val();
    var intjson = JSON.stringify(data);
    // alert(intjson); alert(t);
    $.ajax({
        headers: {
       //     "RequestVerificationToken": t,
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8'
        },
        type: "POST",
        url: baseUrl + "Usuarios/Buscaridimagen",
        data: intjson,
        dataType: "json",
        success: function (data, textStatus, jqXHR) {
                var byteCharacters = atob(data.image);
                var byteNumbers = new Array(byteCharacters.length);
                for (var i = 0; i < byteCharacters.length; i++) {
                    byteNumbers[i] = byteCharacters.charCodeAt(i);
                }
                var byteArray = new Uint8Array(byteNumbers);
                var charArray = Array.from(byteArray, function (byte) {
                    return String.fromCharCode(byte);
                });
                var base64Data = btoa(charArray.join(''));
                var pdfDataUri = 'data:application/pdf;base64,' + base64Data;

                // Crear un enlace temporal
                var link = document.createElement('a');
                link.href = pdfDataUri;
                link.download = 'documento.pdf';

                // Simular un clic en el enlace para iniciar la descarga
                link.click();
            
            
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.status + errorThrown);

        }
    })
});






'use stric'

$(document).ready(function () {
  //  alert('a')
  //  $('.datatable').dataTable('');

    $('#example').DataTable({
        buttons: [
            'excel'
        ]
    });
    var inputmodulos = document.getElementById('inputmodulos').value;
    if (inputmodulos === 'proyectos') {
        $('.navmodulos').remove();
        $('#idmoduloscomplementos').html('<div class="filter navmodulos">' +
            '<a class="icon" href="#" data-bs-toggle="dropdown" style="padding-left:15%;font-size:14px;color:#012970">Mas opciones <i class="bi bi-three-dots"></i></a>' +
            '<ul class= "dropdown-menu dropdown-menu-end dropdown-menu-arrow" > ' +
            '<li > <a class="dropdown-item classproyectos" href="#" >Nuevo proyecto</a></li > ' +
            '<li > <a class="dropdown-item classactas" href="#">Actas</a></li > ' +
            '<li > <a class="dropdown-item classprorrogas" href="#">Prorrogas</a></li > ' +
            '<li > <a class="dropdown-item classsoportes" href="#">Soportes</a></li > ' +
            '   </ul > ' +
            '</div > ')
    } else if (inputmodulos === 'Nomina') {
        $('.navmodulos').show();
        //$('#idmoduloscomplementos').html('<div class="filter navmodulos">' +
        //    '<a class="icon" href="#" data-bs-toggle="dropdown" style="padding-left:15%;font-size:14px;color:#012970">Estados  <i class="bi bi-funnel-fill"></i></a>' +
        //    '<ul class= "dropdown-menu dropdown-menu-end dropdown-menu-arrow" > ' +
        //    '<li > <a asp-action="Index" asp-controller="Nomina" class="dropdown-item liactivos" >Activos</a></li > ' +
        //    '<li > <a asp-action="ParamentroEstadoInactivo" asp-controller="Nomina" class="dropdown-item liinactivos">Inactivos</a></li > ' +
        //    '<li > <a asp-action="ParamentroEstadoTodo" asp-controller="Nomina" class="dropdown-item litodos">Todos los registros</a></li > ' +
        //    '   </ul > ' +
        //    '</div > ')
    }
 })
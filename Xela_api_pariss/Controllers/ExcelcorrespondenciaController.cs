using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Xela_api_pariss.Models;
using Xela_api_pariss.Models.Correpondenciabd;
using Xela_api_pariss.Models.NominaApp;

namespace Xela_api_pariss.Controllers
{
    public class ExcelcorrespondenciaController : Controller
    {
        private readonly Correspondencia_dbContext _DbContext;
        public ExcelcorrespondenciaController(Correspondencia_dbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Exportdestinatarios( VwoficiosDestinatarios destinarios)
        {
            var dataa = await _DbContext.VwoficiosDestinatarios.Where
                (d => d.idDestinatario == destinarios.idDestinatario).ToListAsync();

            var nombreArchivo = $"OficioDestinatarios.xlsx";
            return  GenerarExcelOficiosdestinaarios(nombreArchivo, dataa);
        }


        // se crea  una funcion para exportar 
        private FileResult GenerarExcelOficiosdestinaarios(string nombreArchivo, IEnumerable<VwoficiosDestinatarios> dataa)
        {
            DataTable dataTable = new("dataa");
            dataTable.Columns.AddRange(new DataColumn[] {
                new DataColumn("idDestinatario"),
                new DataColumn("idOficio"),
                new DataColumn("fecha_respuesta"),
                new DataColumn("fecha_registro")
            });

            foreach (var dat in dataa)
            {
                dataTable.Rows.Add(dat.idDestinatario,
                    dat.idOficio,
                    dat.fecha_registro,
                    dat.fecha_respuesta
                    );
            }
            using XLWorkbook wb = new();
            wb.Worksheets.Add(dataTable);

            using MemoryStream ms = new();
            wb.SaveAs(ms);
            return File(ms.ToArray(),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                nombreArchivo);

        }
        [HttpGet]
        public async Task<IActionResult> Excellistaterceros()
        {
            var dataa = await _DbContext.Vwlistadoterceros.ToListAsync();

            var nombreArchivo = $"listatercero.xlsx";
            return GenerarExcellistaterceros(nombreArchivo, dataa);

        }


        // se crea  una funcion para exportar 
        private FileResult GenerarExcellistaterceros(string nombreArchivo, IEnumerable<Vwlistadoterceros> data)
        {
            DataTable dataTable = new("data");
            dataTable.Columns.AddRange(new DataColumn[] {
                new DataColumn("TIPO_DOCUMENTO_PETICIONARIO"),
                new DataColumn("NUM_DOCUMENTO_PETICIONARIO"),
                new DataColumn("NOMBRE1_PETICIONARIO"),
                new DataColumn("APELLIDO1_PETICIONARIO"),
                new DataColumn("NOMBRE2_PETICIONARIO"),
                new DataColumn("APELLIDO2_PETICIONARIO"),
                new DataColumn("TELEFONO_PETICIONARIO"),
                new DataColumn("CELULAR_PETICIONARIO"),
                new DataColumn("DEPARTAMENTO_PETICIONARIO"),
                new DataColumn("CIUDAD_PETICIONARIO"),
                new DataColumn("DIRECCION_PETICIONARIO"),
                new DataColumn("EMAIL_PETICIONARIO"),
                new DataColumn("TIPO_DOCUMENTO_APODERADO"),
                new DataColumn("NUM_DOCUMENTO_APODERADO"),
                new DataColumn("NOMBRE1_APODERADO"),
                new DataColumn("NOMBRE2_APODERADO"),
                new DataColumn("APELLIDO1_APODERADO"),
                new DataColumn("APELLIDO2_APODERADO"),
                new DataColumn("TELEFONO_APODERADO"),
                new DataColumn("CELULAR_APODERADO"),
                new DataColumn("DEPARTAMENTO_APODERADO"),
                new DataColumn("CIUDAD_APODERADO"),
                new DataColumn("DIRECCION_APODERADO"),
                new DataColumn("EMAIL_APODERADO")
            });

            foreach (var dat in data)
            {
                dataTable.Rows.Add(dat.TIPO_DOCUMENTO_PETICIONARIO,
                    dat.NUM_DOCUMENTO_PETICIONARIO,
                    dat.NOMBRE1_PETICIONARIO,
                    dat.NOMBRE2_PETICIONARIO,
                    dat.APELLIDO1_PETICIONARIO,
                    dat.APELLIDO2_PETICIONARIO,
                    dat.TELEFONO_PETICIONARIO,
                    dat.CELULAR_PETICIONARIO,
                    dat.DEPARTAMENTO_PETICIONARIO,
                    dat.CIUDAD_PETICIONARIO,
                    dat.DIRECCION_PETICIONARIO,
                    dat.EMAIL_PETICIONARIO,
                    dat.TIPO_DOCUMENTO_APODERADO,
                    dat.NUM_DOCUMENTO_APODERADO,
                    dat.NOMBRE1_APODERADO,
                    dat.NOMBRE2_APODERADO,
                    dat.APELLIDO1_APODERADO,
                    dat.APELLIDO2_APODERADO,
                    dat.TELEFONO_APODERADO,
                    dat.CELULAR_APODERADO,
                    dat.DEPARTAMENTO_APODERADO,
                    dat.CIUDAD_APODERADO,
                    dat.DIRECCION_APODERADO,
                    dat.EMAIL_APODERADO

                    );
            }
            using XLWorkbook wb = new();
            wb.Worksheets.Add(dataTable);

            using MemoryStream ms = new();
            wb.SaveAs(ms);
            return File(ms.ToArray(),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                nombreArchivo);
            }
        [HttpPost]
        public async Task<IActionResult> ExcelSp_solicitudesParametro( VWsolicitudesParametro modelo) {

            var datt = await _DbContext.VWsolicitudesParametro.Where(s => s.id_usuario_asignado == modelo.id_usuario_asignado &&
            s.fh_asignacion == modelo.fh_asignacion && s.fh_asignacio == modelo.fh_asignacio).ToListAsync();

            var nombreArchivo = $"solicitudesParametro.xlsx";
            return GenerarExcelSp_solicitudesParametro(nombreArchivo, datt);
        }

        // se crea  una funcion para exportar 
        private FileResult GenerarExcelSp_solicitudesParametro(string nombreArchivo, IEnumerable<VWsolicitudesParametro> datt)
        {
            DataTable dataTable = new("datt");
            dataTable.Columns.AddRange(new DataColumn[] {
                new DataColumn("id_preradicado"),
                new DataColumn("fecha_respuesta"),
                new DataColumn("estado"),
                new DataColumn("fecha_asignacion"),
                new DataColumn("nombre_usuario"),
                new DataColumn("id_usuario_asignado")
               });

            foreach (var dat in datt)
            {
                dataTable.Rows.Add(dat.id_preradicado,
                    dat.fecha_respuesta,
                    dat.estado,
                    dat.fecha_asignacion,
                    dat.nombre_usuario,
                    dat.id_usuario_asignado
                  );
            }
            using XLWorkbook wb = new();
            wb.Worksheets.Add(dataTable);

            using MemoryStream ms = new();
            wb.SaveAs(ms);
            return File(ms.ToArray(),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                nombreArchivo);
        }

    }
}

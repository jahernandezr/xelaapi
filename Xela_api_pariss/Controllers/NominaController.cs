using ClosedXML.Excel;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xela_api_pariss.Models.Correpondenciabd;
using Xela_api_pariss.Models.DbCafesalud;
using Xela_api_pariss.Models.ProyectosApp;
using Xela_api_pariss.Models.NominaApp;
using DocumentFormat.OpenXml.InkML;
using Xela_api_pariss.Models;
//using Xela_api_pariss.Servicios;

namespace Xela_api_pariss.Controllers
{
    public class NominaController : Controller
    {
        private readonly NominaAppContext _DbContext;
        public NominaController(NominaAppContext dbContext)
        {
            _DbContext = dbContext;
        }
        public ActionResult Nuevo() {
            return View();        
        }
        public async Task<IActionResult> Index()
        {
            var usuarios = await _DbContext.Nomina_nomina.Where(u => u.Estado== "Activo").ToListAsync();
            var modelo = new Nomina_nominaViewModels();
            modelo.Nomina = usuarios;
            return View(modelo);
        }
        public async Task<IActionResult> ParamentroEstadoInactivo()
        {
            var usuarios = await _DbContext.Nomina_nomina.Where(u => u.Estado == "Inactivo").ToListAsync();
            var modelo = new Nomina_nominaViewModels();
            modelo.Nomina = usuarios;
            return View(modelo);
        }
        public async Task<IActionResult> ParamentroEstadoTodo()
        {
            var usuarios = await _DbContext.Nomina_nomina.ToListAsync();
            var modelo = new Nomina_nominaViewModels();
            modelo.Nomina = usuarios;
            return View(modelo);
        }
        [HttpPost]
        public async Task<IActionResult> ParametroIndivial([FromBody] Models.NominaApp.Nomina_nomina modelo)
        {
            var data = await _DbContext.Nomina_nomina.Where(s => s.Id == modelo.Id).FirstOrDefaultAsync();
            if (data == null)
            {
                return Ok("sininformacion");
            }
            return Ok(data);
           }
        [HttpPost]
        public async Task<IActionResult> Insertusuarionew([FromBody] Models.NominaApp.Nomina_nomina modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _DbContext.Nomina_nomina.Add(modelo);
                    await _DbContext.SaveChangesAsync();
                    return Ok("Proyectoinsertadocorrectamente");
                }

                return BadRequest("Noregistrado");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Noregistrado" + ex.Message);
            }

        }
        [HttpPost]
        public async Task<IActionResult>Updateusuarionew ([FromBody] Models.NominaApp.Nomina_nomina modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var registroExistente = await _DbContext.Nomina_nomina.FirstOrDefaultAsync(n => n.Id == modelo.Id);

                    if (registroExistente == null)
                    {
                        return NotFound("Registro no encontrado"); // Manejar si el registro no se encuentra
                    }

                    // Actualiza las propiedades del registro existente con los valores del modelo
                    registroExistente.Nombre = modelo.Nombre;
                    registroExistente.Apellido = modelo.Apellido;
                    registroExistente.Informacion_completa = modelo.Informacion_completa;
                    registroExistente.Liquidado = modelo.Liquidado;
                    registroExistente.ValorSueldo = modelo.ValorSueldo;
                    registroExistente.Cargo = modelo.Cargo;
                    registroExistente.Estado = modelo.Estado;
                    registroExistente.Direccion = modelo.Direccion;
                    registroExistente.Sede = modelo.Sede;
                    registroExistente.Telefono = modelo.Telefono;
                    registroExistente.Correo_electronico = modelo.Correo_electronico;
                    registroExistente.Numero_identificacion = modelo.Telefono;
                    registroExistente.Tipo_de_documento = modelo.Tipo_de_documento;

                    await _DbContext.SaveChangesAsync();
                    return Ok("Registroactualizadocorrectamente");
                }

                return BadRequest("Datosnovalidos");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erroralactualizarelregistro: " + ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetGrafico() {
            var data = await _DbContext.VwNomnina_nomina.ToListAsync();
            if (data == null)
            {
                return Ok("Sininformacion");
            }
            return Ok(data);
        }
        // reporte en excel
        [HttpGet]
        public async Task<IActionResult> ExcellistaNominaTotal()
        {
            var dataa = await _DbContext.Nomina_nomina.ToListAsync();

            var nombreArchivo = $"ExcellistaNominaTotal.xlsx";
            return GenerarExcellistaNomina(nombreArchivo, dataa);
        }

        [HttpGet]
        public async Task<IActionResult> ExcellistaNominaActiva()
        {
            var dataa = await _DbContext.Nomina_nomina.Where(u => u.Estado == "Activo").ToListAsync();
            var nombreArchivo = $"ExcellistaNominaActiva.xlsx";
            return GenerarExcellistaNomina(nombreArchivo, dataa);

        }
        [HttpGet]
        public async Task<IActionResult> ExcellistaNominaInactivos()
        {
            var dataa = await _DbContext.Nomina_nomina.Where(u => u.Estado == "Inactivo").ToListAsync();

            var nombreArchivo = $"ExcellistaNominaInactivos.xlsx";
            return GenerarExcellistaNomina(nombreArchivo, dataa);
        }
        private FileResult GenerarExcellistaNomina(string nombreArchivo, IEnumerable<Models.NominaApp.Nomina_nomina> dataa)
        {
            DataTable dataTable = new("dataa");
            dataTable.Columns.AddRange(new DataColumn[] {
                new DataColumn("Nombre"),
                new DataColumn("Apellido"),
                new DataColumn("Tipo_de_documento"),
                new DataColumn("Numero_identificacion"),
                new DataColumn("Correo_electronico"),
                new DataColumn("Direccion"),
                new DataColumn("Telefono"),
                new DataColumn("Sede"),
                new DataColumn("Cargo"),
                new DataColumn("Estado"),
                new DataColumn("ValorSueldo"),
                new DataColumn("Liquidado"),
                new DataColumn("Informacion_completa"),
                 new DataColumn("SedeSecundaria"),
                  new DataColumn("Observaciones")
               });

            foreach (var dat in dataa)
            {
                dataTable.Rows.Add(dat.Nombre,
                    dat.Apellido,
                    dat.Tipo_de_documento,
                    dat.Numero_identificacion,
                    dat.Correo_electronico,
                    dat.Direccion,
                    dat.Telefono,
                    dat.Sede,
                    dat.Cargo,
                    dat.Estado,
                    dat.ValorSueldo,
                    dat.Liquidado,
                    dat.Informacion_completa,
                    dat.SedeSecundaria,
                    dat.Observaciones
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

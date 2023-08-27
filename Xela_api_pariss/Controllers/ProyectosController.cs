using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xela_api_pariss.Models.Correpondenciabd;
using Xela_api_pariss.Models.DbCafesalud;
using Xela_api_pariss.Models.ProyectosApp;
//using Xela_api_pariss.Servicios;

namespace Xela_api_pariss.Controllers
{
    public class ProyectosController : Controller
    {
        private readonly ProyectosAppContext _DbContext;
        public ProyectosController(ProyectosAppContext dbContext)
        {
            _DbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Buscarcontratante([FromBody] Nomina_nomina modelo ) {
            var data = await _DbContext.Proyecto_proyectos.Where(s => s.NitContratante == modelo.NitContratante).FirstOrDefaultAsync();
            if (data == null)
            {
            return Ok("sininformacion");  
            }
            return Ok(data);    

        }
        [HttpPost]
        public async Task<IActionResult> Insertproyecto([FromBody] Nomina_nomina modelo) {
            try
            {
                if (ModelState.IsValid)
                {
                    _DbContext.Proyecto_proyectos.Add(modelo);
                    await _DbContext.SaveChangesAsync();
                    return Ok("Proyectoinsertadocorrectamente");
                }

                return BadRequest("No fue posible insertar el proyecto!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "sininformacion" + ex.Message);
            }

        }
       
    }
}

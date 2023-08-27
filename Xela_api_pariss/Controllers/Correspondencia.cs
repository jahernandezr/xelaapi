using DocumentFormat.OpenXml.Office2010.CustomUI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Net.WebSockets;
using Xela_api_pariss.Models;
using Xela_api_pariss.Models.Correpondenciabd;

namespace Xela_api_pariss.Controllers
{
    public class Correspondencia : Controller
    {
        private readonly Correspondencia_dbContext _DbContext;

        public Correspondencia(Correspondencia_dbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetSolicitudes()
        {
            var Solicitudestado = await _DbContext.TutSolicitudesEstados.ToListAsync();
            if (Solicitudestado is null)
            {
                return NotFound();
            }
            return Ok(Solicitudestado);
        }
        [HttpGet]
        public async Task<IActionResult> GetResponsables()
        {
            var Solicitudestado = await _DbContext.TutResponsablesEstados.ToListAsync();
            if (Solicitudestado is null)
            {
                return NotFound();
            }
            return Ok(Solicitudestado);
        }

        [HttpPost]
        public async Task<IActionResult> PostSolicitudes([FromBody] int? IdPreradicado)
        {

            var idpreradicado = await _DbContext.TutSolicitudes.Where(s => s.IdPreradicado == IdPreradicado).FirstOrDefaultAsync();
            if (idpreradicado == null)
            {
                return NotFound();
            }

            return Ok(idpreradicado);
        }
        [HttpPost]
        public async Task<IActionResult> PostSolicitudesEstado([FromBody] Sp_UpdateEstSoli modelo)
        {
            if (!ModelState.IsValid)
            {
                return Json("No se actualizo");
            }
            var res = await _DbContext.Database.ExecuteSqlInterpolatedAsync($@"
                exec Sp_UpdateEstSoli @IdEstado= {modelo.id_estado} , @IdPreradicado = {modelo.id_preradicado}");

            return Ok(res);


        }

        [HttpPost]
        public async Task<IActionResult> ExeSp_updateEstResponsable([FromBody] Sp_updateEstResponsable modelo)
        {
            if (!ModelState.IsValid)
            { return Json("No se Actualizo"); }

           var res= await _DbContext.Database.ExecuteSqlInterpolatedAsync($@"
                  exec  Sp_updateEstResponsable @id_solicitud={modelo.id_solicitud}, @id_estado={modelo.id_estado}
            ");
            return Ok(res);
        }

        [HttpPost]
        public IActionResult SelectVw_seg_usuarios([FromBody] Vw_seg_usuarios modelo)
        {
            var data =  from Vw_seg_usuarios in _DbContext.Vw_seg_usuarios select Vw_seg_usuarios;
            if (data == null)
            {
                return Ok("No  hay considencias");
            }
            data =  data.Where(u => u.nombres!.Contains(modelo.nombres));

            return Ok(data);

        }

    }
}
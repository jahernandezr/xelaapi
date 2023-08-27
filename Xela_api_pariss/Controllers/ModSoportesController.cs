using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using DocumentFormat.OpenXml.EMMA;
using Xela_api_pariss.Models.ProyectosApp;

namespace Xela_api_pariss.Controllers
{
    public class ModSoportesController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public ModSoportesController(IWebHostEnvironment env)
        {
            _environment = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        // GET: Soportes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload([Bind("CorreoContratante,TipoSoporte,ObservacionSoporte,NombreImg")] Proyecto_soportes soportes)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using var db = new ProyectosAppContext();

                    if (soportes.NombreImg != null && soportes.NombreImg.Length > 0)
                    {
                        var uploadsFolder = Path.Combine(_environment.WebRootPath, "wwwroot/Uploads");
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(soportes.NombreImg.FileName);
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await soportes.NombreImg.CopyToAsync(fileStream);
                        }

                        var newSoporte = new Proyecto_soportes
                        {
                            CorreoContratante = soportes.CorreoContratante,
                            NombreImg2 = filePath,
                            TipoSoporte = soportes.TipoSoporte,
                            ObservacionSoporte = soportes.ObservacionSoporte,
                        };

                        db.Add(newSoporte);
                        await db.SaveChangesAsync();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("NombreImg", "Por favor, seleccione un archivo");
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    // Por ejemplo, puedes agregar un registro de excepción o redirigir a una página de error
                    return RedirectToAction("Index");
                }
            }

            return View(soportes); // Regresar a la vista con errores de validación
        }
        //[HttpPost]
        //public JsonResult BuscarsoporteEquipo([FromBody] Soportes2 soportes2)
        //{
        //    using var db = new aplicacionesNetContext();
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var soporte = (
        //                from s in db.Soportes2s
        //                where s.IdEquipo == soportes2.IdEquipo
        //                select s
        //                ).ToList();

        //            return Json(new { soporte });
        //        }
        //        return Json("no");

        //    }
        //}
    }
}

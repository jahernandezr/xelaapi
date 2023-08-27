using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Vml.Office;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Win32;
using NuGet.Protocol;
using System;
//using Xela_api_pariss.Models.CafesaludSYC;
//using Xela_api_pariss.Models.Correpondenciabd;
using Xela_api_pariss.Models.DbCafesalud;

namespace Xela_api_pariss.Controllers
{
    public class CafesaludSYCController : Controller
    {
        private readonly DB_CAFESALUDContext _DbContext;

        public CafesaludSYCController(DB_CAFESALUDContext dbContext)
        {
            _DbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
      //  [AllowAnonymous]
        public async Task<IActionResult> ConsultarprocedCYS([FromBody] VwImagCYS modelo) {

            var data = await _DbContext.VwImagCYS.Where(v =>
                            v.ndoc_pac == modelo.ndoc_pac ||
                            v.num_fact == modelo.num_fact ||
                            v.num_doc_ips == modelo.num_doc_ips ||
                            v.nume_rad == modelo.nume_rad ||
                            v.fech_ing == modelo.fech_ing ||
                            v.fech_sal == modelo.fech_sal
                        ).ToListAsync();

            if (data == null)
            {
                return Json("Sin Informacion");
            }
            return Ok(data);

        }
        [HttpPost]
        public async Task<IActionResult> ConsultarprocedCYSsp([FromBody] VwImagCYS modelo)
        {
            //var res = await _DbContext.Database.ExecuteSqlInterpolatedAsync
            //($@"
            //exec Sp_ImgSYC @ndoc_pac={modelo.ndoc_pac} ,  @fech_ing={modelo.fech_ing} , @fech_sal={modelo.fech_sal} ,@nume_rad={modelo.nume_rad}, @num_doc_ips={modelo.num_doc_ips}, @num_fact={modelo.num_fact}
            //")  ;
            //este codigo evita inyeccion de sql
            var res = await _DbContext.VwImagCYS
                        .FromSqlRaw("exec Sp_ImgSYC @ndoc_pac, @fech_ing, @fech_sal, @nume_rad, @num_doc_ips, @num_fact",
                            new SqlParameter("@ndoc_pac", modelo.ndoc_pac),
                            new SqlParameter("@fech_ing", modelo.fech_ing),
                            new SqlParameter("@fech_sal", modelo.fech_sal),
                            new SqlParameter("@nume_rad", modelo.nume_rad),
                            new SqlParameter("@num_doc_ips", modelo.num_doc_ips),
                            new SqlParameter("@num_fact", modelo.num_fact))
                        .ToListAsync();

            return Ok(res);
        }

       [HttpPost]
        public async Task<IActionResult> ConsultarprocedCYSsp2([FromBody] VwImagCYS modelo)
        {
            var res = await _DbContext.VwImagCYS.FromSqlRaw("exec Sp_ImgSYC @ndoc_pac",
                new SqlParameter("@ndoc_pac", modelo.ndoc_pac)
            ).ToListAsync();

            if (res == null)
            {
                return Json("Sin Informacion");
            }
            return Ok(res);
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarprocedCYSsp3([FromBody] VwImagCYS modelo)
        {
            var res = await _DbContext.VwImagCYS.FromSqlRaw("exec Sp_ImgSYCnume_rad @nume_rad",
                new SqlParameter("@nume_rad", modelo.nume_rad)
            ).ToListAsync();


            if (res == null)
            {
                return Json("Sin Informacion");
            }

            return Ok(res);
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarprocedCYSsp4([FromBody] VwImagCYS modelo)
        {
            var res = await _DbContext.VwImagCYS.FromSqlRaw("exec Sp_ImgSYCid_rad @id_rad",
                new SqlParameter("@id_rad", modelo.id_rad)
            ).ToListAsync();

            if (res == null)
            {
                return Json("Sin Informacion");
            }

            return Ok(res);
        }
        [HttpPost]
        public async Task<IActionResult> ConsultarprocedCYSsp5([FromBody] VwImagCYS modelo)
        {
            var res = await _DbContext.VwImagCYS.FromSqlRaw("exec Sp_ImgSYCnum_fact @num_fact",
                new SqlParameter("@num_fact", modelo.num_fact)
            ).ToListAsync();


            if (res == null)
            {
                return Json("Sin Informacion");
            }

            return Ok(res);
        }
        [HttpPost]
        public async Task<IActionResult> TraerImagen([FromBody]  VWcatalogos modelo)
        {
            var res = await _DbContext.VWcatalogos.FromSqlRaw("exec SP_catalogos @id_rad",
                new SqlParameter("@id_rad", modelo.id_rad)
            ).ToListAsync();


            if (res == null)
            {
                return Json("Sin Informacion");
            }

            return Ok(res);
        }
    }
}

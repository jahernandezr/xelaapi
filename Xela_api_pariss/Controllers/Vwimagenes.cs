using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Xela_api_pariss.Controllers;
using Xela_api_pariss.Models.Svportalreal;

namespace Xela_api_pariss.Controllers
{
    public class Vwimagenes : Controller
    {
        private readonly PortalRealContext _DbContext;

        public Vwimagenes(PortalRealContext dbContext)
        {
            _DbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PosConsultaDocImagen([FromBody] SP_ImagenesBit modelo)
        {
            var resultado = await _DbContext.Database.ExecuteSqlInterpolatedAsync(
                $@"exec SP_ImagenesBit IdentificationNumber = {modelo.IdentificationNumber}" );
           
            return Ok(resultado);
        }
    }
}



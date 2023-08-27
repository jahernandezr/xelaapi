using DocumentFormat.OpenXml.Drawing;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Runtime.InteropServices;
//using Wkhtmltopdf.NetCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;
//using Wkhtmltopdf.NetCore;
using Xela_api_pariss;
//using Xela_api_pariss.Models.CafesaludSYC;
using Xela_api_pariss.Models.Correpondenciabd;
using Xela_api_pariss.Models.DbCafesalud;
using Xela_api_pariss.Models.ProyectosApp;
using Xela_api_pariss.Models.Svportalreal;
using Xela_api_pariss.Models.NominaApp;
//using Xela_api_pariss.Servicios;


//using Xela_api_pariss.Models.correspondencia;


var builder = WebApplication.CreateBuilder(args);

var politicaUsuariosAutenticados = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();

// Add services to the container.

builder.Services.AddControllersWithViews(opciones =>
{
    opciones.Filters.Add(new AuthorizeFilter(politicaUsuariosAutenticados));
});

builder.Services.AddDbContext<ApplicacionDbContext>(opciones =>
opciones.UseSqlServer("name = DefaultConnection")) ;


builder.Services.AddDbContext<Correspondencia_dbContext>(opciones => 
opciones.UseSqlServer("name = ConnectionCorrespondecia"));

builder.Services.AddDbContext<PortalRealContext>(opciones => 
opciones.UseSqlServer("name = Connectionsaludvidaaplicaciones"));

builder.Services.AddDbContext<DB_CAFESALUDContext>(opciones =>
opciones.UseSqlServer("name = ConnectioncafeSyc"));

builder.Services.AddDbContext<ProyectosAppContext>(optiones =>
optiones.UseSqlServer("name = ConnectionapiAppNet"));

builder.Services.AddDbContext<NominaAppContext>(optiones =>
optiones.UseSqlServer("name = ConnectionAplicacionesNet"));

builder.Services.AddAuthentication();
builder.Services.AddIdentity<IdentityUser, IdentityRole>(opciones =>
    {
        opciones.SignIn.RequireConfirmedAccount = false;
    }   
).AddEntityFrameworkStores<ApplicacionDbContext>()
 .AddDefaultTokenProviders();

builder.Services.PostConfigure<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme,
    opciones =>
    {
        opciones.LoginPath = "/usuarios/Login";
        opciones.AccessDeniedPath = "/usuarios/Login";
    });

//builder.Services.AddWkhtmltopdf();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuarios}/{action=Login}/{id?}");

IWebHostEnvironment env = app.Environment;
//Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath, "../Rotativa/Windows");

//IWebHostEnvironment env = app.Environment;
//Rotativa.AspNetCore.RotativaConfiguration.Setup(env.WebRootPath, "../Rotativa/Windows");

//Host.CreateDefaultBuilder(args)
//           .ConfigureServices((hostContext, services) =>
//           {
//               // Agregar aquí la configuración de los servicios (inyección de dependencias)
//               services.AddSingleton<GlobasVariable>(); // Ejemplo de servicio singleton

//               // Configurar otros servicios si es necesario
//               // services.AddScoped<MyScopedService>();
//               // services.AddTransient<MyTransientService>();
//           });

app.Run();

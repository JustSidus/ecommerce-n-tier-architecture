using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Usuarios.Datos;
using Usuarios.Entidades;
using Usuarios.Negocio;
using Usuarios.Presentacion.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc.RazorPages;

var builder = WebApplication.CreateBuilder(args);

// Identity
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<Usuarios.Datos.AplicacionDbContext>();

// Configura la conexión a la base de datos SQL Server
builder.Services.AddDbContext<Usuarios.Datos.AplicacionDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL")));

// Inyecta los servicios personalizados de la app
builder.Services.AddScoped<IPersonaRepositorio, PersonaRepositorio>();
builder.Services.AddScoped<PersonaServicio>();

// Habilita controladores con vistas (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuración del pipeline de la app
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

public class LoginModel : PageModel
{
    private readonly SignInManager<ApplicationUser> _signInManager;
}

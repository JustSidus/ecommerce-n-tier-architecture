using Microsoft.EntityFrameworkCore;
using Usuarios.Datos;
using Usuarios.Negocio;

var builder = WebApplication.CreateBuilder(args);

// 👇 Configura la conexión a la base de datos SQL Server
builder.Services.AddDbContext<AplicacionDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL")));

// 👇 Inyecta los servicios personalizados de la app
builder.Services.AddScoped<IPersonaRepositorio, PersonaRepositorio>();
builder.Services.AddScoped<PersonaServicio>();

// 👇 Habilita controladores con vistas (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 👇 Configuración del pipeline de la app
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

app.Run();

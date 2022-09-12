using Microsoft.EntityFrameworkCore;
using WebApplicationProyectoFinal.Data;
using WebApplicationProyectoFinal.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Inyeccion de dependencias
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<StoreServices>();

//Configuracion de la base de datos
builder.Services.AddDbContext<WebApplicationProyectoFinalDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebConnectionString")));//

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

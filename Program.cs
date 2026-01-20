using SistemaAcademico.AccesoDatos;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorio;
using SistemaAcademico.Servicios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Repo genérico
builder.Services.AddScoped(typeof(IRepositorio<>), typeof(RepositorioCrudJson<>));

// Acceso a datos con factory (ACÁ estaba el bug)
builder.Services.AddScoped<IAccesoDatos<Libro>>(
    _ => new AccesoDatosJson<Libro>("libros")
);

builder.Services.AddScoped<IAccesoDatos<Autor>>(
    _ => new AccesoDatosJson<Autor>("autores")
);

// Servicios
builder.Services.AddScoped<ServicioLibro>();
builder.Services.AddScoped<ServicioAutor>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();
app.Run();

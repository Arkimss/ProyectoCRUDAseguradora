
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Repositorios;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddTransient<AgregarTitularUseCase>();
builder.Services.AddTransient<AgregarVehiculoUseCase>();
builder.Services.AddTransient<AgregarPolizaUseCase>();
builder.Services.AddTransient<AgregarSiniestroUseCase>();
builder.Services.AddTransient<AgregarTercerosUseCase>();

builder.Services.AddTransient<ListarTitularesUseCase>();
builder.Services.AddTransient<ListarVehiculosDeTitularesUseCase>();
builder.Services.AddTransient<ListarVehiculosUseCase>();
builder.Services.AddTransient<ListarPolizasUseCase>();
builder.Services.AddTransient<ListarSiniestrosUseCase>();
builder.Services.AddTransient<ListarTercerosUseCase>();

builder.Services.AddTransient<ModificarTitularUseCase>();
builder.Services.AddTransient<ModificarVehiculoUseCase>();
builder.Services.AddTransient<ModificarPolizaUseCase>();
builder.Services.AddTransient<ModificarSiniestroUseCase>();
builder.Services.AddTransient<ModificarTerceroUseCase>();

builder.Services.AddTransient<EliminarTitularUseCase>();
builder.Services.AddTransient<EliminarVehiculoUseCase>();
builder.Services.AddTransient<EliminarPolizaUseCase>();
builder.Services.AddTransient<EliminarSiniestroUseCase>();
builder.Services.AddTransient<EliminarTerceroUseCase>();

builder.Services.AddTransient<ObtenerTitularUseCase>();
builder.Services.AddTransient<ObtenerVehiculoUseCase>();
builder.Services.AddTransient<ObtenerPolizaUseCase>();
builder.Services.AddTransient<ObtenerSiniestroUseCase>();
builder.Services.AddTransient<ObtenerTerceroUseCase>();



builder.Services.AddScoped<IRepositorioTitular, RepositorioTitular>();
builder.Services.AddScoped<IRepositorioVehiculo, RepositorioVehiculo>();
builder.Services.AddScoped<IRepositorioPoliza, RepositorioPoliza>();
builder.Services.AddScoped<IRepositorioSiniestro, RepositorioSiniestro>();
builder.Services.AddScoped<IRepositorioTerceros, RepositorioTercero>();


CreadorDeBaseDeDatos.CrearAseguradora();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();




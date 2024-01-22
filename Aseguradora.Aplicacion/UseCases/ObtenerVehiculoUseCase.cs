using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ObtenerVehiculoUseCase : VehiculoUseCase
{
    public ObtenerVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
    {
    }
    public Vehiculo? Ejecutar(int id)
    {
        return Repositorio.ObtenerVehiculo(id);
    }
}
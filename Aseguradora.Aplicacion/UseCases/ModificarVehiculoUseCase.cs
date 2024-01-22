using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ModificarVehiculoUseCase : VehiculoUseCase
{
    public ModificarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(Vehiculo Vehiculo)
    {
        Repositorio.ModificarVehiculo(Vehiculo);
    }
}
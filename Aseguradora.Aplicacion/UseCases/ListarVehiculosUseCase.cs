using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ListarVehiculosUseCase : VehiculoUseCase
{
    public ListarVehiculosUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
    {
    }
    public List<Vehiculo> Ejecutar()
    {
        return Repositorio.ListarVehiculos();
    }
}
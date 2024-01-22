using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioVehiculo
{
    void AgregarVehiculo(Vehiculo vehiculos);
    List<Vehiculo> ListarVehiculos();

    void ModificarVehiculo(Vehiculo vehiculo);
    Vehiculo? ObtenerVehiculo(int Id);
    void EliminarVehiculo(int IdT);

}
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioTitular
{
    void AgregarTitular(Titular titular);
    List<Titular> ListarTitulares();

    void ModificarTitular(Titular titular);

    void EliminarTitular(int idT);

    Titular? ObtenerTitular(int id);

    List<Titular> ListarVehiculosDeTitulares();
}



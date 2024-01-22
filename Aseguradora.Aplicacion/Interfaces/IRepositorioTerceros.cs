using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioTerceros
{
    void AgregarTercero(Terceros titular);
    List<Terceros> ListarTerceros();

    void ModificarTerceros(Terceros tercero);

    void EliminarTerceros(int idT);

    Terceros? ObtenerTerceros(int id);
}



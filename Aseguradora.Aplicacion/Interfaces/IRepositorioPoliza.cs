using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioPoliza
{
    void AgregarPoliza(Poliza poliza);
    List<Poliza> ListarPolizas();

    void ModificarPoliza(Poliza poliza);

    void EliminarPoliza(int idT);

    Poliza? ObtenerPoliza(int id);
}



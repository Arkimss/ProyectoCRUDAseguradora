using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioSiniestro
{
    void AgregarSiniestro(Siniestro siniestro);
    List<Siniestro> ListarSiniestros();

    void ModificarSiniestro(Siniestro siniestro);

    void EliminarSiniestro(int idS);

    Siniestro? ObtenerSiniestro(int id);
}



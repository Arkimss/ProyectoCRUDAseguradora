using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class EliminarTerceroUseCase : TerceroUseCase
{
    public EliminarTerceroUseCase(IRepositorioTerceros repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(int idT)
    {
        Repositorio.EliminarTerceros(idT);
    }
}
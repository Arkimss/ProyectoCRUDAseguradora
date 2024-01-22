using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public abstract class TerceroUseCase
{
    protected IRepositorioTerceros Repositorio { get; private set; }
    public TerceroUseCase(IRepositorioTerceros repositorio)
    {
        this.Repositorio = repositorio;
    }
}
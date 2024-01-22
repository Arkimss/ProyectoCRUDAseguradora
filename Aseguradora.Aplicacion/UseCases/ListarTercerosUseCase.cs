using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ListarTercerosUseCase : TerceroUseCase
{
    public ListarTercerosUseCase(IRepositorioTerceros repositorio) : base(repositorio)
    {
    }
    public List<Terceros> Ejecutar()
    {
        return Repositorio.ListarTerceros();
    }
}
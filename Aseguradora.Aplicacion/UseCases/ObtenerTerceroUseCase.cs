using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ObtenerTerceroUseCase : TerceroUseCase
{
    public ObtenerTerceroUseCase(IRepositorioTerceros repositorio) : base(repositorio)
    {
    }
    public Terceros? Ejecutar(int id)
    {
        return Repositorio.ObtenerTerceros(id);
    }
}
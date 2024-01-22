using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ModificarTerceroUseCase : TerceroUseCase
{
    public ModificarTerceroUseCase(IRepositorioTerceros repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(Terceros tercero)
    {
        Repositorio.ModificarTerceros(tercero);
    }
}
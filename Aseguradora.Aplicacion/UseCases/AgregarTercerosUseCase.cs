using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class AgregarTercerosUseCase : TerceroUseCase
{
    public AgregarTercerosUseCase(IRepositorioTerceros repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(Terceros terceros)
    {
        Repositorio.AgregarTercero(terceros);
    }
}
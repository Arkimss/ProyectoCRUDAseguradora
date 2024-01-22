using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ModificarPolizaUseCase : PolizaUseCase
{
    public ModificarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(Poliza poliza)
    {
        Repositorio.ModificarPoliza(poliza);
    }
}
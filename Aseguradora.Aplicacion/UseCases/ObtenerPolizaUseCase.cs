using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ObtenerPolizaUseCase : PolizaUseCase
{
    public ObtenerPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
    {
    }
    public Poliza? Ejecutar(int id)
    {
        return Repositorio.ObtenerPoliza(id);
    }
}
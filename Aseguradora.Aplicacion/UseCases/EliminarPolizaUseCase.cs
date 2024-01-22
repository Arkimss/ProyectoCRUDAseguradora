using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class EliminarPolizaUseCase : PolizaUseCase
{
    public EliminarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(int idT)
    {
        Repositorio.EliminarPoliza(idT);
    }
}
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class EliminarTitularUseCase : TitularUseCase
{
    public EliminarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(int idT)
    {
        Repositorio.EliminarTitular(idT);
    }
}
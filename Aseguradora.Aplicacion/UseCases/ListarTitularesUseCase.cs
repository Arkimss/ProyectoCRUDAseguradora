using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ListarTitularesUseCase : TitularUseCase
{
    public ListarTitularesUseCase(IRepositorioTitular repositorio) : base(repositorio)
    {
    }
    public List<Titular> Ejecutar()
    {
        return Repositorio.ListarTitulares();
    }
}
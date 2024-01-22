using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ListarVehiculosDeTitularesUseCase : TitularUseCase
{
    public ListarVehiculosDeTitularesUseCase(IRepositorioTitular repositorio) : base(repositorio)
    {
    }
    public List<Titular> Ejecutar()
    {
        return Repositorio.ListarVehiculosDeTitulares();
    }
}
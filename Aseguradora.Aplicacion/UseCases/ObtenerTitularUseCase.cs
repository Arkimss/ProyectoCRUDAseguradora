using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ObtenerTitularUseCase : TitularUseCase
{
    public ObtenerTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
    {
    }
    public Titular? Ejecutar(int id)
    {
        return Repositorio.ObtenerTitular(id);
    }
}
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ListarSiniestrosUseCase : SiniestroUseCase
{
    public ListarSiniestrosUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
    {
    }
    public List<Siniestro> Ejecutar()
    {
        return Repositorio.ListarSiniestros();
    }
}
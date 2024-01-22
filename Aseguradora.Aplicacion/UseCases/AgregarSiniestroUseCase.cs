using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class AgregarSiniestroUseCase : SiniestroUseCase
{
    public AgregarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(Siniestro siniestro)
    {
        Repositorio.AgregarSiniestro(siniestro);
    }
}
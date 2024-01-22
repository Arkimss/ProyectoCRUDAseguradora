using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ModificarSiniestroUseCase : SiniestroUseCase
{
    public ModificarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(Siniestro siniestro)
    {
        Repositorio.ModificarSiniestro(siniestro);
    }
}
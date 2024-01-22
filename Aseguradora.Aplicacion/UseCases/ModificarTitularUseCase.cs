using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ModificarTitularUseCase : TitularUseCase
{
    public ModificarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
    {
    }
    public void Ejecutar(Titular titular)
    {
        Repositorio.ModificarTitular(titular);
    }
}
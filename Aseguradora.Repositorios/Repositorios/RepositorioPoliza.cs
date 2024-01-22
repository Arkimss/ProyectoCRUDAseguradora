using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Excepciones;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;
public class RepositorioPoliza : IRepositorioPoliza
{
    public void AgregarPoliza(Poliza poliza)
    {
        using (var context = new AseguradoraContext())
        {
            var v = context.Vehiculos.Where(v => v.Id == poliza.VehiculoId).SingleOrDefault();

            if (v != null)
            {
                context.Add(poliza);
                context.SaveChanges();
            }
            else
                throw new PolizaException("El id del vehículo no existe");
        }
    }

    public List<Poliza> ListarPolizas()
    {
        List<Poliza> lista;
        using (var context = new AseguradoraContext())
        {
            lista = context.Polizas.Select(p => p)
                                    .ToList();
        }
        return lista;
    }

    public void ModificarPoliza(Poliza poliza)
    {
        using (var context = new AseguradoraContext())
        {
            var modificar = context.Polizas.Where(p => p.Id == poliza.Id).SingleOrDefault();
            if (modificar != null)
            {
                modificar.VehiculoId = poliza.VehiculoId;
                modificar.ValorAsegurado = poliza.ValorAsegurado;
                modificar.Franquicia = poliza.Franquicia;
                modificar.TipoCobertura = poliza.TipoCobertura;
                modificar.FechaInicioVigencia = poliza.FechaInicioVigencia;
                modificar.FechaFinVigencia = poliza.FechaFinVigencia;
            }
            context.SaveChanges();
        }
    }

    public Poliza? ObtenerPoliza(int id)
    {
        Poliza? poliza = new Poliza();
        using (var context = new AseguradoraContext())
        {
            poliza = context.Polizas.Where(p => p.Id == id).SingleOrDefault();
        }
        return poliza;
    }

    public void EliminarPoliza(int idP)
    {
        using (var context = new AseguradoraContext())
        {
            var eliminar = context.Polizas.Where(p => p.Id == idP).SingleOrDefault();
            if (eliminar != null)
            {
                context.Remove(eliminar);
            }
            context.SaveChanges();
        }
    }

}

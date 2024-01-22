using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;
public class RepositorioSiniestro : IRepositorioSiniestro
{
    public void AgregarSiniestro(Siniestro siniestro)
    {
        using (var context = new AseguradoraContext())
        {
            if (siniestro != null)
            {
                var p = context.Polizas.Where(p => p.Id == siniestro.PolizaId)
                                       .SingleOrDefault();

                if ((p != null) && (EsVigente(p.FechaFinVigencia, siniestro.FechaOcurrencia)))
                {
                    context.Add(siniestro);
                    context.SaveChanges();
                }
            }
        }
    }

    private bool EsVigente(DateTime fechaFinVigencia, DateTime fechaOcurrencia)
    {
        bool res = false;
        if ((fechaFinVigencia.Year > fechaOcurrencia.Year) || ((fechaFinVigencia.Year == fechaOcurrencia.Year) && (fechaFinVigencia.Month > fechaOcurrencia.Month)) || ((fechaFinVigencia.Year == fechaOcurrencia.Year) && (fechaFinVigencia.Month == fechaOcurrencia.Month) && (fechaFinVigencia.Day > fechaOcurrencia.Day)))
            res = true;
        return res;
    }

    public List<Siniestro> ListarSiniestros()
    {
        List<Siniestro> lista;
        using (var context = new AseguradoraContext())
        {
            lista = context.Siniestros.Select(t => t)
                                      .ToList();
        }
        return lista;
    }

    public void ModificarSiniestro(Siniestro siniestro)
    {
        using (var context = new AseguradoraContext())
        {
            var modificar = context.Siniestros.Where(s => s.Id == siniestro.Id)
                                              .SingleOrDefault();
            if (modificar != null)
            {
                modificar.PolizaId = siniestro.PolizaId;
                modificar.FechaIngreso = siniestro.FechaIngreso;
                modificar.FechaOcurrencia = siniestro.FechaOcurrencia;
                modificar.DireccionDelHecho = siniestro.DireccionDelHecho;
                modificar.DescripcionAccidente = siniestro.DescripcionAccidente;

            }
            context.SaveChanges();
        }
    }
    public Siniestro? ObtenerSiniestro(int id)
    {
        Siniestro? siniestro = new Siniestro();
        using (var context = new AseguradoraContext())
        {
            siniestro = context.Siniestros.Where(s => s.Id == id)
                                          .SingleOrDefault();
        }
        return siniestro;
    }
    public void EliminarSiniestro(int idS)
    {
        using (var context = new AseguradoraContext())
        {
            var eliminar = context.Siniestros.Where(s => s.Id == idS)
                                             .SingleOrDefault();
            if (eliminar != null)
            {
                context.Remove(eliminar);
            }
            context.SaveChanges();
        }
    }

}

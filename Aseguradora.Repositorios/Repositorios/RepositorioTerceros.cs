using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Excepciones;

namespace Aseguradora.Repositorios;
public class RepositorioTercero : IRepositorioTerceros
{
    public void AgregarTercero(Terceros tercero)
    {
        using (var context = new AseguradoraContext())
        {
            if (tercero != null)
            {
                var s = context.Siniestros.Where(s => s.Id == tercero.SiniestroId)
                                          .SingleOrDefault();
                if ((s != null))
                {
                    context.Add(tercero);
                    context.SaveChanges();
                }
                else
                    throw new TerceroException("El id del Siniestro no existe");
            }
            else
                throw new TerceroException("no fue posible agregar al tercero");
        }
    }
    public List<Terceros> ListarTerceros()
    {
        List<Terceros> lista;
        using (var context = new AseguradoraContext())
        {
            lista = context.TercerosT.Select(t => t)
                                     .ToList();
        }
        return lista;
    }

    public void ModificarTerceros(Terceros terceros)
    {
        using (var context = new AseguradoraContext())
        {
            var modificar = context.TercerosT.Where(t => t.Id == terceros.Id)
                                             .SingleOrDefault();
            if (modificar != null)
            {
                modificar.SiniestroId = terceros.SiniestroId;
                modificar.Nombre = terceros.Nombre;
                modificar.Apellido = terceros.Apellido;
                modificar.DNI = terceros.DNI;
                modificar.Telefono = terceros.Telefono;
                modificar.NombreAseguradora = terceros.NombreAseguradora;
            }
            context.SaveChanges();
        }
    }
    public Terceros? ObtenerTerceros(int id)
    {
        Terceros? tercero = new Terceros();
        using (var context = new AseguradoraContext())
        {
            tercero = context.TercerosT.Where(t => t.Id == id)
                                       .SingleOrDefault();
        }
        return tercero;
    }
    public void EliminarTerceros(int idT)
    {
        using (var context = new AseguradoraContext())
        {
            var eliminar = context.TercerosT.Where(t => t.Id == idT)
                                            .SingleOrDefault();
            if (eliminar != null)
            {
                context.Remove(eliminar);
            }
            context.SaveChanges();
        }
    }

}

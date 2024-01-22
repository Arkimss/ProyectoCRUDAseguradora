using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Excepciones;
using Aseguradora.Aplicacion.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aseguradora.Repositorios;
public class RepositorioTitular : IRepositorioTitular
{
    public void AgregarTitular(Titular titular)
    {
        using (var context = new AseguradoraContext())
        {
            if (titular != null)
            {
                Titular? existeT = context.Titulares.Where(t => t.DNI == titular.DNI)
                                                    .SingleOrDefault();
                if (existeT == null)
                {
                    context.Add(titular);
                    context.SaveChanges();
                }
                else
                    throw new TitularException("No es Posible agregar el titular");
            }
            else throw new TitularException("No es Posible agregar el titular");
        }
    }
    public List<Titular> ListarVehiculosDeTitulares()
    {
        using (var context = new AseguradoraContext())
        {
            return context.Titulares.Include(t => t.ListaDeVehiculos)
                                    .ToList();
        }
    }

    public List<Titular> ListarTitulares()
    {
        List<Titular> lista;
        using (var context = new AseguradoraContext())
        {
            lista = context.Titulares.Select(t => t)
                                     .ToList();
        }
        return lista;
    }

    public void ModificarTitular(Titular titular)
    {
        using (var context = new AseguradoraContext())
        {
            var modificar = context.Titulares.Where(t => t.DNI == titular.DNI)
                                             .SingleOrDefault();
            if (modificar != null)
            {
                modificar.Apellido = titular.Apellido;
                modificar.Correo = titular.Correo;
                modificar.Nombre = titular.Nombre;
                modificar.Direccion = titular.Direccion;
                modificar.DNI = titular.DNI;
                modificar.Telefono = titular.Telefono;
            }
            context.SaveChanges();
        }
    }
    public Titular? ObtenerTitular(int id)
    {

        Titular? titular = new Titular();
        using (var context = new AseguradoraContext())
        {
            titular = context.Titulares.Where(t => t.Id == id)
                                       .SingleOrDefault();

        }
        return titular;
    }

    public void EliminarTitular(int idT)
    {
        using (var context = new AseguradoraContext())
        {
            var eliminar = context.Titulares.Where(t => t.Id == idT)
                                            .SingleOrDefault();
            if (eliminar != null)
            {
                context.Remove(eliminar);
            }
            context.SaveChanges();
        }
    }

}
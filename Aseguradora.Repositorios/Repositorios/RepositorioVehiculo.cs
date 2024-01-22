using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Excepciones;

namespace Aseguradora.Repositorios;
public class RepositorioVehiculo : IRepositorioVehiculo
{
    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        using (var context = new AseguradoraContext())
        {
            Vehiculo? existeV = context.Vehiculos.Where(v => v.Dominio == vehiculo.Dominio)
                                                 .SingleOrDefault();
            if (existeV == null)
            {
                var t = context.Titulares.Where(t => t.Id == vehiculo.TitularId)
                                         .SingleOrDefault();
                if (t != null)
                {
                    context.Add(vehiculo);
                    t.ListaDeVehiculos.Add(vehiculo);
                    context.SaveChanges();
                }
                else
                    throw new VehiculoException("El id del titular no existe");
            }
            else
                throw new VehiculoException("El dominio del vehiculo ya existe");
        }
    }
    public List<Vehiculo> ListarVehiculos()
    {
        List<Vehiculo> lista;
        using (var context = new AseguradoraContext())
        {
            lista = context.Vehiculos.Select(v => v)
                                     .ToList();
        }
        return lista;
    }

    public void ModificarVehiculo(Vehiculo vehiculo)
    {
        using (var context = new AseguradoraContext())
        {
            var t = context.Titulares.Where(t => t.Id == vehiculo.TitularId)
                                     .SingleOrDefault();
            if (t != null)
            {
                var modificar = context.Vehiculos.Where(v => v.Id == vehiculo.Id)
                                                 .SingleOrDefault();
                if (modificar != null)
                {
                    modificar.Dominio = vehiculo.Dominio;
                    modificar.Marca = vehiculo.Marca;
                    modificar.AnioDeFabricacion = vehiculo.AnioDeFabricacion;
                    modificar.TitularId = vehiculo.TitularId;
                    context.SaveChanges();
                }
                else
                {
                    throw new VehiculoException("El vehiculo no existe");
                }
            }
            else throw new VehiculoException("El id del titular no existe");
        }
    }


    public Vehiculo? ObtenerVehiculo(int id)
    {
        Vehiculo? vehiculo = new Vehiculo();
        using (var context = new AseguradoraContext())
        {
            vehiculo = context.Vehiculos.Where(v => v.Id == id)
                                        .SingleOrDefault();
        }
        return vehiculo;
    }

    public void EliminarVehiculo(int idV)
    {
        using (var context = new AseguradoraContext())
        {
            var eliminar = context.Vehiculos.Where(v => v.Id == idV)
                                            .SingleOrDefault();
            if (eliminar != null)
            {
                context.Remove(eliminar);
            }
            context.SaveChanges();
        }
    }

}

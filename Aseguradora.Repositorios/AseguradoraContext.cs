using Microsoft.EntityFrameworkCore;

namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Entidades;
public class AseguradoraContext : DbContext
{
#nullable disable
    public DbSet<Titular> Titulares { get; set; }

    public DbSet<Poliza> Polizas { get; set; }

    public DbSet<Siniestro> Siniestros { get; set; }

    public DbSet<Vehiculo> Vehiculos { get; set; }

    public DbSet<Terceros> TercerosT { get; set; }


#nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
}


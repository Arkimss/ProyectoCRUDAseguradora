namespace Aseguradora.Aplicacion.Entidades;

public class Siniestro
{
    public int Id { get; set; }
    public int PolizaId { get; set; }
    public DateTime FechaIngreso { get; set; }
    public DateTime FechaOcurrencia { get; set; }
    public string DireccionDelHecho { get; set; } = "";
    public string DescripcionAccidente { get; set; } = "";
    public List<Terceros> ListaDeTerceros { get; set; } = new List<Terceros>();

    public Siniestro()
    {
        FechaIngreso = DateTime.Now;
    }
}

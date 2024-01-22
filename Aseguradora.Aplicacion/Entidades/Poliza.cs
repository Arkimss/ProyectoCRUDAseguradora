namespace Aseguradora.Aplicacion.Entidades;
public class Poliza
{
    public int Id { get; set; }
    public int VehiculoId { get; set; }
    public double ValorAsegurado { get; set; }
    public string Franquicia { get; set; } = "";
    public string TipoCobertura { get; set; } = ""; //Todo riesgo o Responsabilidad Cívil
    public DateTime FechaInicioVigencia { get; set; }
    public DateTime FechaFinVigencia { get; set; }
    public List<Siniestro> Siniestros { get; set; } = new List<Siniestro>();

    public Poliza(int VehiculoId = 0, double ValorAsegurado = 0, string Franquicia = "", string TipoCobertura = "", DateTime FechaInicioVigencia = new DateTime(),
                  DateTime FechaFinVigencia = new DateTime())
    {
        this.VehiculoId = VehiculoId;
        this.ValorAsegurado = ValorAsegurado;
        this.Franquicia = Franquicia;
        this.TipoCobertura = TipoCobertura;
        this.FechaInicioVigencia = FechaInicioVigencia;
        this.FechaFinVigencia = FechaFinVigencia;
    }
    public Poliza()
    {

    }
}
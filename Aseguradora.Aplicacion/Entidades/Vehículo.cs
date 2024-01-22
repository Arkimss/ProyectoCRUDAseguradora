namespace Aseguradora.Aplicacion.Entidades;
public class Vehiculo
{
    public int Id { get; set; }
    public string Dominio { get; set; } = "";
    public string Marca { get; set; } = "";
    public int AnioDeFabricacion { get; set; }
    public int TitularId { get; set; }

    public List<Poliza> ListaDePolizas { get; set; } = new List<Poliza>();


    public override string ToString() => $"ID: {Id}, Dominio: {Dominio}, Marca: {Marca}, Año De Fabricacion: {AnioDeFabricacion}, Id del titular {TitularId}  ";
    public Vehiculo(int anio, string marca)
    {

        AnioDeFabricacion = anio;
        Marca = marca;
    }

    public Vehiculo()
    {
    }


}

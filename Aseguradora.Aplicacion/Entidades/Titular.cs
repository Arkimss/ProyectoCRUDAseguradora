namespace Aseguradora.Aplicacion.Entidades;
public class Titular : Persona
{

    public int Id { get; set; }

    public string Correo { get; set; } = "";

    public string Direccion { get; set; } = "";

    public List<Vehiculo> ListaDeVehiculos { get; set; } = new List<Vehiculo>();
    public Titular()
    {
    }




    public Titular(int dni, string nom, string ape, string tel) : base(dni, nom, ape, tel)
    {
    }
    private string imprimir(int i)
    {
        string aux = ListaDeVehiculos[i].ToString();
        return aux;
    }
    public override string ToString()
    {
        string aux = " ";
        for (int i = 0; i < ListaDeVehiculos.Count; i++)
        {
            aux = aux + $" ID = {Id}, Correo: {Correo}" + base.ToString() + imprimir(i) + "\n";
        }
        return aux;
    }



}
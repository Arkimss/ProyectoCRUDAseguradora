namespace Aseguradora.Aplicacion.Entidades;
public abstract class Persona
{
    public int DNI { get; set; }
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public string Telefono { get; set; } = "";

    protected Persona(int dni, string nom, string ape, string tel)
    {
        DNI = dni;
        Nombre = nom;
        Apellido = ape;
        Telefono = tel;
    }

    protected Persona()
    {
    }

    public override string ToString()
    {
        return $"DNI: {DNI}, Nombre: {Nombre} , Apellido: {Apellido} , Telefono: {Telefono}";
    }
}
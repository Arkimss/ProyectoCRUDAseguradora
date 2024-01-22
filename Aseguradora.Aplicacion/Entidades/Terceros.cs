namespace Aseguradora.Aplicacion.Entidades;

public class Terceros : Persona
{
    public int Id { get; set; }
    public int SiniestroId { get; set; }
    public String NombreAseguradora { get; set; } = "";

    public Terceros()
    {

    }

    public Terceros(int dni, string nom, string ape, string tel) : base(dni, nom, ape, tel)
    {
    }
}
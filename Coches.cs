abstract class Coches
{
    protected string fabricante;
    protected int anyo;
    protected string modelo;

    public Coches(string fabricante, int anyo, string modelo)
    {
        this.fabricante = fabricante;
        this.anyo = anyo;
        this.modelo = modelo;
    }

    public abstract string Descripcion();
}
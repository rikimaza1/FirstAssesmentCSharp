class Ford : Coches
{
    private string color;

    public Ford(string fabricante, int anyo, string modelo, string color) : base(fabricante, anyo, modelo)
    {
        this.color = color;
    }

    public override string Descripcion()
    {
        return $"El {modelo} de color {color} fabricado en {anyo} por {fabricante}.";
    }
}
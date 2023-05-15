class Toyota : Coches
{
    private int num_puertas;

    public Toyota(string fabricante, int anyo, string modelo, int num_puertas) : base(fabricante, anyo, modelo)
    {
        this.num_puertas = num_puertas;
    }

    public override string Descripcion()
    {
        return $"El {modelo} de {num_puertas} puertas fabricado en {anyo} por {fabricante}.";
    }
}
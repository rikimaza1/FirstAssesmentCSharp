class Honda : Coches
{
    private string tipo_transmision;

    public Honda(string fabricante, int anyo, string modelo, string tipo_transmision) : base(fabricante, anyo, modelo)
    {
        this.tipo_transmision = tipo_transmision;
    }

    public override string Descripcion()
    {
        return $"El {modelo} con transmisión {tipo_transmision} fabricado en {anyo} por {fabricante}.";
    }
}
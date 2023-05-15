## Escenario de Marcas de Coche: Código 07

Usted ha sido contratado para trabajar como `python developer` en una empresa local de su ciudad.

El negocio central es la comercialización de coches:

Usted iniciará un proyecto que incluirá la elaboración de `site` en Internet para la gestión de las coches.

Las coches que se comercializan son Ford, Toyota y Honda, pero próximamente se añadirán mas variedades a la comercialización según como vayan siendo cerrados acuerdos con los diferentes fabricantes.

Debe crear el proyecto de iniciación para comenzar a desarrollar en las siguientes jornadas toda la aplicación.

Hoy deberá entregar la validación de funcionalidad, con la jerarquía de clases, y con el funcionamiento de una aplicación de consola; incluyendo toda la información proporcionada en este documento. Y completarlas según las instrucciones recibidas.

- Jerarquía de clases

```
Marcas de coches: Ford, Toyota, Honda.
```

``` CSharp
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
```

####  Aplicación principal

```CSharp
Write("Introduce el fabricante: ");
string? fabricante = ReadLine();

Write("Introduce el año de fabricación: ");
int anyo = 0;
Int32.TryParse(ReadLine(),out anyo);

Write("Introduce el modelo: ");
string? modelo = ReadLine();

Coches? coche = null;

if (fabricante == "Ford")
{
    Write("Introduce el color: ");
string? color = ReadLine();

    coche = new Ford(fabricante, anyo, modelo!, color!);
}
else if (fabricante == "Toyota")
{
    Write("Introduce número de puertas:");
    int numeroPuertas = 0;
    Int32.TryParse(ReadLine(),out numeroPuertas);

    coche = new Toyota(fabricante, anyo, modelo!, numeroPuertas);
}
else if(fabricante == "Honda")
{
    Write("Introduce el tipo de transmision");
    string? tipoTransmision = ReadLine();
    coche = new Honda(fabricante, anyo, modelo!,tipoTransmision!);
}
else
WriteLine("Selección de coche incorrecto!");

if (coche!=null)
    WriteLine(coche.Descripcion());
WriteLine("Entre cualquier tecla");
ReadKey();
```




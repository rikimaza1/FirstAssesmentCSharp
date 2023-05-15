using static System.Console;
Write("Introduce el fabricante: ");
string? fabricante = ReadLine();

Write("Introduce el año de fabricación: ");
int anyo = 0;
Int32.TryParse(ReadLine(), out anyo);

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
    Int32.TryParse(ReadLine(), out numeroPuertas);

    coche = new Toyota(fabricante, anyo, modelo!, numeroPuertas);
}
else if (fabricante == "Honda")
{
    Write("Introduce el tipo de transmision");
    string? tipoTransmision = ReadLine();
    coche = new Honda(fabricante, anyo, modelo!, tipoTransmision!);
}
else
    WriteLine("Selección de coche incorrecto!");

if (coche != null)
    WriteLine(coche.Descripcion());
WriteLine("Entre cualquier tecla");
ReadKey();
using System.Timers;

int filas = 0;
int columnas = 0;
int valor = 0;
int mas = 1;
int buscar = 0;
int noaparece = 0;

Console.WriteLine("Ingrese Cuantas filas quiere");
Console.WriteLine();
while (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
{
    Console.WriteLine("");
    Console.WriteLine("Dato no válido");
    Console.WriteLine();
}
Console.WriteLine("");
Console.WriteLine("Ingrese Cuantas Columnas quiere");
Console.WriteLine();
while (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
{
    Console.WriteLine("");
    Console.WriteLine("Dato no válido");
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Presione ENTER para continuar");
Console.WriteLine();
Console.ReadLine();
Console.Clear();
Console.WriteLine();
int[,] numeros = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.WriteLine();
        Console.WriteLine($"Ingrese el {mas}° valor");
        Console.WriteLine();
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine();
            Console.WriteLine("Dato no válido");
            Console.WriteLine();
        }
        numeros[i, j] = valor;
        mas++;
        ;
    }
}
Console.WriteLine();
Console.WriteLine("Presione ENTER para continuar");
Console.WriteLine();
Console.ReadLine();
Console.Clear();
Console.WriteLine();
Console.WriteLine("Ingrese un número para buscar dentro de la matriz");
Console.WriteLine();
while (!int.TryParse(Console.ReadLine(), out buscar))
{
    Console.WriteLine();
    Console.WriteLine("Dato no válido");
    Console.WriteLine();
}

for  (int i = 0; i < filas; i++)
{
    for (int j = 0;j < columnas; j++)
    {
        if (numeros[i,j]==buscar)
        {
            Console.WriteLine();
            Console.WriteLine($"El número {buscar} aparece en la posición [{i}, {j}]");
            Console.WriteLine();
            noaparece++;
        }
    }
}

if (noaparece == 0)
{
    Console.WriteLine();
    Console.WriteLine("El número no aparece en la matriz");
    Console.WriteLine();
}
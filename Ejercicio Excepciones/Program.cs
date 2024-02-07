
using System.Numerics;

FileStream file = null;
try
{
    double n1, n2, division;

    Console.WriteLine("Ingrese primer número:");
    n1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese segundo número:");
    n2 = double.Parse(Console.ReadLine());

    division = n1 / n2;

    Console.WriteLine($"La división es: {division}");

    file = File.Open("archivo.txt", FileMode.Open);
} catch (Exception e)
{
    Console.WriteLine(e.Message);
} finally { 
    file?.Close();
    Console.WriteLine("Se ha cerrado el archivo correctamente");
}
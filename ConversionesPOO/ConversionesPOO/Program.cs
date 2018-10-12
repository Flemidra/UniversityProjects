using System;

internal class Conversion
{
    private double pulgadas, pies, yardas, centimetros, metros, resultados;
    public void Conversiones()
    {
    }
    public void Setpulgadas(float number)
    {
        pulgadas = number;

    }

    public void Calcpies()
    {
        resultados = (pulgadas * 0.0833);
        Console.WriteLine("El resultado es: " + resultados + " Pies");
    }

    public void Calcyardas()
    {
        resultados = (pulgadas * 0.277778);
        Console.WriteLine("El resultado es: " + resultados + " Yardas");
    }

    public void Calccentimetros()
    {
        resultados = (pulgadas * 2.54);
        Console.WriteLine("El resultado es: " + resultados + " Centimetros");
    }

    public void Calcmetros()
    {
        resultados = (pulgadas * 0.0254);
        Console.WriteLine("El resultado es: " + resultados + " Metros");
    }
}
namespace ConversionesPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el valor de pulgadas");
            var number = Convert.ToSingle(Console.ReadLine());
            Conversion conversor = new Conversion();
            conversor.Setpulgadas(number);
            conversor.Calcpies();
            conversor.Calccentimetros();
            conversor.Calcmetros();
            conversor.Calcyardas();
            Console.ReadKey();
        }
    }
}

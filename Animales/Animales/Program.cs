using System;
internal class Animal
{
    private string nombre, especie, raza;
    private float peso;

    public Animal()
    {
        Console.WriteLine("Ingrese el nombre del animal");
        nombre  = Console.ReadLine();
        Console.WriteLine("Ingrese la especie del animal");
        especie = Console.ReadLine();
        Console.WriteLine("Ingrese la raza  del animal");
        raza = Console.ReadLine();
        Console.WriteLine("Ingrese el peso del animal");
        peso = Convert.ToSingle(Console.ReadLine());
    }

    public void PrintInfo()
    {
        Console.WriteLine("El nombre del animal es: " + nombre);
        Console.WriteLine("La especie del animal es: " + especie);
        Console.WriteLine("La raza del animal es: " + raza);
        Console.WriteLine("El peso del animal es: " + peso);
    }
}

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal An = new Animal();          
            An.PrintInfo();
            Console.ReadKey();
        }
    }
}

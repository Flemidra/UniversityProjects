using System;

namespace Practica2
{
    internal class Program
    {
        private static void Main()
        {
            var na = new NuevoArchivo("C:\\POO\\archivo-nuevo.txt");
            na.CrearArchivo();
            Console.WriteLine();
            Console.ReadKey();
            na.Adicionar();
        }
    }
}

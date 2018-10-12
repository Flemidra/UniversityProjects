using System;
using System.Runtime.CompilerServices;

namespace Impresion
{
    class Program
    {
        static void Main(string[] args)
        {
            var aux = 1;
            Console.WriteLine("Escribe un numero de lineas");
            var escalera = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < escalera; i++)
            {
                for (int j = 0; j < aux; j++)
                {
                    Console.Write('*');   
                }
                aux++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

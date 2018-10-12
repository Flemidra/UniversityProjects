using System;

namespace Practica
{
    internal class Program
    {
        private static void Main()
        {
            Comida com = new Comida("Mexicana", 1000.0, 4);
            com.Informacion();
            Console.WriteLine();
            Console.WriteLine("########################################################");
            Console.WriteLine();
            Mexicana mex = new Mexicana("Mexicana", 1000.0, 4, "Centro", 200);
            mex.Informacion();
            mex.ImprimirInformacion();
            Console.ReadKey();
        }
    }
}

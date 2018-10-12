using System;

namespace PerfectNumber
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Ingrese un numero para saber si es perfecto.");
            var perfectAux = Console.ReadLine();
            if (!String.IsNullOrEmpty(perfectAux))
            {
                var perfectObject = new PerfectClass(Convert.ToInt32(perfectAux));
            }
            else
            {
                var perfectObject = new PerfectClass();
            }
            Console.ReadKey();
        }
    }
}

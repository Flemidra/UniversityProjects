using System;

namespace DecimalToRomanNumber
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Ingrese un numero romano que desee convertir a decimal.");
            var rNumber = Console.ReadLine();
            if (!string.IsNullOrEmpty(rNumber))
            {
                var newNumberConverter = new Converter(rNumber);
                Console.Clear();
                Console.WriteLine("El numero romano introducido es: " + rNumber);
                Console.WriteLine("Y su equivalente arabico es: " + newNumberConverter.ToDecimal());
            }
            else
            {
                Console.WriteLine("El numero romano no puede estar en blanco.");
            }
            Console.ReadKey();
        }
    }
}



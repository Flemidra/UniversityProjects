using System;

namespace Palindrome
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Ingrese una palabra para determinar si es palindrome");
            var inputString = Console.ReadLine();
            if (!String.IsNullOrEmpty(inputString))
            {
                var newWord = new Words(inputString);
                newWord.EvaluateWord();

            }
            else
            {
                Console.WriteLine("No se ingreso ninguna palabra ");
            }

            Console.ReadKey();
        }
    }
}

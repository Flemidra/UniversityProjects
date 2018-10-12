using System;
using System.Linq;

namespace Palindrome
{
    internal class Words
    {
        private readonly string _word;
        public Words(string word)
        {
            _word = word;
            _word = _word.ToLower();
        }

        public void EvaluateWord()
        {
            var aux = new string(_word.Reverse().ToArray());
            if (aux == _word)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("La palabra es palindrome");
                Console.ResetColor();
                Console.WriteLine("La palabra original es: " + _word + " y su reverso es: " + aux);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("La palabra no es palindrome.");
                Console.ResetColor();

                Console.WriteLine("La palabra original es: " + _word + " y su reverso es: " + aux);

            }
        }
    }
}

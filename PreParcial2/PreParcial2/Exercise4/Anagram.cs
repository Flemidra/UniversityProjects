using System;
using System.Linq;
using static System.String;

namespace PreParcial2
{
    class Anagram
    {
        private string _wordA, _wordB;
        public Anagram(string _wordA, string _wordB)
        {
            this._wordA = _wordA;
            this._wordB = _wordB;
        }

        public void OrderWords()
        {
            _wordA = _wordA.Replace(" ", Empty);
            _wordB = _wordB.Replace(" ", Empty);
            _wordA = Concat(_wordA.OrderBy(c => c));
            _wordB = Concat(_wordB.OrderBy(c => c));

        }

        public void PrintResult()
        {
            Console.WriteLine(_wordA.Equals(_wordB, StringComparison.OrdinalIgnoreCase)
                ? "Si es un anagrama."
                : "No es un anagrama.");
        }
    }
}

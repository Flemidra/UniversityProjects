using System;
using System.Collections.Generic;
using System.Linq;

namespace PreParcial2
{
    class RandomVector
    {
        private readonly List<int> _randomVector;

        public RandomVector()
        {
            _randomVector = new List<int>();
        }
        public void GenerateRandomVectors()
        {
            var newNumber = new Random();
            for (var i = 0; i < 10; i++)
            {
                _randomVector.Add((short)newNumber.Next());
            }
            var aux = _randomVector.Sum();

            for (var i = 0; i < 10; i++)
            {
                var randomNumber = newNumber.Next();
                if (randomNumber > aux)
                {
                    _randomVector.Add(randomNumber);
                }
                else
                    i--;
            }
            PrintVector(aux);
        }

        public void PrintVector(int aux)
        {
            Console.WriteLine("El vector es: ");
            foreach (var value in _randomVector)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Y la suma de los primeros 10 digitos son: " + aux);

        }
    }
}

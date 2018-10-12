using System;

namespace JuegoAleatorio
{
    class Randomizer
    {
        private int _number, _attempt;
        public bool Continue;

        public Randomizer()
        {
            _number = -1;
            _attempt = 0;
            Continue = true;
        }

        public void GenerateNumber()
        {
            Random numb = new Random();
            _number = numb.Next(1, 100);
        }

        public void GameOver()
        {
            if (_attempt == 5)
            {
                Console.WriteLine("El numero a adivinar era: " + _number);
                Console.WriteLine("Game Over Feliz Navidad.");
                Continue = false;
            }
        }

        public void CheckAnswer(int number)
        {
            _attempt++;
            if (number == _number)
            {
                Console.WriteLine("Felicidades has adivinado el numero.");
                Continue = false;
                if (number == _number && _attempt < 5)
                {
                    Console.WriteLine("Le recomendamos seguir jugando debido a su gran habilidad.");
                }
            }
            else
            {
                GenerateNumber();
                GameOver();
            }
           
        }
    }
}

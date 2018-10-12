using System;

namespace JuegoAleatorio
{
    internal class Program
    {
        private static void Main()
        {
            var rm = new Randomizer();
            rm.GenerateNumber();
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduzca un numero entre el 1 y el 100. Y trate de adivinar.");
                var aux = Convert.ToInt32(Console.ReadLine());
                rm.CheckAnswer(aux);
                if (rm.Continue == false)
                    i = 5;
            }
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

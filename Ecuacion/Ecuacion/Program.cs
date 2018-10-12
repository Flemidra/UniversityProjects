using System;

namespace Ecuacion
{
    class Program
    {
        static void Main(string[] args)
        {
            float y = 0;

            Console.WriteLine("Bienvenido al programa de ecuaciones");
            for (var i = -5; i < 5; i++)
            {
                y = (2 * ((float)Math.Pow(i, 2)) + (3 * i) + 2);
                Console.WriteLine("X : " + i + " Y : " + y);
                
            }
            Console.ReadKey();
        }
    }
}

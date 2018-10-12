using System;
using System.Threading;

namespace Ejercicio4
{
    internal class Program
    {
        private static void Main()
        {
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a extras...Yo sere su acompañante.");
                Console.WriteLine("Seleccione la opcion que desee introduciendo la letra acorde a su opcion.");
                Console.WriteLine("a) Circulo.");
                Console.WriteLine("b) Cuadrado.");
                Console.WriteLine("c) Rectangulo.");
                Console.WriteLine("d) Triangulo.");
                Console.WriteLine("e) Salir");
                option = Console.ReadLine();
                if (!String.IsNullOrEmpty(option))
                {
                    if (option != null && (option[0] == 'a' || option[0] == 'b' || option[0] == 'c' || option[0] == 'd'))
                    {
                        FigurasGeometricas fg = new FigurasGeometricas(option[0]);
                    }
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }
            } while (option[0] != 'e');
            Console.WriteLine("Saliendo en 3 segundos...");
            Thread.Sleep(3000);
        }
    }
}



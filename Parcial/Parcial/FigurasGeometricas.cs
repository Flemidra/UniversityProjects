using System;

namespace Ejercicio4
{
    internal class FigurasGeometricas
    {
        private float _lado, _lado2;
        public FigurasGeometricas(char option)
        {
            switch (option)
            {
                case 'c':
                    Rectangulo();
                    break;

                case 'a':
                    Circulo();
                    break;

                case 'd':
                    Triangulo();
                    break;

                case 'b':
                    Cuadrado();
                    break;
            }
        }

        private void Rectangulo()
        {
            //Rectangulo = ( lado1 * lado2 )
            Console.WriteLine("La formula a utilizar es:  ( lado1 * lado2 )");
            Console.WriteLine("Ingres el valor del lado 1");
            _lado = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingres el valor del lado 2");
            _lado2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("El area del rectangulo es: " + (_lado * _lado2));
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }
        private void Circulo()
        {
            //Circulo = pi * area2
            Console.WriteLine("La formula a utilizar es: pi * area2");
            Console.WriteLine("Ingrese el radio del circulo.");
            _lado = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("El area del circulo es: " + (Math.Pow(_lado, 2) * Math.PI));
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
        private void Triangulo() 
        {
            //Triangulo = (base * altura) / 2
            Console.WriteLine("La formula a utilizar es: (base * altura)/2");
            Console.WriteLine("Ingrese la base del triangulo");
            _lado = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo.");
            _lado2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("El area del triangulo es: " + ((_lado * _lado2)/2));
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
        private void Cuadrado()
        {
            //Cuadrado = lado al cuadrado
            Console.WriteLine("La formula a utilizar es: lado^2");
            Console.WriteLine("Ingrese el valor de un lado del cuadrado.");
            _lado = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("El area del cuadrado es: " + (Math.Pow(_lado , 2)));
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}

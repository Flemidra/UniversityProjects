using System;

namespace Practica
{
    class Comida
    {
        public string Nombre;
        public double Calorias;
        public int Porcion;

        public Comida(string nombre, double calorias, int porcion)
        {
            Porcion = porcion;
            Calorias = calorias;
            Nombre = nombre;
        }

        public void Informacion()
        {
            Console.WriteLine("El nombre de la comida es: " + Nombre);
            Console.WriteLine("Las calorias de la comida es: " + Calorias);
            Console.WriteLine("La porcion de la comida es: " + Porcion);
        }

    }
}

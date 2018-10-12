using System;

namespace Practica
{
    internal class Mexicana : Comida
    {
        public string Region;
        public double Precio;

        public Mexicana(string Nombre, double Calorias, int Porcion, string region, double precio) : base(Nombre, Calorias, Porcion)
        {
            Region = region;
            Precio = precio;
        }

        public void ImprimirInformacion()
        {
            Console.WriteLine("La region de la comida es: " + Region);
            Console.WriteLine("El precio de la comida es: " + Precio);
        }

    }
}

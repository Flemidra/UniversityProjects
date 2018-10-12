using System;

namespace Herencia
{
    internal class Program
    {
        static void Main()
        {
            var ejemplo = new Hamburguesa();
            ejemplo.SetCandidadComida(5);
            ejemplo.SetNombre("Hamburguesa Especial");
            ejemplo.SetCosto((float)178.49);
            Console.WriteLine("El dia de hoy tenemos disponible: " + ejemplo.GetNombre() + ". Con un costo de: " + ejemplo.GetCosto() + "$. Y tenemos: " + ejemplo.GetCantidadComida() + " disponibles.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace AgenciaAutomovilistica
{
    internal class Program
    {
        private static void Main()
        {
            var modelos = new List<string>();
            var vendedor = new List<Vendedor>();
            var aux = 0;
            Console.WriteLine("Ingrese los 15 modelos de carro.");
            for (var i = 0; i < 5; i++) // Cambiar a 5
            {
                modelos.Add(Console.ReadLine());
            }
            for (var i = 0; i < 2; i++) // Cambiar a 10
            {
                Console.WriteLine("Ingrese el nombre del empleado numero " + (i+1));
                vendedor.Add(new Vendedor(Console.ReadLine()));
                vendedor[i].Ventas();
            }

            Console.WriteLine();
            for (var i = 0; i < 2; i++) // Cambiar a 10
            {
                Console.WriteLine("Empleado: " + vendedor[i].Nombre);
                for (var j = 0; j < 5; j++) // Cambiar a 15
                {
                    Console.WriteLine(modelos[i] + ": " + vendedor[i].VentasList[j]);
                }
            }
            Console.Clear();
            Console.Write("    ");
            foreach (var value in modelos)
            {
                Console.Write("    " + value);
            }
            Console.WriteLine();
            for (var i = 0; i < 2; i++) //Cambiar a 10
            {
                Console.Write(vendedor[i].Nombre + "    ");
                for (var j = 0; j < 5; j++)
                {
                    Console.Write(vendedor[i].VentasList[j] + "    ");
                }
                Console.WriteLine();
            }
            Console.Write("Total");
            for (var i = 0; i < 5; i++) //Cambiar a 15
            {
                aux = 0;
                for (var j = 0; j < 2; j++) //Cambiar a 10
                {
                    aux = aux + (vendedor[j].VentasList[i]);
                }
                Console.Write("    " + aux);
            }
            Console.WriteLine();
            aux = 0;
            int auxb, index = 0;
            for (var i = 0; i < (vendedor.Count-1); i++) //Cambiar a 10
            {
                aux = vendedor[i].VentasList.Sum();
                auxb = vendedor[i + 1].VentasList.Sum();
                if (auxb > aux)
                {
                    aux = auxb;
                    index = i+1;
                }
            }
            Console.WriteLine("El vendedor " + vendedor[index].Nombre + " Es el vendedor que mas ventas tuvo. Con un total de: " + aux);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}

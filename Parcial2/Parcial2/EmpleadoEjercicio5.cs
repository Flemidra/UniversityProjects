using System;
using System.Collections.Generic;
using System.Linq;

namespace Parcial2
{
    class EmpleadoEjercicio5
    {
        public string nombre;
        public List<double> horas;

        public EmpleadoEjercicio5()
        {
            horas = new List<double>();
            SetDatos();
        }

        public void SetDatos()
        {
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Ingrese una hora");
                    horas.Add(Convert.ToDouble(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error. " + e.Message);
                    throw;
                }
            } while (horas.Count != 7);
        }

        public void PrintDatos()
        {
            Console.Write("Empleado: " + nombre + " Horas: ");
            for (var i = 0; i < 7; i++)
            {
                Console.Write(horas[i] + " ");
            }
            Console.Write(" Y su promedio de horas es: " + Promedio());
            Console.WriteLine();
        }

        public double Promedio()
        {
            return (horas.Sum() / 7);
        }
    }
}

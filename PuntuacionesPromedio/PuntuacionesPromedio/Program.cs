using System;
using System.Collections.Generic;

namespace PuntuacionesPromedio
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var notes = new List<int>();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Introduzca por favor la calificacion numero " + (i+1) + " del estudiante");
                var aux = Convert.ToSingle(Console.ReadLine());
                if ((int)aux >= 0 && (int)aux <= 100)
                    notes.Add((int)aux);
                else
                {
                    i--;
                    Console.WriteLine("El numero que ha introducido es invalido");
                }
            }
            AverageNote an = new AverageNote(notes);
            an.PrintCharTableAndResult();
            an.Mode();
            an.Middle();
            Console.ReadKey();
        }
    }
}

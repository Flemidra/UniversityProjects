using System;

namespace Pulsaciones
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("estas preparado para correr? SI  / NO");
            var opcion = Console.ReadLine();
            if (opcion == "SI")
            {
                var arc = new Archivo("C:\\POO\\Pulsaciones.txt");
                arc.NuevoArchivo();
                arc.LlenarArchivo();
                Console.WriteLine("Su archivo ha sido creado correctamente.");
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace Constructores
{
    internal class Program
    {
        internal static void Main()
        {
            Hora h1 = new Hora();
            Console.WriteLine("Constructor sin parametros: " +h1.GetHour() + ":" + h1.GetMinutes() + ":" + h1.GetSeconds());
            Hora h2 = new Hora(12, 40, 59);
            Console.WriteLine("Constructor con parametros: " + h2.GetHour() + ":" + h2.GetMinutes() + ":" + h2.GetSeconds());
            Console.WriteLine("-----------------------------------");
            var e1 = new Empleado();
            var e2 = new Empleado(4);
            var e3 = new Empleado("Juan", 2);
            Console.WriteLine("Constructor por defecto: Nombre: " + e1.GetNombre() + " Numero de empleado: " + e1.GetNEmpleado());
            Console.WriteLine("Constructor con 1 parametro: Nombre: " + e2.GetNombre() + " Numero de empleado: " + e2.GetNEmpleado());
            Console.WriteLine("Constructor con 2 parametros: Nombre: " + e3.GetNombre() + " Numero de empleado: " + e3.GetNEmpleado());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace ArrayEmpleado
{
    internal class Program
    {
        private static void Main()
        {
            var lista = new List<Empleado>();
            for (var i = 0; i < 3; i++)
            {
                var obj = new Empleado();
                obj.LeerDato();
                lista.Add(obj);
            }

            foreach (var value in lista)
            {
                value.VerDatos();
            }
            Console.ReadKey();
        }
    }
}
/*Crear una clase llamada empleado que contenga como miembro dato el nombre y numero de empleado y como metodos:
 Leer datos() y ver datos(). 
 Dichos metodos deben tomar los datos del teclado y los visualizara en pantalla respectivamente.
 Considerar que debe utilizar, un array de tipo empleado y luego debera llenarlo con datos correspondientes a 50
 empleados.
 Por ultimo debera visualizar los datos de todos los empleados*/
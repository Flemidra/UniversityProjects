using System;

namespace ArrayEmpleado
{
    internal class Empleado
    {
        private string _nombreEmpleado;
        private int _numeroEmpleado;
        public Empleado()
        {
            _numeroEmpleado = 0;
            _nombreEmpleado = "";
        }
        public Empleado(string nombreEmpleado, int numeroEmpleado)
        {
            _nombreEmpleado = nombreEmpleado;
            _numeroEmpleado = numeroEmpleado;
        }

        public void LeerDato()
        {
            try
            {
                Console.WriteLine("Capture el numero de empleado.");
                _numeroEmpleado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del empleado.");
                _nombreEmpleado = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Lo sentimos, ha ocurrido un error" + e.Message);
            }
        }

        public void VerDatos()
        {
            Console.WriteLine("El numero de empleado es: " +_nombreEmpleado + " y el numero de empleado es: " + _numeroEmpleado);
        }

        
    }
}

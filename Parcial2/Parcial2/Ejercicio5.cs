using System;
using System.Collections.Generic;

namespace Parcial2
{
    class Ejercicio5
    {
        public List<EmpleadoEjercicio5> emp;
        public Ejercicio5()
        {
            emp = new List<EmpleadoEjercicio5>();
            do
            {
                emp.Add(new EmpleadoEjercicio5());

            } while (emp.Count != 10);
        }

        public void PrintEmpleados()
        {
            foreach (var value in emp)
            {
                value.PrintDatos();
            }
        }
    }
}

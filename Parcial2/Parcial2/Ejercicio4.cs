using System;
using System.Collections.Generic;

namespace Parcial2
{
    class Ejercicio4
    {
        private List<Empleado> Contrato;
        public Ejercicio4()
        {
            Contrato = new List<Empleado>();
        }

        public void SetContrato()
        {
            float Sueldo = 0;
            var Nombre = "";
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el nombre del empleado.");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el contrato del empleado.");
                    Sueldo = Convert.ToSingle(Console.ReadLine());
                    Contrato.Add(new Empleado(Nombre, Sueldo));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error " + e.Message);

                }
            } while (Contrato.Count != 5);
        }

        public void CalcularNuevoContrato()
        {
            foreach (var value in Contrato)
            {
                if (value.Salario >= 0 && value.Salario <= 1500)
                {
                    value.Salario = (value.Salario * 1.2);
                }
                else
                {
                    if (value.Salario >= 1501 && value.Salario <= 5000)
                    {
                        value.Salario = (value.Salario * 1.1);

                    }
                    else
                    {
                        if (value.Salario >= 5001 && value.Salario <= 7000)
                        {
                            value.Salario = (value.Salario * 1.5);

                        }
                    }
                }
            }
        }

        public void ImprimirContrato()
        {
            foreach (var value in Contrato)
            {
                Console.Write("Empleado: " + value.Nombre);
                Console.WriteLine(" Contrato: " + value.Salario);
            }
        }

    }
}

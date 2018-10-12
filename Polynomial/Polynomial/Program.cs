using System;
using System.Threading.Tasks;

namespace Polynomial
{
    internal class Program
    {
        private static void Main()
        {
            var controller = new Controller();
            try
            {
                string sel;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Seleccion el tipo de dato de entrada.");
                    Console.WriteLine("1) Ingresar termino.");
                    Console.WriteLine("2) Ingresar constante.");
                    Console.WriteLine("3) Continuar con los calculos.");
                    sel = Console.ReadLine();
                    switch (sel)
                    {
                        case "1":
                            Console.WriteLine("Ingrese el coeficiente, seguido de un enter y luego un exponente.");
                            try
                            {
                                controller.AddNewElement(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), true);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Numero invalido." + e);
                            }
                            break;
                        case "2":
                            Console.WriteLine("Ingrese una constante.");
                            try
                            {
                                controller.AddNewElement(Convert.ToInt32(Console.ReadLine()), 0, false);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Numero invalido." + e);
                            }
                            break;
                        default:
                            Console.WriteLine("Opcion Invalida.");
                            break;
                    }
                    Console.WriteLine("El programa continuara en 1 segundo.");
                    Task.Delay(1500);
                } while (sel != "3");
                Console.Clear();
                Console.Write("La formula es: ");
                controller.ShowEquation();
                Console.WriteLine();
                controller.CalculatePolynomial();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

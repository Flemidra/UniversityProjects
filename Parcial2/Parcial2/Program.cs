using System;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Ejercicio 4");
            Console.WriteLine("2)Ejercicio 5");
            var aux = Console.ReadLine();
            switch (aux)
            {
                case "1":
                    //Ejercicio 4

                    try
                    {
                        var e4 = new Ejercicio4();
                        e4.SetContrato();
                        e4.CalcularNuevoContrato();
                        e4.ImprimirContrato();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case "2":
                    //Ejercicio 5
                    try
                    {
                        var e5 = new Ejercicio5();
                        e5.PrintEmpleados();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("opcion invalida.");
                    break;
            }

            Console.ReadKey();



        }
    }
}

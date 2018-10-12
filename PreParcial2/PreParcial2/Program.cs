using System;
using System.Collections.Generic;
using System.Linq;
using PreParcial2.Exercise1;
using PreParcial2.Exercise2;

namespace PreParcial2
{
    internal class Program
    {
        private static void Exercise1()
        {
            var newExercise1 = new Controller();
            newExercise1.StartupExercise1();
        }

        private static void Exercise2()
        {
           var election = new Elections();
            Console.ReadKey();
        }
        private static void Exercise3()
        {
            var newVector = new RandomVector();
            newVector.GenerateRandomVectors();
            Console.ReadKey();
        }
        private static void Exercise4()
        {
            Console.WriteLine("Ingrese la primera palabra.");
            var aux = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda palabra.");
            var auxb = Console.ReadLine();
            if (!String.IsNullOrEmpty(aux) && !String.IsNullOrEmpty(auxb))
            {
                var an = new Anagram(aux, auxb);
                an.OrderWords();
                an.PrintResult();
            }
            else
            {
                Console.WriteLine("Las palabras no pueden estar vacias.");
            }

            Console.ReadKey();
        }

        private static void Main()
        {
            try
            {
                string option;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Seleccione el numero del ejercicio al que desea acceder.");
                    Console.WriteLine("1 - Gestion de Alumnos.");
                    Console.WriteLine("2 - Elecciones de Alcalde.");
                    Console.WriteLine("3 - Vector Aleatorio.");
                    Console.WriteLine("4 - Anagrama.");
                    Console.WriteLine("5 - Salir.");
                    option = Console.ReadLine();
                    if (!String.IsNullOrEmpty(option))
                    {
                        switch (option)
                        {
                            case "1":
                                Exercise1();
                                break;

                            case "2":
                                Exercise2();
                                break;

                            case "3":
                                Exercise3();
                                break;

                            case "4":
                                Exercise4();
                                break;

                            case "5":
                                break;
                            default:
                                Console.WriteLine("La opcion seleccionada es invalida.");
                                break;
                        }
                    }
                    else
                        Console.WriteLine("El dato indicado no puede estar vacio.");
                } while (option != "5");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e.Message);
            }
        }
    }
}


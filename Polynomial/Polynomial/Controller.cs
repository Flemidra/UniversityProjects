using System;
using System.Collections.Generic;

namespace Polynomial
{
    internal class Controller
    {
        public List<Node> NodeList;
        public List<int> Constant;

        public Controller()
        {
            NodeList = new List<Node>();
            Constant = new List<int>();
        }

        public void AddNewElement(int coefficient, int exponent, bool selection)
        {
            if (selection)
            {
                NodeList.Add(new Node(coefficient, exponent));
            }
            else
            {
                Constant.Add(coefficient);
            }
        }

        public void ShowEquation()
        {
            var firstRun = true;
            foreach (var value in NodeList)
            {
                if (firstRun)
                {
                    Console.Write(value.Coefficient + "x^" + value.Exponent + " ");
                    firstRun = false;
                }
                else
                {
                    if (value.Coefficient > 0)
                    {
                        Console.Write(" + " + value.Coefficient + "x^" + value.Exponent + " ");
                    }
                    else
                    {
                        Console.Write(value.Coefficient + "x^" + value.Exponent + " ");

                    }

                }
            }
            foreach (var value in Constant)
            {
                if (value > 0)
                {
                    Console.Write("+" + value);
                }
                else
                {
                    Console.Write(value);
                }
            }
        }

        public void CalculatePolynomial()
        {
            var again = false;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el rango inicial de numeros a calcular.");
                    var minValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el rango final de numeros a calcular.");
                    var maxValue = Convert.ToInt32(Console.ReadLine());
                    for (var i = minValue; i < maxValue; i++)
                    {
                        var finalEquation = 0;
                        foreach (var value in NodeList)
                        {
                            finalEquation = finalEquation + value.Coefficient * (int)(Math.Pow(i, value.Exponent));
                        }

                        foreach (var value in Constant)
                        {
                            finalEquation = finalEquation + value;
                        }
                        Console.WriteLine("X: " + i + " = " + finalEquation);
                    }
                    again = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("El dato introducido es invalido" + e);
                    again = true;
                }
            } while (again != false);

        }
    }
}

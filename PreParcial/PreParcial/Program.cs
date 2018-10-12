using System;
using System.Threading;

namespace PreParcial
{
    internal class Program
    {
        private static void Main()
        {
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione el programa al que desea acceder:");
                Console.WriteLine("1 - Numero de dias en un mes.");
                Console.WriteLine("2 - Domingo de Pascua.");
                Console.WriteLine("3 - Ecuacion de Einstein.");
                Console.WriteLine("4 - Conversion de Hora.");
                Console.WriteLine("5 - Bisiesto o no");
                Console.WriteLine("6 - Salir.");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Introduzca el numero del mes que desee conocer.");
                        var aux = Convert.ToSingle(Console.ReadLine());
                        if ((int)aux > 0 && (int)aux <= 12)
                        {
                            Month month = new Month((int)aux);
                            month.GetResult1();
                        }
                        else
                            Console.WriteLine("El mes indicado no existe. Gracias");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Ingrese el año que desea conocer");
                        var year = Convert.ToSingle(Console.ReadLine());
                        if ((int) year > 0)
                        {
                            Pascua p = new Pascua((int)year);
                            if (p.GetYear() <= 31)
                                p.GetResult1();
                            else
                                p.GetResult2();
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        Console.Clear();
                        var en = new Energy();
                        en.SetEnergy();
                        en.Calculate();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Introduzca la hora en el siguiente formato N1N2:M1M2");
                        string time = Console.ReadLine();
                        var t = new TimeChange(time);
                        t.SetHour();
                        if (!t.GetAm())
                            t.GetResultPM();
                        else
                            t.GetResultAM();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Introduzca un año");
                        aux = Convert.ToSingle(Console.ReadLine());
                        var ly = new LeapYear((int)aux);
                        ly.CheckYear();
                        if (ly.GetLeapYear())
                            ly.GetResult1();
                        else
                            ly.GetResult2();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "6": //SALIDA
                        Console.WriteLine("Gracias por haber utilizado el software creado por Flemidra.");
                        Thread.Sleep(3000);
                        break;
                    default:
                        Console.WriteLine("La opcion introducida es invalida. Vuelva a intentarlo");
                        Thread.Sleep(1000);
                        break;

                }
            }while (option != "6");
        }
    }
}
using System;

namespace Casa__de__Cambio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la casa de cambio El Venezolano No Lo Roba");
            Console.WriteLine("Por favor introduzca la cantidad de dolares que desea cambiar.");
            float money = Convert.ToSingle(Console.ReadLine());
            var change = new Cambio(money);
            Console.WriteLine("El cambio de su dinero es: " + change.GetMoney() + "$");
            change.CalculateMoney();
            Console.ReadKey();
        }
    }
}

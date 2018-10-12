using System;

namespace PreParcial
{
    class Energy
    {
        private double _energy;
        public Energy()
        {
            _energy = 0;
        }

        public void SetEnergy()
        {
            Console.WriteLine("Introduzca una masa en gramos.");
            _energy = Convert.ToSingle(Console.ReadLine());
        }
        public void Calculate()
        {
            Console.WriteLine("La masa dada en gramos es de: " + _energy + "gr. Y su transformacion a KG es de: " + (_energy /1000) + "Kg");
            _energy = ((_energy /1000) * Math.Pow(2.99792458 * Math.Pow(10,8), 2));
            Console.WriteLine("La energia resultante es: " + _energy + "J (Joules).");
            _energy = (_energy * 10000000);
            Console.WriteLine("La energia resultante es: " + _energy + "Erg (Ergios).");

        }
    }
}

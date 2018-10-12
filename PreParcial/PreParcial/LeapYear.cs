using System;

namespace PreParcial
{
    internal class LeapYear
    {
        private bool _leapYear = false;
        private int _year;

        public LeapYear(int year)
        {
            _year = year;
        }

        public void CheckYear()
        {
            if (_year % 4 == 0 && (_year % 100 != 0 || _year % 400 == 0))
            _leapYear = true;
        }

        public bool GetLeapYear()
        {
            return (_leapYear);
        }

        public void GetResult1()
        {
            Console.WriteLine("El año es bisiesto");
        }

        public void GetResult2()
        {
            Console.WriteLine("El año no es bisiesto");
        }
    }
}

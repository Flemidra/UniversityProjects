using System;

namespace PreParcial
{
    class Pascua
    {
        private int _year;
        public Pascua(int year)
        {
            _year = year;
            CalculateYear();
        }

        private void CalculateYear()
        {
            _year = 22 + ((19 * (_year % 19) + 24) % 30) +
                    ((2 * (_year % 4) + 4 * (_year % 7) + 6 * (((19 * (_year % 19) + 24) % 30)) + 5) % 7);
        }

        public int GetYear()
        {
            return (_year);
        }

        public void GetResult1()
        {
            Console.WriteLine("El domingo de Pascua se celebra el " + GetYear() + " de Marzo.");
        }

        public void GetResult2()
        {
            Console.WriteLine("El domingo de pascua se celebra el " + (GetYear() - 31) +
                              " del mes de Abril.");
        }
    }
}

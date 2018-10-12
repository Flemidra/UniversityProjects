using System;

namespace PreParcial
{
    class Month
    {
        private int _numberOfDays;
        private string _monthName;
        private int _month;
        public Month(int month)
        {
            _month = month;
            CheckMonth();
        }

        private  void CheckMonth()
        {
            switch(_month)
            {
                case 1:
                    _numberOfDays = 31;
                    _monthName = "Enero";
                    break;
                case 2:
                    _numberOfDays = 28;
                    _monthName = "Febrero";
                    break;
                case 3:
                    _numberOfDays = 31;
                    _monthName = "Marzo";
                    break;
                case 4:
                    _numberOfDays = 30;
                    _monthName = "Abril";
                    break;
                case 5:
                    _numberOfDays = 31;
                    _monthName = "Mayo";
                    break;
                case 6:
                    _numberOfDays = 30;
                    _monthName = "Junio";
                    break;
                case 7:
                    _numberOfDays = 31;
                    _monthName = "Julio";
                    break;
                case 8:
                    _numberOfDays = 31;
                    _monthName = "Agosto";
                    break;
                case 9:
                    _numberOfDays = 30;
                    _monthName = "Septiembre";
                    break;
                case 10:
                    _numberOfDays = 31;
                    _monthName = "Octubre";
                    break;
                case 11:
                    _numberOfDays = 30;
                    _monthName = "Noviembre";
                    break;
                case 12:
                    _numberOfDays = 31;
                    _monthName = "Diciembre";
                    break;

            }
        }

        public int GetNumberOfDays()
        {
            return (_numberOfDays);
        }

        public string GetMonthName()
        {
            return (_monthName);
        }

        public void GetResult1()
        {
            Console.WriteLine(GetMonthName() + " posee: " + GetNumberOfDays() + " dias.");
        }
    }
}

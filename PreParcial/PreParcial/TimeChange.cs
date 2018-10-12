using System;


namespace PreParcial
{
    internal class TimeChange
    {
        private string _time;
        private bool _am;
        private int _hour;

        public TimeChange(string time)
        {
            _time = time;
            _am = false;
            CalculateHour();
        }

        private void CalculateHour()
        {
            if ((Convert.ToInt16(_time.Substring(0, 2))) > 12)
            _hour = (Convert.ToInt16(_time.Substring(0, 2))) - 12;
            else
            {
                if (Convert.ToInt16(_time.Substring(0, 2)) != 00)
                {
                    _hour = (Convert.ToInt16(_time.Substring(0, 2)));
                    _am = true;
                }
                else
                {
                    _hour = 12;
                }
                
            }
        }

        public void SetHour()
        {
            CalculateHour();
        }

        public string GetMinutes()
        {
            return (_time.Substring(3, 2));
        }

        public int GetHour()
        {
            return (_hour);
        }

        public bool GetAm()
        {
            return (_am);
        }

        public void GetResultPM()
        {
            Console.WriteLine("La hora es: " + GetHour() + ":" + GetMinutes() + "PM");
        }

        public void GetResultAM()
        {
            Console.WriteLine("La hora es: " + GetHour() + ":" + GetMinutes() + "AM");
        }
    }
}

namespace Constructores
{
    internal class Hora
    {
        private int _hour, _minutes, _seconds;
        public Hora()
        {
            _hour = 0;
            _minutes = 0;
            _seconds = 0;
        }

        public Hora(int hour, int minutes, int seconds)
        {
            _hour = hour;
            _minutes = minutes;
            _seconds = seconds;
        }

        public int GetHour()
        {
            return (_hour);
        }

        public int GetMinutes()
        {
            return (_minutes);
        }

        public int GetSeconds()
        {
            return (_seconds);
        }
    }
}

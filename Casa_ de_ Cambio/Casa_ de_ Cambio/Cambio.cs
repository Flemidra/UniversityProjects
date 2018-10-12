using System;

namespace Casa__de__Cambio
{
    public class Cambio
    {
        private string _outString;
        private float _money;
        public Cambio(float money)
        {
            _money = money;
            Convertion();
        }

        private void Convertion()
        {
            _money = (float)(_money * 19.58);
            _outString = _money.ToString("####0.00");
        }

        public void CalculateMoney()
        {
            int aux = 0;
            while (_money >= 500)
            {
                aux++;
                _money -= 500;
            }
            if (aux > 0)
                Console.WriteLine(aux + " billetes de 500");
            aux = 0;
            while (_money >= 200)
            {
                aux++;
                _money -= 200;
            }
            if (aux > 0)
                Console.WriteLine(aux + " billetes de 200");
            aux = 0;
            while (_money >= 100)
            {
                aux++;
                _money -= 100;
            }
            if (aux > 0)
                Console.WriteLine(aux + " billetes de 100");
            aux = 0;
            while (_money >= 50)
            {
                aux++;
                _money -= 50;
            }
            if (aux > 0)
                Console.WriteLine(aux + " billetes de 50");
            aux = 0;
            while (_money >= 20)
            {
                aux++;
                _money -= 20;
            }
            if (aux > 0)
                Console.WriteLine(aux + " billetes de 20");
            aux = 0;
            while (_money >= 10)
            {
                aux++;
                _money -= 10;
            }
            if (aux > 0)
                Console.WriteLine(aux + " monedas de 10");
            aux = 0;
            while (_money >= 5)
            {
                aux++;
                _money -= 5;
            }
            if (aux > 0)
                Console.WriteLine(aux + " monedas de 5");
            aux = 0;
            while (_money >= 2)
            {
                aux++;
                _money -= 2;
            }
            if (aux > 0)
                Console.WriteLine(aux + " monedas de 2");
            aux = 0;
            while (_money >= 1)
            {
                aux++;
                _money -= 1;
            }
            if (aux > 0)
                Console.WriteLine(aux + " monedas de 1");
            aux = 0;
            while (_money >= 0.5)
            {
                aux++;
                _money -= (float)0.5;
            }
            if (aux > 0)
                Console.WriteLine(aux + " monedas de 0.5");
            aux = 0;
            if (_money > 0)
            {
                _outString = _money.ToString("Cantidad sin procesar: " + "####0.00");
                Console.WriteLine(_outString);
            }
        }
        public string GetMoney()
        {
            return (_outString);
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfectNumber
{
    internal class PerfectClass
    {
        private readonly int _perfectVariable;
        private readonly List<int> _perfectList;
        private int _perfectStop;
        private bool _perfectBool;

        public PerfectClass()
        {
            _perfectStop = 0;
            _perfectList = new List<int>();
            _perfectBool = false;
            for (var perfectCounter = 1; _perfectStop < 4; perfectCounter++)
            {
                _perfectList.Clear();
                _perfectVariable = perfectCounter;
                CalculatePerfectNumberOfPerfectClass();
            }


        }
        public PerfectClass(int perfectNumber)
        {
            _perfectBool = true;
            _perfectVariable = perfectNumber;
            _perfectList = new List<int>();
            CalculatePerfectNumberOfPerfectClass();
        }
        public void CalculatePerfectNumberOfPerfectClass()
        {
            for (var i = 0; i < _perfectVariable; i++)
            {
                if ((i != 0) &&(_perfectVariable % i == 0))
                    _perfectList.Add(i);
            }
            PerfectMethodForPerfectNumberOfAPerfectClass();
        }

        private void PerfectMethodForPerfectNumberOfAPerfectClass()
        {
            var perfectAux = _perfectList.Sum();
            if ((_perfectList.Count > 0) && _perfectBool == true)
            {
                Console.Write(_perfectList[0]);
                for (var perfectCounter = 1; perfectCounter < _perfectList.Count; perfectCounter++)
                {
                    Console.Write(" + " + _perfectList[perfectCounter]);
                }

                if (perfectAux == _perfectVariable)
                {
                    Console.Write(" = " + _perfectVariable);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" [OK] ");
                    Console.ResetColor();
                    _perfectStop++;
                }
                else
                {
                    Console.Write(" = " + perfectAux + " Diferente de " + _perfectVariable);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" [ERROR] ");
                    Console.ResetColor();
                }
            }
            else
            {
                if (perfectAux == _perfectVariable)
                {
                    Console.Write(_perfectList[0]);
                    for (var perfectCounter = 1; perfectCounter < _perfectList.Count; perfectCounter++)
                    {
                        Console.Write(" + " + _perfectList[perfectCounter]);
                    }
                    Console.Write(" = " + _perfectVariable);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" [OK] ");
                    Console.ResetColor();
                    _perfectStop++;
                }
            }
        }
    }
}

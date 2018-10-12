namespace DecimalToRomanNumber
{
    internal class Converter
    {
        private readonly string _romanNumber;
        public Converter()
        {

        }
        public Converter(string number)
        {
            _romanNumber = number;
            _romanNumber = _romanNumber.ToUpper();
            if (_romanNumber.Length > 10)
                _romanNumber = _romanNumber.Substring(0, 10);
        }

        public int ToDecimal()
        {
            var result = 0;

            for (var i = 0; i < _romanNumber.Length; i++)
            {
                //Declaracion de variables
                var number2 = 0;
                int valor;
                var subString1 = _romanNumber.Substring(i, 1);
                var subString2 = "";
                //Fin declaracion

                if (i + 1 < _romanNumber.Length)
                    subString2 = _romanNumber.Substring(i + 1, 1);

                var number1 = ToNumber(subString1);

                if (subString2 != "")
                {
                    number2 = ToNumber(subString2);
                }


                if (number1 < number2)
                {
                    valor = number2 - number1;
                    i++;
                }
                else
                {
                    valor = number1;
                }

                result = result + valor;
            }

            return result;
        }

        private static int ToNumber(string n)
        {
            switch (n)
            {
                case "I":
                    return 1;

                case "V":
                    return 5;

                case "X":
                    return 10;

                case "L":
                    return 50;

                case "C":
                    return 100;

                case "D":
                    return 500;

                case "M":
                    return 1000;
                default:
                    return -1;
            }
        }
    }
}






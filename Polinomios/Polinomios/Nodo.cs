using System;


namespace Polinomios
{
    internal class Nodo
    {
        public int Coeficiente, Exponente; //dos variables que pide la profesora en el ejercicio

        public Nodo(int coeficiente, int exponente) //creas un constructor de dos variables
        {
            Coeficiente = coeficiente; //le asignas a tu variable de la clase, el valor que te pasaron por parametro
            Exponente = exponente; //le asignas a tu variable de la clase, el valor que te pasaron por parametro
            if (Exponente < 0) //Si en tal caso el exponente es negativo, vuelves a pedirselo al usuario hasta que lo ponga bien
            {
                do
                {
                    ValidarExponente();
                } while (Exponente < 0);
            }
        }

        public Nodo(int coeficiente)
        {
            Coeficiente = coeficiente; //cuando son constantes, solo almacenas un numero en l alista, el exponente es -1
            Exponente = -1;
        }
        public void ValidarExponente()
        {
            try
            {
                Console.WriteLine("Exponente invalido, debe ser positivo"); //aqui es donde le dices a la persona si el exponente que puso era invalido o no, en base a si era negativo
                Exponente = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("El valor ingresado debe ser un numero entero" + e);
            }
        }
    }
}

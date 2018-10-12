using System;

namespace Polinomios
{
    class Program
    {
        static void Main()
        {
            string stop = "s"; //Se declara variable string, que es la señal de parada del ciclo DO
            Formula formula = new Formula(); //Se instancia un nuevo objeto de la clase formula
            int aux; //Se crea variable auxiliar
            int auxb; //Se crea variable auxiliar.
            do //Empieza el ciclo que engloba el primer menu de terminos y constantes, es el que permite a la persona introducir 2x^3, o una constante +12 y asi
            {
                try //Utilizas try catch en caso de que la persona al momento de poner un numero, ponga es una letra y no explote.
                {
                    Console.WriteLine("1) Añadir  Termino"); //Creas el menu
                    Console.WriteLine("2) Añadir  Constante");
                    string option = Console.ReadLine(); //Lees la opcion del usuario, es STRING para evitar problemas de numeros, no existe error de string como cuando esperas un entero y te dan una letra
                    switch (option) 
                    {
                        case "1": //Si la letra que pone es un 1, te metes en esta opcion que es añadir termino
                            Console.WriteLine("Ingrese el coeficiente."); 
                            aux = Convert.ToInt32(Console.ReadLine()); //lees el coeficiente
                            Console.WriteLine("Ingrese el exponente.");
                            auxb = Convert.ToInt32(Console.ReadLine()); //Lees el exponente
                            formula.NuevoTermino(aux, auxb); //Creas un nuevo elemento dentro de la lista, y le pasas por parametro el coeficiente y el exponente. Estos parametros los pasas debido que tu lista es del tipo NODO, y nodo tiene 2 variables que tienes que llenar
                            break;
                        case "2":
                            Console.WriteLine("Ingrese el coeficiente."); //Aqui lees solo si es una constante
                            aux = Convert.ToInt32(Console.ReadLine());
                            formula.NuevaConstante(aux); //Agregas esa constante a la lista
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }
                    Console.WriteLine("Si no desea añadir mas terminos o constantes, escriba la letra n"); //Si el usuario presiona la N sigue el programa, si presiona cualquier otra cosa vuelve a añadir un termino o constante
                    stop = Console.ReadLine(); //Lees la letra que introducira el usuario
                }
                catch (Exception e)
                {
                    Console.WriteLine("El valor ingresado debe ser un numero" + e);
                }
            } while (stop != "n");
            Console.Clear(); //Limpias la consola de todo lo que tenias antes
            bool cont; //Creas una variable bool (es decir, que puede tener verdadero y falso unicamente)
            int i = 0, max = 0; //creas variables para un ciclo. esas variables son el rango de valores que vas a calcular (lo pide el ejercicio)
            Console.WriteLine("Ingrese el rango inicial de valores a calcular.");
            do
            {
                try //Esto es en caso el usuario pone una letra en vez de un numero
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    cont = true; //Esta variable funciona como un interruptor, si no pasa nada el sigue adelante, pero si da error, vuelve a pedirle a la persona que ingrese un dato

                }
                catch (Exception e)
                {
                    Console.WriteLine("El valor de entrada debe ser un numero" + e);
                    cont = false; //Si entras aca, cambias la variable a falso para que el usuario TENGA que meter una variable nuevamente
                }
            } while (cont != true);
            Console.WriteLine("Ingrese el rango inicial de valores a calcular.");
            do
            {
                try//Esto es en caso el usuario pone una letra en vez de un numero
                {
                    max = Convert.ToInt32(Console.ReadLine());
                    cont = true;

                }
                catch (Exception e)//lo mismo que antes sucede aqui
                {
                    Console.WriteLine("El valor de entrada debe ser un numero" + e);
                    cont = false;
                }
            } while (cont != true);
            Console.Clear(); //Borras de nuevo toda la pantalla para que se vea limpia
            formula.MostrarFormula(); //Aqui pones en consola la ecuacion que puso el usuario
            if (formula.terminos > 0 && formula.constantes > 0) //Compruebas de que por lo menos exista una constante y un termino, si no hay almenos 1 y 1, no cumple la norma de ser un polinomio
            {
                for (i = i; i < max; i++) //Aqui pones i = i ya que un for necesita SI O Si que la primera cosa que hagas es asignarle un valor, entonces le asignas a el mismo, su propio valor, y llegara hasta el rango final que puso el usuario
                {
                    formula.Calcular(i); //llamas el metodo de calcular y le pasas como parametro un numero que es la i del ciclo que va cambiando
                }
                formula.MostrarResultados(); //imprimes la tabla de resultados
            }
            else
            {
                Console.WriteLine("La formula ingresada no cumple con los requisitos minimos de un polinomio");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}

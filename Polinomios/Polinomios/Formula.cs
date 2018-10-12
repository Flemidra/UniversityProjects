using System;
using System.Collections.Generic;

namespace Polinomios
{
    internal class Formula
    {
        public List<Nodo> Terminos; //Creas una lista del tipo NODO, que es la que tiene los terminos (esas cosas que tiene numero, una X y luego un exponente)
        public List<Resultados> ListaResultados; //Aqui almacenas tus resultados, es del tipo RESULTADOS porque almacenas el numero que estabas evaluando en ese momento y el resultado de la cuenta
        public int terminos; //variable entero
        public int constantes; //variable entero

        public Formula() //Constructor sin parametros
        {
            Terminos = new List<Nodo>(); //Aqui inicializas las listas para que las puedas utilizar
            ListaResultados = new List<Resultados>(); //Aqui inicializas las listas para que las puedas utilizar
            terminos = 0;
            constantes = 0;
        }
        public void NuevoTermino(int coeficiente, int exponente) //Constructor con dos parametros.
        {
            Terminos.Add(new Nodo(coeficiente, exponente)); //Cuando es un termino, creas un nuevo objeto dentro de tu lista y le pasas los valores de coeficiente y exponente
            terminos = terminos + 1;
        }

        public void NuevaConstante(int coeficiente) //Constructor con un parametro
        {
            Terminos.Add(new Nodo(coeficiente)); //le pasas el valor de la constante. el programa diferencia si un numero es constante y termino cuando el exponente es -1. Un polinomio no puede tener exponente negativo
            constantes = constantes + 1;
        }
        public void MostrarFormula()
        {
            bool aux = true; //creas una variable bool, puede tener solo verdadero y falso o 1 y 0
            foreach (Nodo valor in Terminos) //Esto es un ciclo automatico, algo asi como el for pero mas facil por asi decirlo, que pasa por cada objeto que este dentro de la lista Terminos
            {
                if (aux) //Aqui compruebas de que si es la primera vez que se esta ejecutando este ciclo, no imprimes ningun signo antes del numero, para que no te salga algo como +4x^3 sino 4x^3
                {
                    Console.Write(valor.Coeficiente);
                    if (valor.Exponente != -1)
                    {
                        Console.Write("x^"+valor.Exponente); //Imprimes en pantalla cada numero junto con la letra x que es la incognita y el ^ es de potencia. Se pone Write para que no haga un salto de linea, es decir todo se escriba en la misma linea
                    }
                    aux = false; //cambias el valor de aux para que no se vuelva a repetir puesto que ya los proximos usos no son PRIMERA VEZ
                }
                else
                {
                    if (valor.Coeficiente > 0) //se comprueba si el numero es positivo de manera de ponerle un + antes del numero. Para que no quede algo tipo 3x^2 5x^3 sino que tenga un conector en el medio
                        Console.Write("+" + valor.Coeficiente);
                    else
                        Console.Write(valor.Coeficiente); //en el caso de que no sea positivo, se deja asi porque los numero snegativos se imprimen con un -
                    if (valor.Exponente != -1)
                    {
                        Console.Write("x^"+valor.Exponente); //imprimes la X por separado, aqui compruebas si tiene coeficiente -1 es una constante es decir no lleva X, si tiene otra cosa positiva si lleva x
                    }
                }
               
            }
            Console.WriteLine(); //Dejas una linea en blanco
        }

        public void Calcular(int numero)
        {
            double total = 0;
            foreach (var valor in Terminos) //haces un ciclo que va por todos los elementos de la lista Terminos
            {
                if (valor.Exponente != -1) //compruebas si es constante o termino
                {
                    total = total + (valor.Coeficiente * (Math.Pow(numero, valor.Exponente))); //realizas la cuenta, ELEMENTO POR ELEMENTO, esdecir si tienes 3x^4 + 5x^2, primero calculas 3x^4 y almacenas el valor en la variable total, luego calculas 5x^2 y lo almacenas en la variable total
                }
                else
                {
                    total = (total + valor.Coeficiente); //en caso de que sea solo una constante se la sumas a lo que llevas y ya
                }
            }
            ListaResultados.Add(new Resultados(numero, total)); //los resultaods los vas almacenando en una lista, en el orden de primero el numero de la x y luego el resultado que te dio
        }

        public void MostrarResultados()
        {
            foreach (var valor in ListaResultados) //creas un ciclo que pasa por todos los elementos de la lista de resultaods
            {
                Console.WriteLine("X: " + valor.numero + " = " + valor.resultado); //imprimes todos los elementos, primero X: y el numero que equivale X en ese momento seguido del resultado
            }
        }

    }
}
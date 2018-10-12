using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaAutomovilistica
{
    internal class Vendedor
    {
        public List<int> VentasList;
        public string Nombre;


        public Vendedor(string nombre)
        {
            VentasList = new List<int>();
            Nombre = nombre;
        }
        
        public void Ventas()
        {
            for (var i = 0; i < 5; i++) //Cambiar a 15
            {
                Console.WriteLine("Ingrese la venta asociada al modelo numero " + (i+1));
                try
                {
                    VentasList.Add(Convert.ToInt32(Console.ReadLine()));

                }
                catch (Exception e)
                {
                    Console.WriteLine("Dato introducido es invalido. " + e.Message);
                    i--;
                }
            }
        }
    }
}

/*
 * Una agencia de venta de vehiculos autmovilisticos, distribuye 15 modelos diferentes y tiene en su plantilla 10 vendedores, se desea hacer un programa con un informe mensual de las ventas por vendedor y modelo asi como el numero de automoviles vendidos por cada vendedor y el numero total de cada modelo vendido por todos los vendedores. Asi mismo, para entregar el premio al mejor vendedor se necesita saber cual es el vendedor que mas coches ha vendido
 */

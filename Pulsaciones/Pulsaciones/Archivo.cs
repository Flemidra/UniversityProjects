using System;
using System.IO;

namespace Pulsaciones
{
    internal class Archivo
    {
        public string Narchivo;

        public Archivo(string archivo)
        {
            Narchivo = archivo;
        }

        public void NuevoArchivo()
        {
            var fs = new FileStream(Narchivo, FileMode.OpenOrCreate, FileAccess.Read);
            fs.Close();
        }

        public void LlenarArchivo()
        {
            int hora = 0, minuto = 0, segundo = 0;
            var fechaActual = DateTime.Today;
            bool valido;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese la hora cuando empieza (formato 12 horas)");
                    hora = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese los minutos cuando empieza (formato 12 horas)");
                    minuto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la segundos cuando empieza (formato 12 horas)");
                    segundo = Convert.ToInt32(Console.ReadLine());
                    valido = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    valido = false;
                }
            } while (valido == false);
            var fs = new FileStream(Narchivo, FileMode.Append, FileAccess.Write);
            var sw = new StreamWriter(fs);
            var num = new Random();
            for (var i = 0; i < 480; i++)
            {
                sw.WriteLine(fechaActual.ToString("dd/MM/yyyy") + "\t" + hora.ToString("D2") + ":" +
                             minuto.ToString("D2") + ":" + segundo.ToString("D2") + "\t" + num.Next(120, 210));
                segundo = segundo + 15;
                if (segundo > 59)
                {
                    minuto = minuto + 1;
                    segundo = segundo - 60;
                    if (minuto > 59)
                    {
                        hora = hora + 1;
                        minuto = 0;
                    }

                    if (hora > 12)
                    {
                        hora = 1;
                    }
                }

            }
            sw.WriteLine();
            sw.WriteLine("-----------------------------------------");
            sw.WriteLine();
            sw.Close();
        }
    }
}

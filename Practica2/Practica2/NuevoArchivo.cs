using System;
using System.IO;

namespace Practica2
{
    class NuevoArchivo
    {
        public string Archivo;

        public NuevoArchivo(string n)
        {
            Archivo = n;
        }

        public void CrearArchivo()
        {
            var fs = new FileStream(Archivo, FileMode.Create, FileAccess.Write);
            try
            {
                var sw = new StreamWriter(fs);
                Console.WriteLine("Se ha creado el archivo");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e.Message);
            }
        }

        public void Adicionar()
        {
            Console.WriteLine("Desea escribir algo al archivo?. (SI / NO)");
            var aux = Console.ReadLine();
            if (aux == "SI")
            {
                try
                {
                    var fs = new FileStream(Archivo, FileMode.Append, FileAccess.Write);
                    var sw = new StreamWriter(fs);
                    Console.WriteLine("Escriba el texto a anexar.");
                    sw.WriteLine(Console.ReadLine());
                    sw.Close();
                    Adicionar(); //Metodo recursivo
                }
                catch (Exception e)
                {
                    Console.WriteLine("Banda ha ocurrido un error " + e.Message);
                    throw;
                }
            };
        }
    }
}

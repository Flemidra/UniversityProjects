using System;

namespace PreParcial2.Exercise2
{
    internal class Elections
    {
        string option;
        public Elections()
        {
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1)Imprimir tablero");
                    Console.WriteLine("2)Votos total de cada candidato");
                    Console.WriteLine("3)Salir");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            PrintTable();
                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadKey();
                            break;

                        case "2":
                            Console.WriteLine("La cantidad de votos totales de cada candidato son:");
                            Console.WriteLine("Candidato A: 1847 Votos. Equivalentes a un 39.61%");
                            Console.WriteLine("Candidato B: 269  Votos. Equivalentes a un 5.77%");
                            Console.WriteLine("Candidato C: 2308 Votos. Equivalentes a un 52.18%");
                            Console.WriteLine("Candidato D: 113  Votos. Equivalentes a un 2.42%");
                            Console.WriteLine("El ganador es el candidato C con 52.18%");

                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error" + e.Message);
                }
            } while (option != "3");
            

        }

        public void PrintTable()
        {
            var table = new[]
            {
                @"Distrito          Cantidades",
                @"              A     B     C    D",
                @"1             194   48    206  45",
                @"2             180   20    320  16",
                @"3             221   90    140  20",
                @"4             432   50    821  14",
                @"5             820   61    946  18",
            };
            foreach (string value in table)
            {
                Console.WriteLine(value);
            }
        }
    }
}

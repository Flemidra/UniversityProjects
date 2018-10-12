using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PuntuacionesPromedio
{
    class AverageNote
    {
        private List<int> _notes;
        private int _average;

        public AverageNote(List<int> notes)
        {
            _notes = notes;
            Average();
        }

        private void Average()
        {
            foreach (var note in _notes)
            {
                _average = _average + note;
            }
            _average = (_average / 4);
        }
        public  void PrintCharTableAndResult()
        {
            Console.WriteLine("|   Media   |  Puntuacion|");
            Console.WriteLine("|  90 - 100 |      A     |");
            Console.WriteLine("|  80 - 89  |      B     |");
            Console.WriteLine("|  70 - 79  |      C     |");
            Console.WriteLine("|  60 - 69  |      D     |");
            Console.WriteLine("|  0  - 59  |      E     |");
            Console.WriteLine();
            Console.Write("La calificacion promedio del alumno es de: " + _average + " Lo que equivale a una puntuacion de: ");

            if (_average >= 90 && _average <= 100)
            {
                Console.WriteLine("A.");
                Console.WriteLine("Felicitaciones, usted ha excentado el curso.");
            }

            if (_average >= 80 && _average <= 89)
            {
                Console.WriteLine("B");
                Console.WriteLine("Usted necesita mejorar sus calificaciones.");

            }

            if (_average >= 70 && _average <= 79)
            {
                Console.WriteLine("C");
                Console.WriteLine("Usted necesita mejorar sus calificaciones.");
            }

            if (_average >= 60 && _average <= 69)
            {
                Console.WriteLine("D");
                Console.WriteLine("Por favor vaya a Prometeo y no salga de ahi.");
            }

            if (_average >= 0 && _average <= 59)
            {
                Console.WriteLine("E");
                Console.WriteLine("Ya salte o si tienes varo, vete a Prometeo de manera permanente.");
            }
        }

        public void Mode()
        {
            var counts = _notes
                .Distinct()
                .Select(o => new { Valor = o, Repeticiones = _notes.Count(c => c == o) })
                .OrderByDescending(o => o.Repeticiones);
            Console.WriteLine("La moda es de " + counts.First());
        }

        public void Middle()
        {
            _notes.Sort();
            int Mid = 0;
            Mid =_notes.Count / 2;
            Console.WriteLine("La moda  es: " + _notes[Mid]);
        }
    }
}

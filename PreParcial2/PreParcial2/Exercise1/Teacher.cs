using System;
using System.Collections.Generic;

namespace PreParcial2.Exercise1
{
    internal class Teacher
    {
        public string Name;
        public List<Assignment> Assignments;

        public Teacher(string name)
        {
            Name = name;
            Assignments = new List<Assignment>();
        }

        public void NewAssignments()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la asignatura");
                Assignments.Add(new Assignment(Console.ReadLine()));

            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e);
            }
        }
    }
}

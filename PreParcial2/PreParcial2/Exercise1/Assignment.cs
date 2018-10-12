using System;
using System.Collections.Generic;

namespace PreParcial2.Exercise1
{
    class Assignment
    {
        public string assignment;
        public List<Student> RegularStudents;
        public List<StudentOnline> OnlineStudents;

        public Assignment(string assignment)
        {
            this.assignment = assignment;
            RegularStudents = new List<Student>();
            OnlineStudents = new List<StudentOnline>();
        }

        public void AddRegularStudent()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la nueva asignatura");
                RegularStudents.Add(new Student(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e);
            }
        }

        public void AddOnlineStudent()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la nueva asignatura.");
                OnlineStudents.Add(new StudentOnline(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e);
            }
        }
    }
}

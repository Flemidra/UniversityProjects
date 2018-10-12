using System;
using System.Collections.Generic;

namespace PreParcial2.Exercise1
{
    internal class Controller
    {
        private List<Teacher> _teacher;
        private int  _auxCounter, _auxCounterB, _auxCounterD;
        private string _stop, _aux, _option;

        public Controller()
        {
            _teacher = new List<Teacher>();
        }

        public void StartupExercise1()
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido al Dashboard");
                    Console.WriteLine("1)Agregar Profesor");
                    Console.WriteLine("2)Listado de Profesores");
                    Console.WriteLine("3)Agregar de Materia");
                    Console.WriteLine("4)Listado de Materias");
                    Console.WriteLine("5)Agregar Alumnos");
                    Console.WriteLine("6)Listado de Alumnos");
                    Console.WriteLine("7)Agregar Calificaciones de Alumno");
                    Console.WriteLine("8)Listar Calificaciones de Alumno");
                    Console.WriteLine("9)Salir");
                    _option = Console.ReadLine();
                    if (!string.IsNullOrEmpty(_option))
                    {
                        switch (_option)
                        {
                            case "1":
                                AddTeacher();
                                break;

                            case "2":
                                TeacherList();
                                break;

                            case "3":
                                AddAssignment();
                                break;

                            case "4":
                                ListAssignment();

                                break;

                            case "5":
                                AddStudent();
                                break;


                            case "6":
                                ListStudent();
                                break;

                            case "7":
                                AddScore();
                                break;

                            case "8":
                                ListScore();
                                break;

                            case "9":
                                break;

                            default:
                                Console.WriteLine("Opcion invalida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("La opcion no puede ser vacia.");
                    }
                } while (_option != "9");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e.Message);
            }
        }

        private void AddTeacher()
        {
            try
            {
                do
                {
                
                    Console.WriteLine("Ingrese el nombre del profesor.");
                    _teacher.Add(new Teacher(Console.ReadLine()));
                    Console.WriteLine("Profesor agregado exitosamente. Si desea crear otra entrada, marque s, de lo contrario colocar n");
                    _stop = Console.ReadLine();

                } while (!string.Equals(_stop, "n", StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e.Message);
            }
        }

        private void TeacherList()

        {
            foreach (var value in _teacher)
            {
                Console.WriteLine(value.Name);
            }
            Console.WriteLine("Presiona una tecla para continuar.");
            Console.ReadKey();
        }

        private void AddAssignment()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre del profesor al cual desea cargar la materia.");
                _aux = Console.ReadLine();
                _auxCounter = 0;
                foreach (var value in _teacher)
                {
                    if (string.Equals(value.Name, _aux, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    _auxCounter++;
                }

                do
                {
                    Console.WriteLine("Ingrese el nombre de la materia");
                    _teacher[_auxCounter].Assignments.Add(new Assignment(Console.ReadLine()));
                    Console.WriteLine("Materia agregada exitosamente. Si no desea agregar mas, escriba la letra n");
                    _stop = Console.ReadLine();
                } while (!string.Equals(_stop, "n", StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e.Message);

            }
        }

        private void ListAssignment()
        {
            Console.WriteLine("Ingrese el nombre del profesor al cual desea listar sus materia.");
            _aux = Console.ReadLine();
            _auxCounter = 0;
            foreach (var value in _teacher)
            {

                if (string.Equals(value.Name, _aux, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                _auxCounter++;
            }
            foreach (var value in _teacher[_auxCounter].Assignments)
            {
                Console.WriteLine(value.assignment);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        private void AddStudent()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre del profesor que imparte la materia.");
                _aux = Console.ReadLine();
                _auxCounter = 0;
                foreach (var value in _teacher)
                {

                    if (string.Equals(value.Name, _aux, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    _auxCounter++;
                }
                Console.WriteLine("Ingrese el nombre de la materia.");
                _aux = Console.ReadLine();
                _auxCounterB = 0;
                foreach (var value in _teacher)
                {
                    if (string.Equals(value.Assignments[_auxCounterB].assignment, _aux, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    _auxCounterB++;
                }

                string auxStop;
                do
                {
                    Console.WriteLine("El estudiante es OnLine o Presencial?");
                    _aux = Console.ReadLine();
                    if (string.Equals(_aux, "presencial", StringComparison.OrdinalIgnoreCase))
                    {
                        do
                        {
                            Console.WriteLine("Ingrese el nombre del estudiante.");
                            _teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents.Add(new Student(Console.ReadLine()));
                            Console.WriteLine("Estudiante agregado exitosamente. Si no desea agregar mas, escriba la letra n");
                            _stop = Console.ReadLine();
                        } while (!string.Equals(_stop, "n", StringComparison.OrdinalIgnoreCase));

                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("Ingrese el nombre del estudiante.");
                            _teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents.Add(new StudentOnline(Console.ReadLine()));
                            Console.WriteLine("Estudiante agregado exitosamente. Si desea agregar otro, escriba la letra s, de lo contrario n");
                            _stop = Console.ReadLine();
                        } while (!string.Equals(_stop, "n", StringComparison.OrdinalIgnoreCase));
                    }
                    Console.WriteLine("Si no desea agregar mas alumnos, escriba la letra n.");
                    auxStop = Console.ReadLine();
                } while (auxStop != "n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e.Message);
            }
        }

        private void ListStudent()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre del profesor que imparte la materia.");
                _aux = Console.ReadLine();
                _auxCounter = 0;
                foreach (var value in _teacher)
                {

                    if (string.Equals(value.Name, _aux, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    _auxCounter++;
                }
                Console.WriteLine("Ingrese el nombre de la materia.");
                _aux = Console.ReadLine();
                _auxCounterB = 0;
                foreach (var value in _teacher)
                {
                    if (string.Equals(value.Assignments[_auxCounterB].assignment, _aux, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    _auxCounterB++;
                }
                Console.WriteLine("Estudiantes presenciales: ");
                for (var i = 0; i < _teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents.Count; i++)
                {
                    Console.Write(_teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[i].Name);
                    for (var j = 0; j < (_teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents.Count); j++)
                    {
                        Console.WriteLine(" Promedio Examenes: " + (_teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[j].GetQuizAverageScore()) + " Promedio Practicas: " + (_teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[j].GetPracticesAverageScore()));
                    }
                }

                Console.WriteLine("Estudiantes OnLine: ");
                for (var i = 0; i < _teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents.Count; i++)
                {
                    Console.Write(_teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[i].Name);
                    for (var j = 0; j < (_teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents.Count); j++)
                    {
                        Console.WriteLine(" Promedio Examenes: " + (_teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[j].GetQuizAverageScore()) + " Promedio Practicas: " + (_teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[j].GetPracticesAverageScore()));
                    }
                }
                Console.WriteLine("Presione una tecla para continuar..");
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e.Message);
            }
        }

        private void AddScore()
        {
            try
            {
                string stopAux;
                Console.WriteLine("Ingrese el nombre del profesor que imparte la materia.");
                _aux = Console.ReadLine();
                _auxCounter = 0;
                foreach (var value in _teacher)
                {

                    if (string.Equals(value.Name, _aux, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    _auxCounter++;
                }
                Console.WriteLine("Ingrese el nombre de la materia.");
                _aux = Console.ReadLine();
                _auxCounterB = 0;
                foreach (var value in _teacher)
                {
                    if (string.Equals(value.Assignments[_auxCounterB].assignment, _aux, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    _auxCounterB++;
                }
                Console.WriteLine("El estudiante es OnLine o Presencial?");
                _aux = Console.ReadLine();
                if (string.Equals(_aux, "presencial", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Ingrese el nombre del estudiante.");
                    _aux = Console.ReadLine();
                    _auxCounterD = 0;
                    foreach (var value in _teacher)
                    {

                        if (string.Equals(value.Assignments[_auxCounterB].RegularStudents[_auxCounterD].Name, _aux, StringComparison.OrdinalIgnoreCase))
                        {
                            break;
                        }
                        _auxCounterD++;
                    }
                    do
                    {
                     Console.WriteLine("Agregar calificaciones de examenes o practicas");
                     _aux = Console.ReadLine();
                   
                        if (string.Equals(_aux, "examenes", StringComparison.OrdinalIgnoreCase))
                        {
                            do
                            {
                                Console.WriteLine("Ingrese la calificacion.");
                                _teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[_auxCounterD].Quiz.Add(Convert.ToSingle(Console.ReadLine()));
                                Console.WriteLine("Calificacion agregada exitosamente. Si no desea agregar mas, escriba la letra n");
                                _stop = Console.ReadLine();
                            } while (!string.Equals(_stop, "n", StringComparison.OrdinalIgnoreCase));

                        }
                        else
                        {
                            if (string.Equals(_aux, "practicas", StringComparison.OrdinalIgnoreCase))
                            {
                                do
                                {
                                    if (string.Equals(_aux, "presencial", StringComparison.OrdinalIgnoreCase))
                                    Console.WriteLine("Ingrese la calificacion.");
                                    _teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[_auxCounterD].Practices.Add(Convert.ToSingle(Console.ReadLine()));
                                    Console.WriteLine("Calificacion agregada exitosamente. Si no desea agregar mas, escriba la letra n");
                                    _stop = Console.ReadLine();
                                } while (!string.Equals(_stop, "n", StringComparison.OrdinalIgnoreCase));
                            }
                        }
                        Console.WriteLine("Si no desea agregar otro tipo de calificacion, escriba la letra n.");
                        stopAux = Console.ReadLine();
                    } while (!string.Equals(stopAux, "n", StringComparison.OrdinalIgnoreCase));

                }
                else
                {
                    if (string.Equals(_aux, "online", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Ingrese el nombre del estudiante.");
                        _aux = Console.ReadLine();
                        _auxCounterD = 0;
                        foreach (var value in _teacher)
                        {
                            if (string.Equals(value.Assignments[_auxCounterB].OnlineStudents[_auxCounterD].Name, _aux, StringComparison.OrdinalIgnoreCase))
                            {
                                break;
                            }
                            _auxCounterD++;
                        }
                        do
                        {
                            Console.WriteLine("Agregara calificaciones de examenes o practicas");
                            _aux = Console.ReadLine();
                            if (string.Equals(_aux, "examenes", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Ingrese la calificacion.");
                                _teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[_auxCounterD].Quiz.Add(Convert.ToSingle(Console.ReadLine()));
                            }
                            else
                            {
                                if (string.Equals(_aux, "practicas", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine("Ingrese la calificacion.");
                                    _teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[_auxCounterD].Practices.Add(Convert.ToSingle(Console.ReadLine()));
                                }
                            }
                            Console.WriteLine("Si no desea agregar mas calificaciones, escriba la letra n.");
                            stopAux = Console.ReadLine();
                        } while (!string.Equals(stopAux, "n", StringComparison.OrdinalIgnoreCase));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error " + e.Message);
            }
        }

        private void ListScore()
        {
            Console.WriteLine("Ingrese el nombre del profesor que imparte la materia.");
            _aux = Console.ReadLine();
            _auxCounter = 0;
            foreach (var value in _teacher)
            {

                if (string.Equals(value.Name, _aux, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                _auxCounter++;
            }
            Console.WriteLine("Ingrese el nombre de la materia.");
            _aux = Console.ReadLine();
            _auxCounterB = 0;
            foreach (var value in _teacher)
            {
                if (string.Equals(value.Assignments[_auxCounterB].assignment, _aux, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                _auxCounterB++;
            }
            Console.WriteLine("El estudiante es OnLine o Presencial?");
            _aux = Console.ReadLine();
            if (string.Equals(_aux, "presencial", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ingrese el nombre del estudiante.");
                _aux = Console.ReadLine();
                _auxCounterD = 0;
                foreach (var value in _teacher)
                {

                    if (string.Equals(value.Assignments[_auxCounterB].RegularStudents[_auxCounterD].Name, _aux, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    _auxCounterD++;
                }
                Console.Clear();
                Console.WriteLine("Las calificaciones del estudiante son");
                Console.Write("Examenes: ");
                for (var i = 0; i < _teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[_auxCounterD].Quiz.Count; i++)
                    Console.WriteLine(_teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[_auxCounterD].Quiz[i] + " ");
                Console.WriteLine("Y su promedio de examenes es: " + (_teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[_auxCounterD].GetQuizAverageScore()));
                Console.Write("Practicas: ");
                for (var i = 0; i < _teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[_auxCounterD].Practices.Count; i++)
                    Console.WriteLine(_teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[_auxCounterD].Practices[i] + " ");
                Console.WriteLine("Y su promedio de practicas es: " + (_teacher[_auxCounter].Assignments[_auxCounterB].RegularStudents[_auxCounterD].GetPracticesAverageScore()));

            }
            else
            {
                Console.WriteLine("Ingrese el nombre del estudiante.");
                _aux = Console.ReadLine();
                _auxCounterD = 0;
                foreach (var value in _teacher)
                {
                    if (string.Equals(value.Assignments[_auxCounterB].OnlineStudents[_auxCounterD].Name, _aux, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Las calificaciones del estudiante son");
                    Console.Write("Examenes: ");
                    for (var i = 0; i < _teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[_auxCounterD].Quiz.Count; i++)
                        Console.Write(_teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[_auxCounterD].Quiz[i] + " ");
                    Console.WriteLine("Y su promedio de examenes es: " + (_teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[_auxCounterD].GetQuizAverageScore()));

                    Console.Write("Practicas: ");
                    for (var i = 0; i < _teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[_auxCounterD].Practices.Count; i++)
                        Console.Write(_teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[_auxCounterD].Practices[i] + " ");
                    Console.WriteLine("Y su promedio de practicas es: " + (_teacher[_auxCounter].Assignments[_auxCounterB].OnlineStudents[_auxCounterD].GetPracticesAverageScore()));
                }
            }
        }
    }
}

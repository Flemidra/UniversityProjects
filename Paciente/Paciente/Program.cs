using System;

namespace Paciente
{
    
    class Program
    {
        private static string _name, _disease, _aux;
        private static int _age;
        private static float _temperature;
        static void Main(string[] args)
        {
            Console.WriteLine("Buenos dias, por favor escriba su nombre a continuacion.");
            _name = Console.ReadLine();
            Console.WriteLine("Ahora, por favor introduzca su edad.");
            _aux = (Console.ReadLine());
            _age = !String.IsNullOrEmpty(_aux) ? Convert.ToInt32(_aux) : 0;
            Console.WriteLine("Cual es su temperatura actualmente?");
            _aux = Console.ReadLine();
            _temperature = !String.IsNullOrEmpty(_aux) ? Convert.ToSingle(_aux) : 0;
            Console.WriteLine("Y por ultimo. Que sintoma posee? (Dolor de Cabeza, Dolor de Estomago u otro).");
            _disease = Console.ReadLine();
            _disease = _disease.ToLower();
            Persona paciente = new Persona(_name, _disease, _age, _temperature);
            Console.WriteLine(paciente.GetDiagnostic());
            Console.ReadKey();
        }
    }
}

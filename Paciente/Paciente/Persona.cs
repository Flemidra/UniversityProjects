namespace Paciente
{
    class Persona
    {
        private string _name, _diagnostic, _disease;
        private int _age; 
        private float _temperature;
        private bool _diagnosticDetected;
        //Dolor de cabeza 1
        //Dolor de estomago 2

        public Persona(string name, string disease, int age, float temperature)
        {
            _name = name;
            _disease = disease;
            _age = age;
            _temperature = temperature;
            _diagnosticDetected = false;
            CheckForDisease();
        }

        private void CheckForDisease()
        {
            if (_temperature > 35 && _disease == "dolor de cabeza")
            {
                _diagnostic = "El paciente " + _name + " de " + _age + " años de edad. " + "Tiene gripe.";
                _diagnosticDetected = true;
            }

            if (_temperature > 38 && _disease == "dolor de estomago")
            {
                _diagnostic = "El paciente " + _name + " de " + _age + " años de edad. " + "Tiene fiebre tifoidea.";
                _diagnosticDetected = true;
            }

            if (_diagnosticDetected == false)
                _diagnostic = "Gracias, esta muy sano. Bien por ti.";
        }

        public string GetDiagnostic()
        {
            return (_diagnostic);
        }
    }
}

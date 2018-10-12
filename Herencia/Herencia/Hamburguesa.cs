namespace Herencia
{
    internal class Hamburguesa : Comida
    {
        private string _nombre;
        private float _costo;

        public Hamburguesa()
        {
            _nombre = "";
            _costo = 0;
        }

        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }
        public string GetNombre()
        {
            return _nombre;
        }
        public void SetCosto(float costo)
        {
            _costo = costo;
        }
        public float GetCosto()
        {
            return _costo;
        }
    }
}

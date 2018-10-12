namespace Constructores
{
    class Empleado
    {
        private string _nombre;
        private int _nEmpleado;

        public Empleado(string nombre, int nEmpleado)
        {
            this._nombre = nombre;
            this._nEmpleado = nEmpleado;
        }
        public Empleado(int NEmpleado)
        {
            this._nEmpleado = NEmpleado;
        }
        public Empleado()
        {
            _nEmpleado = 0;
            _nombre = " ";
        }

        public string GetNombre()
        {
            return (_nombre);
        }

        public int GetNEmpleado()
        {
            return (_nEmpleado);
        }
    }
}

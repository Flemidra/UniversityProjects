namespace Herencia
{
    class Comida
    {
        private int _cantidadComida;

        public Comida()
        {
            _cantidadComida = 0;
        }

        public void SetCandidadComida(int cantidadComida)
        {
            _cantidadComida = cantidadComida;
        }

        public int GetCantidadComida()
        {
            return _cantidadComida;
        }
    }
}

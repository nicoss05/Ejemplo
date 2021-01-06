namespace Ejemplo
{
    class Iva
    {
        private const decimal IvaNormal = 0.12m;
        public decimal PorcentajeIva
        {
            get
            {
                return IvaNormal;
            }
        }

        public decimal CalcularIva(decimal importe)
        {
            return importe * IvaNormal;
        }
    }
}

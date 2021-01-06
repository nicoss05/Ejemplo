namespace Ejemplo
{
    class Deduccion
    {
        private readonly decimal porcentajeDeduccion;

        public Deduccion(decimal porcentaje)
        {
            porcentajeDeduccion = porcentaje;
        }

        public decimal CalcularDeduccion(decimal importe)
        {
            return (importe * porcentajeDeduccion) / 100;
        }
    }
}


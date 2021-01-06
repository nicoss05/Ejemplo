using System;

namespace Ejemplo
{
    class Factura
    {
        public string Codigo { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal ImporteFactura { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteDeduccion { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDeduccion { get; set; }


        // Método que calcula el total de la factura
        public void CalcularTotal()
        {
            // Calculamos la deducción
            ImporteDeduccion = (ImporteFactura * PorcentajeDeduccion) / 100;
            // Calculamos el IVA
            ImporteIVA = ImporteFactura * 0.16m;
            // Calculamos el total
            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIVA;
        }
    }
}
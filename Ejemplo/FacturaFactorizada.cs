using System;

namespace Ejemplo
{
    class FacturaFactorizada
    {
        public string Codigo { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal ImporteFactura { get; set; }
        public decimal ImporteIva { get; set; }
        public decimal ImporteDeduccion { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDeduccion { get; set; }

        // Método que calcula el total de la factura
        public void CalcularTotal()
        {
            // Calculamos la deducción
            Deduccion deduccion = new Deduccion(PorcentajeDeduccion);
            ImporteDeduccion = deduccion.CalcularDeduccion(ImporteFactura);
            // Calculamos el IVA
            Iva iva = new Iva();
            ImporteIva = iva.CalcularIva(ImporteFactura);
            // Calculamos el total
            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIva;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr_web_car.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleVentas
    {
        public int SellID { get; set; }
        public string Vehiculo { get; set; }
        public string Marca { get; set; }
        public decimal PrecioOriginal { get; set; }
        public decimal SellPrice { get; set; }
        public string Vendedor { get; set; }
        public string CedulaVendedor { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCC { get; set; }
        public System.DateTime SellDate { get; set; }
        public string TypePay { get; set; }
        public decimal Comission { get; set; }
    }
}

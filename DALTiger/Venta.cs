//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALTiger
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int Id { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> VendedorID { get; set; }
        public Nullable<int> TipoVentaID { get; set; }
        public Nullable<int> TarjetaID { get; set; }
        public Nullable<int> TipoDePagoID { get; set; }
        public Nullable<int> VentaEnvioID { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string ObservacionesVenta { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public Nullable<int> ChangedBy { get; set; }
    }
}

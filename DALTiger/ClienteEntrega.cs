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
    
    public partial class ClienteEntrega
    {
        public int Id { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<int> DireccionID { get; set; }
        public Nullable<int> TelefonoID { get; set; }
        public Nullable<int> EmailID { get; set; }
        public Nullable<int> ViaEntregaID { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public Nullable<int> ChangedBy { get; set; }
    }
}

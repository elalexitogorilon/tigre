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
    
    public partial class SocialMedia
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SocialTypeId { get; set; }
        public string SocialMediaAddress { get; set; }
        public string Alter { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public string ChangedBy { get; set; }
    
        public virtual SocialType SocialType { get; set; }
        public virtual Account Account { get; set; }
    }
}

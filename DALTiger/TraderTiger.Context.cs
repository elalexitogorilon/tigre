﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TraderTigerContainer : DbContext
    {
        public TraderTigerContainer()
            : base("name=TraderTigerContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountAddress> AccountAddresses { get; set; }
        public virtual DbSet<AccountCredential> AccountCredentials { get; set; }
        public virtual DbSet<AccountPayment> AccountPayments { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<EmailAccount> EmailAccounts { get; set; }
        public virtual DbSet<EmailType> EmailTypes { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<TraderBuy> TraderBuys { get; set; }
        public virtual DbSet<TraderSell> TraderSells { get; set; }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrompRepositories.Services.EntityService;

namespace TigerUnittest
{
    [TestClass]
    public class Paymenttype
    {
        //[TestMethod]
        //public void Insertyoepayment()
        //{
        //    PaymentTypes pt = new PaymentTypes();

        //    pt.InsertPaymenttype(new DALTiger.PaymentType { TypePayment = "Credit Card", Created = DateTime.Now, CreatedBy = "SA", Changed = null, ChangedBy = null });
        //    pt.InsertPaymenttype(new DALTiger.PaymentType { TypePayment = "Pay Pal", Created = DateTime.Now, CreatedBy = "SA", Changed = null, ChangedBy = null });
        //}


        [TestMethod]
        public void InsertEmailtypes()
        {
            EmailTypes pt = new EmailTypes();

            pt.InsertEmailTypes(new DALTiger.EmailType { Type = "Business", Created = DateTime.Now, CreatedBy = "SA", Changed = null, ChangedBy = null });
            pt.InsertEmailTypes(new DALTiger.EmailType { Type = "Home", Created = DateTime.Now, CreatedBy = "SA", Changed = null, ChangedBy = null });
            pt.InsertEmailTypes(new DALTiger.EmailType { Type = "Personal", Created = DateTime.Now, CreatedBy = "SA", Changed = null, ChangedBy = null });
            pt.InsertEmailTypes(new DALTiger.EmailType { Type = "School", Created = DateTime.Now, CreatedBy = "SA", Changed = null, ChangedBy = null });
        }
    }
}



using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
   public class PaymentTypes
    {

        private IBaseRepository<PaymentType> paymenttyperepo;

        public PaymentTypes(IBaseRepository<PaymentType> paymenttypeEmail)
        {
            paymenttyperepo = paymenttypeEmail;
        }

        public PaymentTypes()
        {
            paymenttyperepo = new Repository<PaymentType>();
        }


        public IQueryable<PaymentType> GetEmails()
        {
            return paymenttyperepo.All();
        }

        public PaymentType GetPaymentType(int id)
        {
            return paymenttyperepo.Find(x => x.Id == id);
        }

        public void InsertPaymenttype(PaymentType entity)
        {
            paymenttyperepo.Create(entity);
            paymenttyperepo.Save();
        }

        public void UpdatePaymenttype(PaymentType entity)
        {
            paymenttyperepo.Update(entity);
            paymenttyperepo.Save();
        }

        public void DeletePaymenttype(PaymentType entity)
        {
            paymenttyperepo.Delete(entity);
            paymenttyperepo.Save();
        }
    }
}

using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class AccountPayments : ContextConnection, IAccountPayments
    {
        private IBaseRepository<AccountPayment> AccountPaymentrepo;

        public AccountPayments(IBaseRepository<AccountPayment> inputrepo)
        {
            AccountPaymentrepo = inputrepo;
        }

        public AccountPayments()
        {
            AccountPaymentrepo = new Repository<AccountPayment>(Context);
        }


        public IQueryable<AccountPayment> GetAccountPayments()
        {
            return AccountPaymentrepo.All();
        }

        public AccountPayment GetAccountPayment(int id)
        {
            return AccountPaymentrepo.Find(x => x.Id == id);
        }

        public void InsertAccountPayment(AccountPayment entity)
        {
            AccountPaymentrepo.Create(entity);
            AccountPaymentrepo.Save();
        }

        public void UpdateAccountPayment(AccountPayment entity)
        {
            AccountPaymentrepo.Update(entity);
            Save();
        }

        public void DeleteAccountPayment(AccountPayment entity)
        {
            AccountPaymentrepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            AccountPaymentrepo.Save();
        }
    }
}
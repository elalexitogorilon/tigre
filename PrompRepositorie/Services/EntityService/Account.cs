using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class Accounts:ContextConnection, IAccount
    {
        private IBaseRepository<Account> accountrepo;

        public Accounts(IBaseRepository<Account> inputrepo)
        {
            accountrepo = inputrepo;
        }

        public Accounts()
        {
            accountrepo = new Repository<Account>(Context);
        }


        public IQueryable<Account> GetAccounts()
        {
            return accountrepo.All();
        }

        public Account GetAccount(int id)
        {
            return accountrepo.Find(x => x.Id == id);
        }

        public void InsertAccount(Account entity)
        {
            accountrepo.Create(entity);
            accountrepo.Save();
        }

        public void UpdateAccount(Account entity)
        {
            accountrepo.Update(entity);
            Save();
        }

        public void DeleteAccount(Account entity)
        {
            accountrepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            accountrepo.Save();
        }
    }
}

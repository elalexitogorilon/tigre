using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class AccountStatus: ContextConnection, IAccountStatus
    {
        private IBaseRepository<AccountStatu> accountStatusrepo;

        public AccountStatus(IBaseRepository<AccountStatu> AccountStatu)
        {
            accountStatusrepo = AccountStatu;
        }

        public AccountStatus()
        {
            accountStatusrepo = new Repository<AccountStatu>(Context);
        }


        public IQueryable<AccountStatu> GetAccountStatus()
        {
            return accountStatusrepo.All();
        }

        public System.Collections.Generic.IList<AccountStatu> MyTypes()
        {
            var test = accountStatusrepo.All().ToList();
            return test;
        }

        public AccountStatu GetAccountStatus(int id)
        {
            return accountStatusrepo.Find(x => x.Id == id);
        }

        public void InsertAccountStatus(AccountStatu entity)
        {
            accountStatusrepo.Create(entity);
            accountStatusrepo.Save();
        }

        public void UpdateAccountStatus(AccountStatu entity)
        {
            accountStatusrepo.Update(entity);
            accountStatusrepo.Save();
        }

        public void DeleteAccountStatus(AccountStatu entity)
        {
            accountStatusrepo.Delete(entity);
            accountStatusrepo.Save();
        }
        public void Save()
        {
            accountStatusrepo.Save();
        }
    }
}

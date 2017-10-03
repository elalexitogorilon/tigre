using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class AccountAddresss : ContextConnection, IAccountAddresses
    {
        private IBaseRepository<AccountAddress> AccountAddressrepo;

        public AccountAddresss(IBaseRepository<AccountAddress> inputrepo)
        {
            AccountAddressrepo = inputrepo;
        }

        public AccountAddresss()
        {
            AccountAddressrepo = new Repository<AccountAddress>(Context);
        }


        public IQueryable<AccountAddress> GetAccountAddress()
        {
            return AccountAddressrepo.All();
        }

        public AccountAddress GetAccountAddress(int id)
        {
            return AccountAddressrepo.Find(x => x.Id == id);
        }

        public void InsertAccountAddress(AccountAddress entity)
        {
            AccountAddressrepo.Create(entity);
            AccountAddressrepo.Save();
        }

        public void UpdateAccountAddress(AccountAddress entity)
        {
            AccountAddressrepo.Update(entity);
            Save();
        }

        public void DeleteAccountAddress(AccountAddress entity)
        {
            AccountAddressrepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            AccountAddressrepo.Save();
        }
    }
}
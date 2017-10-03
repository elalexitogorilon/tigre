using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IAccountAddresses
    {
        IQueryable<AccountAddress> GetAccountAddress();
        AccountAddress GetAccountAddress(int id);
        void InsertAccountAddress(AccountAddress entity);
        void UpdateAccountAddress(AccountAddress entity);
        void DeleteAccountAddress(AccountAddress entity);
        void Save();
    }
}
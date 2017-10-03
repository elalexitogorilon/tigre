using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public interface IAccount
    {
        IQueryable<Account> GetAccounts();
        Account GetAccount(int id);
        void InsertAccount(Account entity);
        void UpdateAccount(Account entity);
        void DeleteAccount(Account entity);
        void Save();
    }
}

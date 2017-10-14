using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    interface IAccountStatus
    {
        IQueryable<AccountStatu> GetAccountStatus();
        AccountStatu GetAccountStatus(int id);
        void InsertAccountStatus(AccountStatu entity);
        void UpdateAccountStatus(AccountStatu entity);
        void DeleteAccountStatus(AccountStatu entity);
        void Save();
    }
}

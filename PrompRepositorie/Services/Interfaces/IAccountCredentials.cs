using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IAccountCredentials
    {
        IQueryable<AccountCredential> GetAccountCredential();
        AccountCredential GetAccountCredential(int id);
        void InsertAccountCredential(AccountCredential entity);
        void UpdateAccountCredential(AccountCredential entity);
        void DeleteAccountCredential(AccountCredential entity);
        void Save();
    }
}
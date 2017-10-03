using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IAccountPayments
    {
        IQueryable<AccountPayment> GetAccountPayments();
        AccountPayment GetAccountPayment(int id);
        void InsertAccountPayment(AccountPayment entity);
        void UpdateAccountPayment(AccountPayment entity);
        void DeleteAccountPayment(AccountPayment entity);
        void Save();
    }
}
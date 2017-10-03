using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IEmailAccount
    {
        IQueryable<EmailAccount> GetEmailAccounts();
        EmailAccount GetEmailAccount(int id);
        void InsertEmailAccount(EmailAccount entity);
        void UpdateEmailAccount(EmailAccount entity);
        void DeleteEmailAccount(EmailAccount entity);
        void Save();
    }
}
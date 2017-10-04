using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IEmailType
    {
         
        IQueryable<EmailType> GetEmailTypes();
        EmailType GetEmailTypes(int id);
        void InsertEmailTypes(EmailType entity);
        void UpdateEmailTypes(EmailType entity);
        void DeleteEmailTypes(EmailType entity);
    }
}

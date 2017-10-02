using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;
namespace PrompRepositories.Services.Interfaces
{
    public interface IEmail
    {
        IQueryable<Email> GetEmails();
        Email GetEmail(int id);
        void InsertEmail(Email entity);
        void UpdateEmail(Email entity);
        void DeleteEmail(Email entity);
    }
}

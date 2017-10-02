using System.Linq;
using DAL.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;


namespace PrompRepositories.Services.EntityService
{
    public class Emails : ContextConnection, IEmail
    {
        private IBaseRepository<Email> emailrepo;

        public Emails(IBaseRepository<Email> Email)
        {
            emailrepo = Email;
        }

        public Emails()
        {
            emailrepo = new Repository<Email>(Context);
        }


        public IQueryable<Email> GetEmails()
        {
            return emailrepo.All();
        }

        public Email GetEmail(int id)
        {
            return emailrepo.Find(x => x.ID== id);
        }

        public void InsertEmail(Email entity)
        {
            emailrepo.Create(entity);
            emailrepo.Save();
        }

        public void UpdateEmail(Email entity)
        {
            emailrepo.Update(entity);
            emailrepo.Save();
        }

        public void DeleteEmail(Email entity)
        {
            emailrepo.Delete(entity);
            emailrepo.Save();
        }
    }
}

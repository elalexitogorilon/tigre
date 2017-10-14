using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class EmailAccounts: ContextConnection, IEmailAccount
    {
        private IBaseRepository<EmailAccount> emailsrepo;

        public EmailAccounts(IBaseRepository<EmailAccount> Email)
        {
            emailsrepo = Email;
        }

        public EmailAccounts()
        {
            emailsrepo = new Repository<EmailAccount>(Context);
        }


        public IQueryable<EmailAccount> GetEmailAccounts()
        {
            return emailsrepo.All();
        }

        public System.Collections.Generic.IList<EmailAccount> MyTypes()
        {
            var test = emailsrepo.All().ToList();
            return test;
        }

        public EmailAccount GetEmailAccount(int id)
        {
            return emailsrepo.Find(x => x.Id == id);
        }

        public void InsertEmailAccount(EmailAccount entity)
        {
            emailsrepo.Create(entity);
            emailsrepo.Save();
        }

        public void UpdateEmailAccount(EmailAccount entity)
        {
            emailsrepo.Update(entity);
            emailsrepo.Save();
        }

        public void DeleteEmailAccount(EmailAccount entity)
        {
            emailsrepo.Delete(entity);
            emailsrepo.Save();
        }

        public void Save()
        {
            emailsrepo.Save();
        }
    }
}

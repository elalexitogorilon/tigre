using System.Linq;
using System.Collections;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;


namespace PrompRepositories.Services.EntityService
{
    public class EmailTypes: ContextConnection, IEmailType
    {
        private IBaseRepository<EmailType> emailtypesrepo;

        public EmailTypes(IBaseRepository<EmailType> Email)
        {
            emailtypesrepo = Email;
        }

        public EmailTypes()
        {
            emailtypesrepo = new Repository<EmailType>(Context);
        }


        public IQueryable<EmailType> GetEmailTypes()
        {
            return emailtypesrepo.All();
        }

        public System.Collections.Generic.IList<EmailType> MyTypes()
        {
            var test = emailtypesrepo.All().ToList();
            return test;
        }

        public EmailType GetEmailTypes(int id)
        {
            return emailtypesrepo.Find(x => x.Id == id);
        }

        public void InsertEmailTypes(EmailType entity)
        {
            emailtypesrepo.Create(entity);
            emailtypesrepo.Save();
        }

        public void UpdateEmailTypes(EmailType entity)
        {
            emailtypesrepo.Update(entity);
            emailtypesrepo.Save();
        }

        public void DeleteEmailTypes(EmailType entity)
        {
            emailtypesrepo.Delete(entity);
            emailtypesrepo.Save();
        }
    }
}


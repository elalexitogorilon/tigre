using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class AccountCredentials : ContextConnection, IAccountCredentials
    {
        private IBaseRepository<AccountCredential> accountCredentialrepo;

        public AccountCredentials(IBaseRepository<AccountCredential> inputrepo)
        {
            accountCredentialrepo = inputrepo;
        }

        public AccountCredentials()
        {
            accountCredentialrepo = new Repository<AccountCredential>(Context);
        }


        public IQueryable<AccountCredential> GetAccountCredential()
        {
            return accountCredentialrepo.All();
        }

        public AccountCredential GetAccountCredential(int id)
        {
            return accountCredentialrepo.Find(x => x.Id == id);
        }

        public AccountCredential GetAccountCredentialByUserId(string id)
        {
            return accountCredentialrepo.Find(x => x.UserID.Contains (id));
        }

        public void InsertAccountCredential(AccountCredential entity)
        {
            accountCredentialrepo.Create(entity);
            accountCredentialrepo.Save();
        }

        public void UpdateAccountCredential(AccountCredential entity)
        {
            accountCredentialrepo.Update(entity);
            Save();
        }

        public void DeleteAccountCredential(AccountCredential entity)
        {
            accountCredentialrepo.Delete(entity);
            Save();
        }

        public void Save()
        {
            accountCredentialrepo.Save();
        }
    }
}
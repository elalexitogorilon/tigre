using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrompRepositories.Services.EntityService;
using PrompRepositories.Services.Interfaces;
using DALTiger;


namespace BusinessObjects
{
    public class BOUserAccount
    {
       public BOResults UserAccount(string UserName, string UserEmail, string UserPassword)
        {
            try
            {   
                if (!AccountNoExit(UserName))
                {
                    throw new Exception ("Account : '" + UserName +  "' already exist, please try different user id");
                }
                var status = new AccountStatus();
                var st = status.GetAccountStatus(1);
                var newpersonacount = new DALTiger.Account
                {
                    Person = new DALTiger.Person { Name = UserName, LastName = "NA", Created = DateTime.Now, CreatedBy = "sa" },
                    AccountStatu = st,
                    Created = DateTime.Now
                };

                var newperson = new Accounts();

                newperson.InsertAccount(newpersonacount);


                var accountcredentials = new DALTiger.AccountCredential
                {
                    AccountId = newpersonacount.Id,
                    UserID = UserName,
                    Password = UserPassword,
                    Created = DateTime.Now,
                    CreatedBy = "sa"
                };

                var accountcred = new AccountCredentials();
                accountcred.InsertAccountCredential(accountcredentials);

                var emailaccount = new DALTiger.EmailAccount
                {
                    AccountId = newpersonacount.Id,
                    Email = UserEmail,
                    EmailType = new PrompRepositories.Services.EntityService.EmailTypes().GetEmailTypes(3),//personal
                    Created = DateTime.Now,
                    CreatedBy = "sa"
                };

                var newemail = new EmailAccounts();
                newemail.InsertEmailAccount(emailaccount);
                return new BOResults { Error = string.Empty, Message = string.Empty, Result = true };
            }
            catch (Exception error)
            {

                return new BOResults { Error = error.InnerException.ToString(), Message = error.Message, Result = false };

            }
        }

        public bool AccountNoExit(string userid)            
        {
            IAccountCredentials checkforcredentials = new AccountCredentials();
            #region MyRegion
            //var first = checkforcredentials.GetAccountCredential(1);

            //var getall = checkforcredentials.GetAccountCredential();

            //var getthefirst = getall.FirstOrDefault(x => x.UserID.Contains(userid)); 
            #endregion
            var existaccount = checkforcredentials.GetAccountCredentialByUserId(userid);
            if (existaccount == null)
            {// account does  exist
                return true;
            }           
            return false; // account exist
        }
    }
}

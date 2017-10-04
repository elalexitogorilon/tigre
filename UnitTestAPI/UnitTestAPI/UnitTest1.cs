using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TigerAPI.Controllers;
using System.Collections;

namespace UnitTestAPI
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void EmailTypes()
        //{
        //    var testapi = new EmailTypesController();
        //    var test = testapi.Get();
        //}

        //[TestMethod]
        //public void EmailAccounts()
        //{
        //    var cred = new UserCredentialsController();
        //    var test = cred.Get(1);
        //}

        //[TestMethod]
        //public void EmailPerson()
        //{
        //    var cred = new PersonController();             
        //    cred.Post(new DALTiger.Person { Name = "David", LastName = "Miranda", Created = DateTime.Now });
        //}
        [TestMethod]
        public void Account()
        {
            var personacc = new PersonAccountController();

            var newpersonacount = new DALTiger.Account { Person =  new DALTiger.Person { Name ="Rob", LastName = "Wilson", Created = DateTime.Now},Created=DateTime.Now };

            personacc.Post(newpersonacount);
        }

    }
}

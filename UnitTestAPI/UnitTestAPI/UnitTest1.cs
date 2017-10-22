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



        //[TestMethod]
        //public void Account()
        //{
        //    var personacc = new PersonAccountController();

        //    var newpersonacount = new DALTiger.Account { Person = new DALTiger.Person { Name = "Rob", LastName = "Wilson", Created = DateTime.Now }, Created = DateTime.Now };

        //    personacc.Post(newpersonacount);
        //}



        //[TestMethod]
        //public void UserCredentials()
        //{
        //    //var personacc = new UserCredentialsController();
        //    //var response = personacc.PostData("DavidM", "DavidM@arvixe.com", "ertessd");

        //    var personacc1 = new UserCredentialsController();
        //    var response1 = personacc1.PostData("AnaLilia", "AnaLilia@arvixe.com", "erpasdsdsd");

        //    personacc1 = new UserCredentialsController();
        //    response1 = personacc1.PostData("AnaLilia", "AnaLilia@arvixe.com", "erpasdsdsd");

        //    var personacc2 = new UserCredentialsController();
        //    var response3 = personacc2.PostData("RickyH", "RickyHud@arvixe.com", "Mystuff");
        //}



       // [TestMethod]
       // public void LoadUserCredentials()
       // {
       //     var personacc = new UserCredentialsController();
       //     var response = personacc.PostData("DaveChappell", "DaveChappedfdfll@arvixe.com", "ersdhshtessd");

       // //    var personacc1 = new UserCredentialsController();
       // //    var response1 = personacc1.PostData("RobinWwil", "RobinWwil@arvixe.com", "ertessd");

       // //    var personacc2 = new UserCredentialsController();
       // //    var response3 = personacc2.PostData("Rickahrd", "Richard@arvixe.com", "Mystuff");
       // //    personacc = new UserCredentialsController();
       // //    response = personacc.PostData("EduardC", "EduardC@arvixe.com", "ertessd");

       // //    personacc1 = new UserCredentialsController();
       // //    response1 = personacc1.PostData("EstherM", "EstherM@arvixe.com", "EstherMtessd");

       // //    personacc2 = new UserCredentialsController();
       // //    response3 = personacc2.PostData("HelenVe", "HelenVe@arvixe.com", "Mystuff");


       // //    personacc = new UserCredentialsController();
       // //    response = personacc.PostData("AndyGarcia", "AndyGarcia@arvixe.com", "sddfsdertessd");

       // //    personacc1 = new UserCredentialsController();
       // //    response1 = personacc1.PostData("JanetV", "JanetV@arvixe.com", "JanetVMtessd");

       // //    personacc2 = new UserCredentialsController();
       // //    response3 = personacc2.PostData("MarleneV", "MarleneV@arvixe.com", "Mystuff");


       // //    personacc = new UserCredentialsController();
       // //    response = personacc.PostData("CharlyBar", "CharlyBar@arvixe.com", "CharlyBarertessd");

       // //    personacc1 = new UserCredentialsController();
       // //    response1 = personacc1.PostData("GueraN", "GueraN@arvixe.com", "GueraNMtessd");

       // //    personacc2 = new UserCredentialsController();
       // //    response3 = personacc2.PostData("DarkVader", "DarkVader@arvixe.com", "DarkVaderMystuff");


       // //    personacc = new UserCredentialsController();
       // //    response = personacc.PostData("BoJackson", "BoJackson@arvixe.com", "BoJacksonrtessd");

       // //    personacc1 = new UserCredentialsController();
       // //    response1 = personacc1.PostData("MarcusAllen", "MarcusAllen@arvixe.com", "MarcusAllenVMtessd");

       // //    personacc2 = new UserCredentialsController();
       // //    response3 = personacc2.PostData("AlDavis", "AlDavis@arvixe.com", "AlDavisMystuff");

       // //    ////
       // //    personacc = new UserCredentialsController();
       // //    response = personacc.PostData("RafaMarquez", "RafaMarquez@arvixe.com", "RafaMarquezertessd");

       // //    personacc1 = new UserCredentialsController();
       // //    response1 = personacc1.PostData("JohnWalsh", "JohnWalsh@arvixe.com", "JohnWalshtessd");

       // //    personacc2 = new UserCredentialsController();
       // //    response3 = personacc2.PostData("BobLee", "BobLee@arvixe.com", "BobLeeff");


       // //    personacc = new UserCredentialsController();
       // //    response = personacc.PostData("StalloneS", "StalloneS@arvixe.com", "sddfsdertessd");

       // //    personacc1 = new UserCredentialsController();
       // //    response1 = personacc1.PostData("ArnoldS", "ArnoldS@arvixe.com", "ArnoldSMtessd");

       // //    personacc2 = new UserCredentialsController();
       // //    response3 = personacc2.PostData("Terminatora", "Terminatora@arvixe.com", "TerminatoraMystuff");


       // //    personacc = new UserCredentialsController();
       // //    response = personacc.PostData("HomerSimpson", "HomerSimpson@arvixe.com", "Csdsdarertessd");

       // //    personacc1 = new UserCredentialsController();
       // //    response1 = personacc1.PostData("Bartsimpson", "Bartsimpson@arvixe.com", "cdfdfdf");

       // //    personacc2 = new UserCredentialsController();
       // //    response3 = personacc2.PostData("lisasimpsom", "lisasimpsom@arvixe.com", "DarkVaderMystuff");


       // //    personacc = new UserCredentialsController();
       // //    response = personacc.PostData("MagiSimpson", "MagiSimpson@arvixe.com", "MagiSimpsonsdsd");

       // //    personacc1 = new UserCredentialsController();
       // //    response1 = personacc1.PostData("charlesabrazado", "charlesabrazado@arvixe.com", "Mdfdfdfessd");

       // //    personacc2 = new UserCredentialsController();
       // //    response3 = personacc2.PostData("AaronD", "AaronD@arvixe.com", "dfdfdfdfdf");

       //}


    }

    [TestClass]
    public class butrading
    {
        //[TestMethod]
        //public void buyingtrdes()
        //{
        //    var buystuff = new BuyController();
        //    var response = buystuff.Buy(1, "INTC", 10, 32);

        //    response = buystuff.Buy(1, "AAPL", 3000, 159);

        //    response = buystuff.Buy(1, " AAL ", 500, 159);


        //     response = buystuff.Buy(2, "INTC", 5, 32);

        //    response = buystuff.Buy(2, "AAPL", 300, 159);

        //    response = buystuff.Buy(2, " AAL ", 50, 52);


        //    response = buystuff.Buy(3, "INTC", 50, 32);

        //    response = buystuff.Buy(3, "AAPL", 30, 159);

        //    response = buystuff.Buy(3, " AAL ", 23, 52);

        //}


        //[TestMethod]
        //public void sellingtrdes()
        //{
        //    var Sellstuff = new SellController();
        //    var response = Sellstuff.Sell(1, "INTC", 10, 32);

        //    //response = Sellstuff.Sell(1, "AAPL", 3000, 159);

        //    //response = Sellstuff.Sell(1, " AAL ", 500, 159);


        //    //response = Sellstuff.Sell(2, "INTC", 5, 32);

        //    //response = Sellstuff.Sell(2, "AAPL", 300, 159);

        //    //response = Sellstuff.Sell(2, " AAL ", 50, 52);


        //    //response = Sellstuff.Sell(3, "INTC", 50, 32);

        //    //response = Sellstuff.Sell(3, "AAPL", 30, 159);

        //    //response = Sellstuff.Sell(3, " AAL ", 23, 52);

        //}



        [TestMethod]
        public void Following()
        {
            var Sellstuff = new FollowController();
            var response = Sellstuff.Following( 4,  3); // account 1 follows account3

        }

    }

}

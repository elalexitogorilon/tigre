using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PrompRepositories.Services.EntityService;
using PrompRepositories.Services.Interfaces;
using DALTiger;
using BusinessObjects;


namespace TigerAPI.Controllers
{
    
    [RoutePrefix("api/UserCredentials")]
    public class UserCredentialsController : ApiController
    {
        //http://localhost/TigerAPI/api/UserCredentials/Dataok/cuevitas@gmail.com/passwordtest in local host , remove the IIS mvd and set the correct Login for ther database 
        #region MyRegion
        // GET: api/UserCredentials
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/UserCredentials/5
        //[HttpGet]
        //public string Get(string UserName)
        //{
        //    var values = " teh user name is " + UserName;
        //    return values;
        //}


        //[HttpGet]
        //public string Getsname()
        //{
        //    var values = " teh user name is Myname  " ;
        //    return values;
        //} 
        #endregion

        [HttpPost]
        public HttpResponseMessage PostData(string UserName, string UserEmail, string UserPassword)
        {
            var configuration = new HttpConfiguration();
            HttpRequestMessage request = new HttpRequestMessage();
            var createdaccount = new BOUserAccount().UserAccount(UserName, UserEmail, UserPassword);
            return request.CreateResponse(HttpStatusCode.OK
                                        , "Post request"
                                        , configuration);
        }


        [HttpGet]
        public HttpResponseMessage GetData(string UserName, string UserEmail, string UserPassword)
        {
            var configuration = new HttpConfiguration();
            HttpRequestMessage request = new HttpRequestMessage();
            var createdaccount = new BOUserAccount().UserAccount(UserName, UserEmail, UserPassword);
            return request.CreateResponse(HttpStatusCode.OK
                                        , createdaccount
                                        , configuration);
        }
        //[HttpPut]
        //public HttpResponseMessage PostData(string UserName, string UserEmail, string UserPassword)
        //{
        //    var configuration = new HttpConfiguration();
        //    HttpRequestMessage request = new HttpRequestMessage();
        //    var createdaccount = new BOUserAccount().UserAccount(UserName, UserEmail, UserPassword);
        //    return request.CreateResponse(HttpStatusCode.OK
        //                                , createdaccount
        //                                , configuration);
        //}



    }
}

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
   
    [RoutePrefix("api/Follow")]
    public class FollowController : ApiController
    {
        #region MyRegion
        //[HttpPost]
        //public bool AddEmpDetails()
        //{
        //    return true;
        //    //write insert logic  

        //}

        //[HttpGet]
        //public string GetEmpDetails()
        //{
        //    return "test the get";

        //}



        //[HttpPut]
        ////[Route("Follower")]
        //public HttpResponseMessage Follower()
        //{
        //    var configuration = new HttpConfiguration();
        //    HttpRequestMessage request = new HttpRequestMessage();
        //    var createdaccount = "test the put";
        //    return request.CreateResponse(HttpStatusCode.OK
        //                                , createdaccount
        //                                , configuration);
        //}

        //[HttpPut]
        ////[Route("Follower")]
        //public HttpResponseMessage Follower(int id)
        //{
        //    var configuration = new HttpConfiguration();
        //    HttpRequestMessage request = new HttpRequestMessage();
        //    var createdaccount = "test the put " + id;
        //    return request.CreateResponse(HttpStatusCode.OK
        //                                , createdaccount
        //                                , configuration);
        //} 
        #endregion
        [HttpPut]        
        public HttpResponseMessage Following(int accountid, int followaccountid)
        {
            var configuration = new HttpConfiguration();
            HttpRequestMessage request = new HttpRequestMessage();
            var createdaccount = new BOFollowing().Following(accountid, followaccountid);
            return request.CreateResponse(HttpStatusCode.OK
                                        , createdaccount
                                        , configuration);
        }
    }
}

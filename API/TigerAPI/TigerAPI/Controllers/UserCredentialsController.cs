using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PrompRepositories.Services.EntityService;
using PrompRepositories.Services.Interfaces;
using DALTiger;


namespace TigerAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/EmailTypes")]
    public class UserCredentialsController : ApiController
    {
        // GET: api/UserCredentials
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserCredentials/5
        [Route("GetUserById")]
        public AccountCredential Get(int id)
        {
            IAccountCredentials credential = new AccountCredentials();
            return credential.GetAccountCredential(id);
        }

        // POST: api/UserCredentials
        public void Post([FromBody]string value)
        {
        }

       

        // DELETE: api/UserCredentials/5
        public void Delete(int id)
        {

        }
    }
}

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
    [RoutePrefix("api/PersonAccount")]
    public class PersonAccountController : ApiController
    {
        // GET: api/PersonAccount

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PersonAccount/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PersonAccount
        public void Post(DALTiger.Account account)
        {
            var newaccount = new Accounts();
            newaccount.InsertAccount(account);
        }

        // PUT: api/PersonAccount/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PersonAccount/5
        public void Delete(int id)
        {
        }
    }
}

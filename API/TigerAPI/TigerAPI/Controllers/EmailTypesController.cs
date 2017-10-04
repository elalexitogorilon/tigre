using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PrompRepositories.Services.Interfaces;
using PrompRepositories.Services.EntityService;
using DALTiger;

namespace TigerAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/EmailTypes")]
    public class EmailTypesController : ApiController
    {
        // GET api/<controller>
        [Route("GetTypes")]
        public  List<EmailType> Get()
        {
            EmailTypes emailtypes = new EmailTypes();            
            return emailtypes.MyTypes().ToList();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
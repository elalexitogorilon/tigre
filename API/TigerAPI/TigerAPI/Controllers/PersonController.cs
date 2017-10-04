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
    [RoutePrefix("api/Person")]
    public class PersonController : ApiController
    {
        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Person/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        public void Post(Person person)
        {
            var newperson = new Persons();
            newperson.InsertPerson(person);
        }

        // PUT: api/Person/5
        public void Put(Person person )
        {
            var newperson = new Persons();
            newperson.InsertPerson(person);
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}

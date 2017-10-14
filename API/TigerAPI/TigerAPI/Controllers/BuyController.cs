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
    [Authorize]
    [RoutePrefix("api/Buy")]
    public class BuyController : ApiController
    {
        [Route("TradeBuy")]
        public HttpResponseMessage Buy(int acountid, string symbol, int quantity, decimal value)
        {
            var configuration = new HttpConfiguration();
            HttpRequestMessage request = new HttpRequestMessage();
            var createdaccount = new BOBuyTrade().Buy(acountid,  symbol, quantity,  value);
            return request.CreateResponse(HttpStatusCode.OK
                                        , createdaccount
                                        , configuration);
        }
    }
}

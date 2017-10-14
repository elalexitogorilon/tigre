using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradeTigerWeb.Controllers
{
    public class MyTradesController : Controller
    {
        // GET: MyTrades
        public ActionResult Index()
        {
            return View();
        }
    }
}
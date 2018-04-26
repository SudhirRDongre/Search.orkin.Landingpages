using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Search.orkin.Landingpages.Controllers
{
    public class OrkinController : Controller
    {
        // GET: Orkin
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult PaidSearch()
        {
            return View();
        }
    }
}
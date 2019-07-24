using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace irakligdev.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Index()
        {
            return View("Search");
        }
    }
}
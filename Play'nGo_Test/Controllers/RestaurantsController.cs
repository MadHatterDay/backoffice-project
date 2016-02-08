using Play_nGo_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Play_nGo_Test.Controllers
{
    public class RestaurantsController : Controller
    {

        RestaurantsDB db = new RestaurantsDB();

        public ActionResult Index()
        {
            var mod = from r in db.Restaurants
                      select r;

            return View(mod);
        }

    }
}

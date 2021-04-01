using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [OutputCache(Duration =50000)]
        public ActionResult OutCacheTest()
        {
            return View();
        }

        [HandleError(View="CustomError")]
        public ActionResult CustomErrorDemo()
        {
            throw new Exception("Something went wrong!!!");
        }
    }
}
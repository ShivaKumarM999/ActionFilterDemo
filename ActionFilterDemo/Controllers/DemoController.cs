using ActionFilterDemo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [TrackExecutionTime]
        public ActionResult Index()
        {
            return View();
        }
        [TrackExecutionTime]
        public ActionResult Page1()
        {
            return View();
        }
        [TrackExecutionTime]
        public ActionResult Page2()
        {
            return View();
        }
        [TrackExecutionTime]
        public ActionResult Page3()
        {
            return View();
        }
        [TrackExecutionTime]
        public ActionResult Page4()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Page5()
        {
            return PartialView("_PartialDemo");
        }
        [ActionName("Shiva")]
        public ActionResult Page6()
        {
            return View();
        }

    }
}
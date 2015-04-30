using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Events.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult List()
        {
            Events.Models.EventData model = new Events.Models.EventData();
            return View(model);
        }

        public ActionResult Event(int id)
        {
            ViewBag.id = id;
            return View();
        }

    }
}

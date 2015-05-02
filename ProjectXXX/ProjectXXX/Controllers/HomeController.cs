using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectXXX.Models;

namespace ProjectXXX.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EventList()
        {
            if(!List.isDateConsists)
                List.CreateData();
            return View(List.Data);
        }
        [HttpGet]
        public ActionResult Description(int? id)
        {
            return View(List.GetEventByID((int)id));
        }
    }
}

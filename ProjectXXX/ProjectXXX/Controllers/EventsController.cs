using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectXXX.Models;

namespace ProjectXXX.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Events/

        public ActionResult EventList()
        {
            if (!DataProvider.isDateConsists)
                DataProvider.CreateData();
            return View(DataProvider.Data);
        }

        [HttpGet]
        public ActionResult Description(string id)
        {
            try
            {
                return View(DataProvider.GetEventByID(id));
            }
            catch (ArgumentOutOfRangeException)
            {
                return HttpNotFound(); 
            }
        }
    }
}

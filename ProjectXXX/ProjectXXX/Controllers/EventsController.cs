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
        [HttpGet]
        public ActionResult EventList()
        {
            if (!DataProvider.IsDateConsists)
                DataProvider.CreateData();
            return View(DataProvider.Data);
        }

        [HttpGet]
        public ActionResult Description(string id)
        {
            if (!DataProvider.IsDateConsists)
                DataProvider.CreateData();
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

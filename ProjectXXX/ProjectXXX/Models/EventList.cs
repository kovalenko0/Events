using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectXXX.Models
{
    static public class DataProvider
    {
        static public List<Event> Data { set; get; }
        static public bool isDateConsists = false;
        static public void CreateData()
        {
            Data = new List<Event>();
            Data.Add(new Event("Start of conquering of Great Britain", "Some description.", new DateTime(2015, 6, 12), new DateTime().AddDays(1), "Westminster, London , United Kingdom"));
            Data.Add(new Event("Start of conquering of France", "Some description.", new DateTime(2015, 6, 23), new DateTime().AddDays(3), "Avenue du Colonel Henri Rol-Tanguy, Paris, France"));
            Data.Add(new Event("Start of conquering of Belgium", "Some description.", new DateTime(2015, 7, 18), new DateTime().AddDays(3), "Place Jean Rey 80, Bruxelles, Belgium"));
            Data.Add(new Event("Start of conquering of Netherlands", "Some description.", new DateTime(2015, 8, 30), new DateTime().AddDays(3), "Museumstraat, 1071 Amsterdam, Netherlands"));
            isDateConsists = true;
        }
        static public Event GetEventByID(string id)
        {
            Event e = Data.Find(x => x.ID == id);
            if (e != null)
            {
                return e;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        static public bool IsIndexAllowed(int id)
        {
            if (id < Data.Count && id >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
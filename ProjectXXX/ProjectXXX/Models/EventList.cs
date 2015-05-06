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
            for (int i = 0; i < 5; i++)
            {
                Data.Add(new Event(i, "Name " + i, "Event " + i, new DateTime().AddDays(i), new DateTime().AddDays(i+1), "X" + i));
            }
            isDateConsists = true;
        }
        static public Event GetEventByID(int id)
        {
            return Data.ElementAt(id);
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
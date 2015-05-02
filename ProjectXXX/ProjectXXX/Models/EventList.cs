using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectXXX.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Name {get;set;}
        public string Description{get;set;}
        public DateTime From{get;set;}
        public DateTime To { get; set; }
        public string Location { get; set; }
        public Event(int ID, string Name, string Description, DateTime From, DateTime To, string Location)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.From = From;
            this.To = To;
            this.Location = Location;
        }
    }

    static public class List
    {
        static public List<Event> Data { set; get; }
        static public bool isDateConsists = false;
        static public void CreateData()
        {
            Data = new List<Event>();
            for (int i = 1; i <= 5; i++)
            {
                Data.Add(new Event(i, "Name " + i, "Event " + i, new DateTime().AddDays(i - 1), new DateTime().AddDays(i), "X" + i));
            }
            isDateConsists = true;
        }
        static public Event GetEventByID(int id)
        {
            return Data.ElementAt(id);
        }
    }
}
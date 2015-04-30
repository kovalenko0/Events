using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace Events.Models
{
    public class Event
    {
        public Event(int id, string name, string desc, string location)
        {
            Id = id;
            Name = name;
            Desc = desc;
            Location = location;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Location { get; set; }
    }
    public class EventData
    {
        private static List<Event> list;

        public List<Event> getEvents()
        {
            list = new List<Event>();
            for (int i=0; i<10;i++){
                list.Add(new Event(i, "Name"+i, "Desc"+i, "Location"+i));
            }
            return list;
        }

        public static Event getEvent(int id)
        {
            return list[id];
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectXXX.Models
{
    public class Event
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Location { get; set; }
        public Event(string Name, string Description, DateTime From, DateTime To, string Location)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Name = Name;
            this.Description = Description;
            this.From = From;
            this.To = To;
            this.Location = Location;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectXXX.Models
{
    public class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Location { get; set; }
        public Event(string name, string description, DateTime from, DateTime to, string location)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.Description = description;
            this.From = from;
            this.To = to;
            this.Location = location;
        }
    }
}
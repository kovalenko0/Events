using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectXXX.Models
{
    public class EventViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Location { get; set; }
        public EventViewModel()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
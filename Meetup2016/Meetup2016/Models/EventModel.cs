using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup2016.Models
{
    public class EventModel
    {
        public string EventTitle { get; set; }
        public List<EventItems> EventItems { get; set; }
    }

    public class EventItems
    {
        public string Date { get; set; }
        public string Title { get; set; }
    }
}

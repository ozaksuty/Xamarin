using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup2016.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public List<string> Category { get; set; }
    }
}

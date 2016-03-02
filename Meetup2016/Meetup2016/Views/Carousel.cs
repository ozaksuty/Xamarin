using Meetup2016.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Meetup2016.Views
{
    public class Carousel : CarouselPage
    {
        public Carousel()
        {
            Title = "Programcıdan Programcıya";
            List<EventModel> model = Provider<EventModel>.CreateModel("EventData.txt");

            foreach (EventModel item in model)
            {
                Children.Add(new Event(item));
            }
        }
    }
}

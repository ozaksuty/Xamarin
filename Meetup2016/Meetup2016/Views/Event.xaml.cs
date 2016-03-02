using Meetup2016.Models;
using Xamarin.Forms;

namespace Meetup2016.Views
{
    public partial class Event : ContentPage
    {
        public Event(EventModel model)
        {
            InitializeComponent();
            Title = "Programcıdan Programcıya";
            txtTitle.Text = model.EventTitle;
            lvEvents.ItemsSource = model.EventItems;
        }
    }
}
using Meetup2016.Models;
using Plugin.Toasts;
using System;
using Xamarin.Forms;

namespace Meetup2016.Views
{
    public partial class Menu : ContentPage
	{
        public Menu()
        {
            InitializeComponent();
            Title = "Programcıdan Programcıya";
            Icon = "menu.png";
            var data = Provider<MenuModel>.CreateModel("MenuData.txt");
            lvMenu.ItemsSource = data;
            lvMenu.ItemSelected += LvMenu_ItemSelected;
        }

        private async void LvMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MenuModel model = (MenuModel)e.SelectedItem;

            var notificator = DependencyService.Get<IToastNotificator>();
            bool tapped = await notificator.Notify(ToastNotificationType.Info,
                model.Title, "Yükleniyor...", TimeSpan.FromSeconds(1));

            var startPage = (Start)this.Parent;
            if (model.Title == "Ana Sayfa")
            {
                startPage.Detail = new NavigationPage(new Carousel());
            }
            else
            {
                startPage.Detail = new NavigationPage(new Post(model));
            }
            startPage.IsPresented = false;
        }
    }
}
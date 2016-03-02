using Meetup2016.Views;
using Xamarin.Forms;

namespace Meetup2016
{
    public class App : Application
	{
        public App()
        {
            var startPage = new Start();
            var menuPage = new Menu();
            var detailPage = new NavigationPage(new Carousel());

            detailPage.Tint = Color.FromHex("455A64");
            menuPage.Opacity = 0.85;

            startPage.Master = menuPage;
            startPage.Detail = detailPage;

            MainPage = startPage;
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

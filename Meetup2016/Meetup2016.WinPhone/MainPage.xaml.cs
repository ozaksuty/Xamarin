using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Plugin.Toasts;
using Xamarin.Forms;

namespace Meetup2016.WinPhone
{
	public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

			global::Xamarin.Forms.Forms.Init ();
            DependencyService.Register<ToastNotificatorImplementation>();
            ToastNotificatorImplementation.Init();
            LoadApplication (new Meetup2016.App ());
		}
	}
}

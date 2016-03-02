using Meetup2016.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Meetup2016.Views
{
	public partial class PostDetail : ContentPage
	{
        public PostDetail(PostModel model)
        {
            InitializeComponent();

            Title = "Programcıdan Programcıya";
            txtTitle.Text = model.Title;
            txtContent.Text = model.Content;

            if (Device.OS == TargetPlatform.Android)
            {
                stckLayout.BackgroundColor = Color.FromHex("CFD8DC");
            }
            else
            {
                stckLayout.BackgroundColor = Color.White;
            }
        }
    }
}
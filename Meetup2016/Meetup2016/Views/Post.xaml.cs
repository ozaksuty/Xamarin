using Meetup2016.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Meetup2016.Views
{
    public partial class Post : ContentPage
	{
        List<PostModel> postModel = null;
        public Post(MenuModel menuModel)
        {
            InitializeComponent();
            Title = "Programcıdan Programcıya";
            txtTitle.Text = menuModel.Title;
            postModel = Provider<PostModel>.CreateModel("PostData.txt");
            lvPost.ItemsSource = postModel.Where(x => x.Category.Contains(menuModel.Title));
        }

        public void Click_Meetup(object sender, EventArgs e)
        {
            Button postButton = (Button)sender;
            int Id = Convert.ToInt32(postButton.CommandParameter);
            var model = postModel.Where(x => x.Id == Id).SingleOrDefault();
            Navigation.PushAsync(new PostDetail(model), true);
        }
    }
}

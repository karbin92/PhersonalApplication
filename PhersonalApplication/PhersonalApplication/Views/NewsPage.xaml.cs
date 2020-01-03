using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhersonalApplication.Models;
using PhersonalApplication.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhersonalApplication.Views
{
	public partial class NewsPage : ContentPage
	{
		public NewsPage ()
		{
			InitializeComponent ();
            BindingContext = App.newsViewmodel;

        }
        private async void NewsList_TappedAsync(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            News selectedNews = (News)e.Item;
            var detailsPage = new NewsDetailsPage();
            detailsPage.BindingContext = App.newsViewmodel.GetNewsByID(selectedNews.ID);
            await this.Navigation.PushAsync(detailsPage);
        }
    }
}
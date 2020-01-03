using System;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using PhersonalApplication.Models;

namespace PhersonalApplication.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            //GetHome();
        }

        //async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new UpcomingAppointmentsPage());
        //}

        //async void GetHome()
        //{
        //    HttpClient client = new HttpClient();

        //    var response = await client.GetStringAsync("http://193.10.202.76/PhersonalklubbenREST/api/nyheters");

        //    var nyheter = JsonConvert.DeserializeObject<List<Home>>(response);

        //    //NyheterListView.ItemsSource = nyheter;

        //}


    }
}


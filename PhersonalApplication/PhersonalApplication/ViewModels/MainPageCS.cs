using PhersonalApplication.Models;
using PhersonalApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PhersonalApplication
{
    public class MainPageCS : TabbedPage
    {
        public MainPageCS()
        {
            var navigationPage = new NavigationPage(new Home ());
            navigationPage.IconImageSource = "customercard.png";


            Children.Add(new ActivitiesCS());
            Children.Add(navigationPage);
            Children.Add(new CustomerCardCS());
        }
    }
}
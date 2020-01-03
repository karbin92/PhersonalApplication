using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PhersonalApplication.ViewModels
{
    public class ActivitiesCS : ContentPage
    {
        public ActivitiesCS()
        {
            IconImageSource = "NotificationIcon.png";
            Title = "Aktiviteter";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Aktiviteter go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PhersonalApplication.ViewModels
{
    public class CustomerCardCS : ContentPage
    {
        public CustomerCardCS()
        {
            IconImageSource = "customercard.png";

            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Mitt kort här",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}


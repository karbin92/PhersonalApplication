using System;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using PhersonalApplication.Models;
using PhersonalApplication.ViewModels;

namespace PhersonalApplication.Views
{
    public partial class HomePage : ContentPage
    {
        public static MedlemskontoViewModel medlemskontoViewModel { get; set; } = new MedlemskontoViewModel();

        Medlemmar medlem = new Medlemmar();
        public HomePage()
        {
            InitializeComponent();

            medlem = App.medlemskontoViewModel.ReturnMember();

            BindingContext = medlem;
        }
    }
}


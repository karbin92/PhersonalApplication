using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PhersonalApplication.Views;
using PhersonalApplication.ViewModels;
using PhersonalApplication.Models;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PhersonalApplication
{
    public partial class App : Application
    {
        public static NewsViewmodel newsViewmodel { get; set; } = new NewsViewmodel();

        public App()
        {
            InitializeComponent();
            App.newsViewmodel.ReadNews();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

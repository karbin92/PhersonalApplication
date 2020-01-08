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
        public static MedlemskontoViewModel medlemskontoViewModel { get; set; } = new MedlemskontoViewModel();
        public static MedlemViewModel medlemViewModel { get; set; } = new MedlemViewModel();
        int id;

        public static bool IsUserLoggedIn { get; set; }
        public App()
        {
            InitializeComponent();
            App.newsViewmodel.ReadNews();
            App.medlemViewModel.ReadMembers();

           // MainPage = new NavigationPage(new MainPage());

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                // MainPage = new NavigationPage(new LoginNavigation.MainPage());
                MainPage = new NavigationPage(new MainPage());
            }
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

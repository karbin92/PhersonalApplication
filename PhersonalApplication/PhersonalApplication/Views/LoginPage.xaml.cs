using PhersonalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhersonalApplication.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public LoginPage ()
		{
        //Entry usernameEntry, passwordEntry;
        //Label messageLabel;
			InitializeComponent();

            //var toolbarItem = new ToolbarItem
            //{
            //    Text = "Sign Up"
            //};
            //toolbarItem.Clicked += OnSignUpButtonClicked;
            //ToolbarItems.Add(toolbarItem);

            //messageLabel = new Label();
            //usernameEntry = new Entry
            //{
            //    Placeholder = "username"
            //};
            //passwordEntry = new Entry
            //{
            //    IsPassword = true
            //};
            //var loginButton = new Button
            //{
            //    Text = "Login"
            //};
            //loginButton.Clicked += OnLoginButtonClicked;

            //Title = "Login";
            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.StartAndExpand,
            //    Children = {
            //        new Label { Text = "Username" },
            //        usernameEntry,
            //        new Label { Text = "Password" },
            //        passwordEntry,
            //        loginButton,
            //        messageLabel
            //    }
            //};
        }

        //async void OnSignUpButtonClicked(object sender, EventArgs e)
        //{
        //    // await Navigation.PushAsync(new SignUpPageCS());
        //}

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new Medlemskonto
            {
                Epost = usernameEntry.Text,
                Lösenord = passwordEntry.Text
            };

            var isValid = App.medlemskontoViewModel.LoginAsync(user);
            if (await isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Inloggning Misslyckades!";
                passwordEntry.Text = string.Empty;
            }
        }
    }
    
}
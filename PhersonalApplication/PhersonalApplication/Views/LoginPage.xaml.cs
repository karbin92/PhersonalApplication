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
			InitializeComponent();
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new Medlemskonto
            {
                Epost = usernameEntry.Text,
                Lösenord = passwordEntry.Text
            };

            Medlemmar loggedInMember = new Medlemmar();
           loggedInMember  = await App.medlemskontoViewModel.LoginAsync(user);
            var isValid = false;

            if (loggedInMember != null)
            {
                isValid = true;
            }
            else
            {

            }

            if (isValid)
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
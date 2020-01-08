using PhersonalApplication.Models;
using PhersonalApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhersonalApplication.Views
{
    public partial class CustomerCard : ContentPage
    {
       
        public static MedlemskontoViewModel medlemskontoViewModel { get; set; } = new MedlemskontoViewModel();

        Medlemmar medlem = new Medlemmar();


        public CustomerCard()
        {
            InitializeComponent();

            medlem = App.medlemskontoViewModel.ReturnMember();

            BindingContext = medlem;

        }
    }
}
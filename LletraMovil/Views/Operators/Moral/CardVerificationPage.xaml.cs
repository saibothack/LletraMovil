using LletraMovil.ViewModels.Operators.Moral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LletraMovil.Views.Operators.Moral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardVerificationPage : ContentPage
    {
        private CardVerificationPageViewModels viewModel;

        public CardVerificationPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CardVerificationPageViewModels();
            viewModel.Navigation = this.Navigation;
        }

        private void TxtRFC_Focused(object sender, FocusEventArgs e)
        {

        }
    }
}
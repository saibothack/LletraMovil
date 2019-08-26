using LletraMovil.ViewModels.Operators;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LletraMovil.Views.Operators
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterActivitePage : ContentPage
    {
        private RegisterActivitePageViewModels viewModel;
        public RegisterActivitePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new RegisterActivitePageViewModels();
            viewModel.Navigation = this.Navigation;
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            PMoral.IsToggled = false;
        }

        private void Switch_Toggled_1(object sender, ToggledEventArgs e)
        {
            PFisica.IsToggled = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (PMoral.IsToggled)
            {
                Application.Current.MainPage = new NavigationPage(new Moral.CardVerificationPage());
            } else
            {
                Application.Current.MainPage = new NavigationPage(new Physical.CardVerificationPage());
            }
        }
    }
}
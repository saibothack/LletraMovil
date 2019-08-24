using LletraMovil.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LletraMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private LoginPageViewModels viewModel;
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new LoginPageViewModels();
            viewModel.Navigation = this.Navigation;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}

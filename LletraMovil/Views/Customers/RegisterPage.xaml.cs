using LletraMovil.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LletraMovil.Views.Customers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        private RegisterPageViewModels viewModel;
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new RegisterPageViewModels();
            viewModel.Navigation = this.Navigation;
        }
    }
}
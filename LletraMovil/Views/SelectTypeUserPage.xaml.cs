using LletraMovil.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LletraMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectTypeUserPage : ContentPage
    {
        private SelectTypeUserPageViewModels viewModel;
        public SelectTypeUserPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SelectTypeUserPageViewModels();
            viewModel.Navigation = this.Navigation;
        }
    }
}

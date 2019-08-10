﻿using LletraMovil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LletraMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroPage : ContentPage
    {
        private IntroPageViewModels viewModel;

        public IntroPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new IntroPageViewModels();
            viewModel.Navigation = this.Navigation;
        }
    }
}

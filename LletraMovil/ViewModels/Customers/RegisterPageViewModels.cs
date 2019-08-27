using LletraMovil.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LletraMovil.ViewModels.Customers
{
    public class RegisterPageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }
        public ImageSource imgBackground { get; internal set; }
        public Command CmdRegresar { get; internal set; }
        public Command CmdRegistrar { get; internal set; }

        public RegisterPageViewModels()
        {
            imgBackground = ImageSource.FromResource("LletraMovil.Images.background.png");
            CmdRegresar = new Command(Regresar);
            CmdRegistrar = new Command(Registrar);
        }

        void Regresar()
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        void Registrar()
        {
            Application.Current.MainPage = new NavigationPage(new EndRegisterPage());
        }
    }
}

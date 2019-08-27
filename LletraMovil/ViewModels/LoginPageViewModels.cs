using LletraMovil.Views;
using LletraMovil.Views.Customers;
using LletraMovil.Views.Operators;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LletraMovil.ViewModels
{
    public class LoginPageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }
        public ImageSource imgBackground { get; internal set; }
        public Command CmdRegresar { get; internal set; }
        public Command CmdRegistrar { get; internal set; }
        public Command CmdRecuperar { get; internal set; }
        


        public LoginPageViewModels()
        {
            imgBackground = ImageSource.FromResource("LletraMovil.Images.background.png");
            CmdRegresar = new Command(Regresar);
            CmdRegistrar = new Command(Registrar);
            CmdRecuperar = new Command(Recuperar);
        }

        void Regresar()
        {
            Preferences.Set("TypeUser", null);
            Application.Current.MainPage = new NavigationPage(new SelectTypeUserPage());
        }

        void Registrar()
        {
            var typeUser = Preferences.Get("TypeUser", 0);

            if (typeUser == 1)
            {
                Application.Current.MainPage = new NavigationPage(new RegisterPage());
            }
            else
            {
                Application.Current.MainPage = new NavigationPage(new RegisterActivitePage());
            }
        }

        void Recuperar()
        {
            
        }
    }
}

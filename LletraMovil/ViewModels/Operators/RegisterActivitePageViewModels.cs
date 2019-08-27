using LletraMovil.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LletraMovil.ViewModels.Operators
{
    public class RegisterActivitePageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }
        public ImageSource imgBackground { get; internal set; }
        public Command CmdRegresar { get; internal set; }

        public RegisterActivitePageViewModels()
        {
            imgBackground = ImageSource.FromResource("LletraMovil.Images.background.png");
            CmdRegresar = new Command(Regresar);
        }

        void Regresar()
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}

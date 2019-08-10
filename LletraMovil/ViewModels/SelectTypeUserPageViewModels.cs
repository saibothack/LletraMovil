using System;
using LletraMovil.Views;
using Xamarin.Forms;

namespace LletraMovil.ViewModels
{
    public class SelectTypeUserPageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }
        public Command CmdUsuario { get; internal set; }
        public Command CmdOperador { get; internal set; }


        public SelectTypeUserPageViewModels()
        {
            CmdUsuario = new Command(SoyUsuario);
            CmdOperador = new Command(SoyOperador);
            

        }

        void SoyUsuario() {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        void SoyOperador() {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}

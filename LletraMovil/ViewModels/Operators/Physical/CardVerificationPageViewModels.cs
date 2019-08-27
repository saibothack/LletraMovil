using LletraMovil.Views.Operators;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LletraMovil.ViewModels.Operators.Physical
{
    public class CardVerificationPageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }
        public Command CmdRegresar { get; internal set; }

        public CardVerificationPageViewModels()
        {
            CmdRegresar = new Command(Regresar);
        }

        void Regresar()
        {
            Application.Current.MainPage = new NavigationPage(new RegisterActivitePage());
        }
    }
}

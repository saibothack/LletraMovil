using Xamarin.Essentials;
using LletraMovil.Views;
using Xamarin.Forms;

namespace LletraMovil.ViewModels
{
    public class SelectTypeUserPageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }
        public ImageSource imgBackground { get; internal set; }
        public Command CmdUsuario { get; internal set; }
        public Command CmdOperador { get; internal set; }


        public SelectTypeUserPageViewModels()
        {
            imgBackground = ImageSource.FromResource("LletraMovil.Images.background.png");
            CmdUsuario = new Command(SoyUsuario);
            CmdOperador = new Command(SoyOperador);
            

        }

        void SoyUsuario() {
            Preferences.Set("TypeUser", 1);
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        void SoyOperador() {
            Preferences.Set("TypeUser", 2);
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}

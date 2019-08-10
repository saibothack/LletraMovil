using System.Threading.Tasks;
using LletraMovil.Views;
using Xamarin.Forms;

namespace LletraMovil.ViewModels
{
    public class IntroPageViewModels : ViewModelBase
    {
        public INavigation Navigation { get; internal set; }

        public IntroPageViewModels()
        {
            //goToTutorial();
        }

        public async void goToTutorial()
        {
            await Task.Delay(5000);
            Application.Current.MainPage = new NavigationPage(new SelectTypeUserPage());
        }


    }
}

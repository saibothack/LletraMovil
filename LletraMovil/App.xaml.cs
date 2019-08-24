using System;
using LletraMovil.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LletraMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var typeUser = Preferences.Get("TypeUser", 0);
            var isLogin = Preferences.Get("IsLogin", false);

            if (!isLogin)
            {
                if (typeUser != 0)
                {
                    MainPage = new LoginPage();
                } else
                {
                    MainPage = new IntroPage();
                }
            } 

            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

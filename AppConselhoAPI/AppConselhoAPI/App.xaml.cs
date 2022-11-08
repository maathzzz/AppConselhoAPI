using AppConselhoAPI.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConselhoAPI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaConselho();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

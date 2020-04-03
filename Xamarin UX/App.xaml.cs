using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_UX.Services;
using Xamarin_UX.Views;

namespace Xamarin_UX
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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

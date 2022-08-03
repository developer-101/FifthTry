using FifthTry.Services;
using FifthTry.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthTry
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            //MainPage = new TabbedPage1();
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

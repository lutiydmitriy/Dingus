﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Dingus.Pages;
using Dingus.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Dingus
{
    public partial class App : Application
    {
        static public NavigationService MainNavigationService { get; } = new NavigationService();

        public App()
        {
            InitializeComponent();
            
            MainNavigationService.MainPageChangedEvent += MainPageChangedEvent;
            MainNavigationService.PresentAsMainPage("StartUp");
        }

        private void MainPageChangedEvent(NavigationPage page)
        {
            MainPage = page;
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

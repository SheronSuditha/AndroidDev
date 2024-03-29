using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace StudentData
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }
        public App()
        {
            InitializeComponent();


            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            MainPage = new NavigationPage(new MainPage());
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

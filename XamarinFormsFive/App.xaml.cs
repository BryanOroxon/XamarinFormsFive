using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsFive.Views;

namespace XamarinFormsFive
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Device.SetFlags(new[] {"Brush_Experimental"});
            App.Current.UserAppTheme = OSAppTheme.Light;

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

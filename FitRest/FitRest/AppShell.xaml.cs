using FitRest.Views;
using System;
using Xamarin.Forms;

namespace FitRest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewSleepPage), typeof(NewSleepPage));
            Routing.RegisterRoute(nameof(SleepDetailsPage), typeof(SleepDetailsPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}

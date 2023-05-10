using FitRest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitRest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SleepPage : ContentPage
    {
        private SleepViewModel _viewModel;

        public SleepPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SleepViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
using FitRest.Service.Reference;
using FitRest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitRest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewSleepPage : ContentPage
    {
        public Sleep Item { get; set; }
        public NewSleepPage()
        {
            InitializeComponent();
            BindingContext = new NewSleepViewModel();
        }
    }
}
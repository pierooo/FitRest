using FitRest.Services;
using Xamarin.Forms;

namespace FitRest
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<SleepDataStore>();
            DependencyService.Register<ActivityDataStore>();
            DependencyService.Register<ActivityWithDurationDataStore>();
            DependencyService.Register<DayDataStore>();
            DependencyService.Register<MealDataStore>();
            DependencyService.Register<MealIngredientDataStore>();
            DependencyService.Register<MealIngredientWithPortionDataStore>();
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

using FitRest.Models;
using FitRest.Service.Reference;
using FitRest.ViewModels.Abstract;
using FitRest.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FitRest.ViewModels
{
    public class SleepViewModel : AListViewModel<Sleep>
    {
        public SleepViewModel() 
            : base("Sleep index!")
        {
        }
        public async override void OnItemSelected(Sleep item)
        {
            if (item == null)
                return;
            await Shell.Current.DisplayAlert("Sleep selected", $"{item.Day.Date}", "Lubie placki");
            //await Shell.Current.GoToAsync($"{nameof(ClientDetailPage)}?{nameof(ClientDetailViewModel.ItemId)}={item.IdClient}");
        }
        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewSleepPage));
        }
    }
}

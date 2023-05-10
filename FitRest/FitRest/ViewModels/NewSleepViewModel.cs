using FitRest.Service.Reference;
using FitRest.Services;
using FitRest.ViewModels.Abstract;
using System;
using System.Linq;
using Xamarin.Forms;

namespace FitRest.ViewModels
{
    public class NewSleepViewModel : ANewViewModel<Sleep>
    {
        public NewSleepViewModel()
            : base()
        {
        }
        #region Fields
        private int durationInMinutes = 0;
        private int durationInMinutesOfDeepSleep = 0;
        private int ratingOfSleep = 0;
        private DateTime startTime = DateTime.Now;
        private DateTime endTime = DateTime.Now;
        private DateTime day = DateTime.Now;
        #endregion Fields
        #region Properties
        public int DurationInMinutes
        {
            get => durationInMinutes;
            set => SetProperty(ref durationInMinutes, value);
        }
        public int DurationInMinutesOfDeepSleep
        {
            get => durationInMinutesOfDeepSleep;
            set => SetProperty(ref durationInMinutesOfDeepSleep, value);
        }
        public int RatingOfSleep
        {
            get => ratingOfSleep;
            set => SetProperty(ref ratingOfSleep, value);
        }
        public DateTime StartTime
        {
            get => startTime;
            set => SetProperty(ref startTime, value);
        }
        public DateTime EndTime
        {
            get => endTime;
            set => SetProperty(ref endTime, value);
        }
        public DateTime Day
        {
            get => day;
            set => SetProperty(ref day, value);
        }
        #endregion Properties


        public override Sleep SetItem()
        {
            var dayDataStore = DependencyService.Get<DayDataStore>();
            Day dayToSet;
            if (dayDataStore.items.Any(dayToCheck => dayToCheck.Date == day.Date))
            {
                dayToSet = dayDataStore.items.FirstOrDefault(dayToCheck => dayToCheck.Date == day.Date);
            }
            else
            {
                var latestDay = dayDataStore.items?.OrderByDescending(days => days.Date)?.FirstOrDefault();
                dayToSet = new Day
                {
                    ActivityWithDuration = null,
                    CaloriesGoal = latestDay?.CaloriesGoal ?? 0,
                    FatsGoal = latestDay?.FatsGoal ?? 0,
                    Meals = null,
                    ProteinGoal = latestDay?.ProteinGoal ?? 0,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Date = day.Date,
                    CarbohydratesGoal = latestDay?.CarbohydratesGoal ?? 0,
                };
            }

            return new Sleep
            {
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IsActive = true,
                DurationInMinutes = this.DurationInMinutes,
                DurationInMinutesOfDeepSleep = this.DurationInMinutesOfDeepSleep,
                RatingOfSleep = this.ratingOfSleep,
                StartTime = this.StartTime,
                EndTime = this.EndTime,
                IdDay = dayToSet.Id,
                Day = dayToSet
            };
        }

        public override bool ValidateSave()
        {
            return durationInMinutes != 0 && durationInMinutesOfDeepSleep != 0 
                //&& StartTime > EndTime
                ;
        }
    }
}

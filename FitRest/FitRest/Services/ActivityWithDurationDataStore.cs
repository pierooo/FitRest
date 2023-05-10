using FitRest.Service.Reference;
using FitRest.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace FitRest.Services
{
    public class ActivityWithDurationDataStore : AListDataStore<ActivityWithDuration>
    {
        public ActivityWithDurationDataStore()
            :base()
        {
        }

        public override async Task<ActivityWithDuration> AddItemToService(ActivityWithDuration item)
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> DeleteItemFromService(ActivityWithDuration item)
        {
            throw new NotImplementedException();
        }

        public override async Task<ActivityWithDuration> Find(ActivityWithDuration item)
        {
            throw new NotImplementedException();
        }

        public override async Task<ActivityWithDuration> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> UpdateItemInService(ActivityWithDuration item)
        {
            throw new NotImplementedException();
        }
    }
}

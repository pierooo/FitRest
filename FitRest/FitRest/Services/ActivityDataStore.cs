using FitRest.Service.Reference;
using FitRest.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace FitRest.Services
{
    public class ActivityDataStore : AListDataStore<Activity>
    {
        public ActivityDataStore()
            :base()
        {
        }

        public override async Task<Activity> AddItemToService(Activity item)
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> DeleteItemFromService(Activity item)
        {
            throw new NotImplementedException();
        }

        public override async Task<Activity> Find(Activity item)
        {
            throw new NotImplementedException();
        }

        public override async Task<Activity> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> UpdateItemInService(Activity item)
        {
            throw new NotImplementedException();
        }
    }
}

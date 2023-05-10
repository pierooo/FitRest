using FitRest.Service.Reference;
using FitRest.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace FitRest.Services
{
    public class MealDataStore : AListDataStore<Meal>
    {
        public MealDataStore()
            :base()
        {
        }

        public override async Task<Meal> AddItemToService(Meal item)
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> DeleteItemFromService(Meal item)
        {
            throw new NotImplementedException();
        }

        public override async Task<Meal> Find(Meal item)
        {
            throw new NotImplementedException();
        }

        public override async Task<Meal> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> UpdateItemInService(Meal item)
        {
            throw new NotImplementedException();
        }
    }
}

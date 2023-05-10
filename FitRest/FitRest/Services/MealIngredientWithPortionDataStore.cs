using FitRest.Service.Reference;
using FitRest.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace FitRest.Services
{
    public class MealIngredientWithPortionDataStore : AListDataStore<MealIngredientWithPortion>
    {
        public MealIngredientWithPortionDataStore()
            :base()
        {
        }

        public override async Task<MealIngredientWithPortion> AddItemToService(MealIngredientWithPortion item)
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> DeleteItemFromService(MealIngredientWithPortion item)
        {
            throw new NotImplementedException();
        }

        public override async Task<MealIngredientWithPortion> Find(MealIngredientWithPortion item)
        {
            throw new NotImplementedException();
        }

        public override async Task<MealIngredientWithPortion> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> UpdateItemInService(MealIngredientWithPortion item)
        {
            throw new NotImplementedException();
        }
    }
}

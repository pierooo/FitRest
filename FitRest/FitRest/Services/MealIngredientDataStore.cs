using System;
using System.Threading.Tasks;
using FitRest.Services.Abstract;

namespace FitRest.Services
{
    public class MealIngredientDataStore : AListDataStore<MealIngredientDataStore>
    {
        public MealIngredientDataStore()
            :base()
        {
        }

        public override async Task<MealIngredientDataStore> AddItemToService(MealIngredientDataStore item)
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> DeleteItemFromService(MealIngredientDataStore item)
        {
            throw new NotImplementedException();
        }

        public override async Task<MealIngredientDataStore> Find(MealIngredientDataStore item)
        {
            throw new NotImplementedException();
        }

        public override async Task<MealIngredientDataStore> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override async Task<bool> UpdateItemInService(MealIngredientDataStore item)
        {
            throw new NotImplementedException();
        }
    }
}

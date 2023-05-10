using FitRest.Helpers;
using FitRest.Service.Reference;
using FitRest.Services.Abstract;
using System.Linq;
using System.Threading.Tasks;

namespace FitRest.Services
{
    public class DayDataStore : AListDataStore<Day>
    {
        public DayDataStore()
            :base()
        {
        }

        public override async Task<Day> AddItemToService(Day item)
        {
            return await _service.DaysPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(Day item)
        {
            return await _service.DaysDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<Day> Find(Day item)
        {
            return await _service.DaysGETAsync(item.Id);
        }

        public override async Task<Day> Find(int id)
        {
            return await _service.DaysGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            items = _service.DaysAllAsync().Result.ToList();
        }

        public override async Task<bool> UpdateItemInService(Day item)
        {
            return await _service.DaysPUTAsync(item.Id, item).HandleRequest();
        }
    }
}

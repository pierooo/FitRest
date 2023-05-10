using FitRest.Helpers;
using FitRest.Service.Reference;
using FitRest.Services.Abstract;
using System.Linq;
using System.Threading.Tasks;

namespace FitRest.Services
{
    public class SleepDataStore : AListDataStore<Sleep>
    {
        public SleepDataStore()
            :base()
        {
        }

        public override async Task<Sleep> AddItemToService(Sleep item)
        {
            return await _service.SleepPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(Sleep item)
        {
            return await _service.SleepDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<Sleep> Find(Sleep item)
        {
            return await _service.SleepGETAsync(item.Id);
        }

        public override async Task<Sleep> Find(int id)
        {
            return await _service.SleepGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            items = _service.SleepAllAsync().Result.ToList();
        }

        public override async Task<bool> UpdateItemInService(Sleep item)
        {
            return await _service.SleepPUTAsync(item.Id, item).HandleRequest();
        }
    }
}

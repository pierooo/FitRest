using FitRest.Service.Reference;
using System.Net.Http;

namespace FitRest.Services.Abstract
{
    public abstract class ADataStore
    {
        protected readonly FitRestService _service;
        public ADataStore()
        {
            //Use this code to test locally - localhost do not have certificate
            var handler = new HttpClientHandler();
#if DEBUG
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };
#endif
            var client = new HttpClient(handler);
            _service = new FitRestService("https://localhost:7035", client);
        }
    }
}

using SybrinLoanPortal.Client.Services.Interfaces;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace SybrinLoanPortal.Client.Services.Repositories
{
    public class ServiceRepository : IServiceInterface
    {
        private readonly HttpClient _client;

        public ServiceRepository(HttpClient client)
        {
            _client = client;
        }
        public async Task<IEnumerable<T>> LoadData<T>(string url) where T : class
        {
            var options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                PropertyNameCaseInsensitive = true
            };
            var clientDocs = await _client.GetFromJsonAsync<IEnumerable<T>>(url,options);
           
            return (IEnumerable<T>)clientDocs;



        }
    }
}

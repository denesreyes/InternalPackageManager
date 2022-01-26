using Contract.Contracts;
using Newtonsoft.Json;

namespace Contract.ApiProxies
{
    public class ContactAPI
    {
        public async Task<ContactDTO?> GetContact()
        {
            using var client = new HttpClient();
            using var response = await client.GetAsync("https://localhost:7080/api/v1/Contact");
            string apiResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ContactDTO?>(apiResponse);
        }
    }
}

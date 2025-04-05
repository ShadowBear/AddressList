using AddressList.Models;

namespace AddressList.Services
{
    public class ContactInfoService: IContactInfoService
    {
        private readonly HttpClient _http;

        public ContactInfoService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<ContactInfo>> GetContactInfosAsync()
        {
            return await _http.GetFromJsonAsync<List<ContactInfo>>("api/contactinfo") ?? new List<ContactInfo>();
        }

        public async Task<List<ContactInfo>> GetContactInfosByFileId(int fileId)
        {
            return await _http.GetFromJsonAsync<List<ContactInfo>>($"api/contactinfo/byfileid?fileId={fileId}") ?? new List<ContactInfo>();
        }
    }
}

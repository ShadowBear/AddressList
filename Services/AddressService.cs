
using AddressList.Models;

namespace AddressList.Services
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _http;

        public AddressService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Address>> GetAddressesAsync()
        {
            return await _http.GetFromJsonAsync<List<Address>>("api/address") ?? new List<Address>();
        }

        public async Task SaveAddress(Address address)
        {
            try
            {
                HttpResponseMessage response = await _http.PostAsJsonAsync<Address>("api/address", address, CancellationToken.None);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Address added successfully");
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode} - {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


using AddressList.Shared.Models;
using AddressList.Shared.Services;
using static System.Net.WebRequestMethods;

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

        public async Task<List<Address>> SearchAddressesAsync(string aktenzeichen)
        {
            return await _http.GetFromJsonAsync<List<Address>>($"api/address/search?aktenzeichen={aktenzeichen}") ?? new List<Address>();
        }

        public async Task<bool> SaveAddress(Address address)
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
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task ClearAddressData()
        {
            var response = await _http.PostAsync("api/address/clear", null);
            Console.WriteLine(response.IsSuccessStatusCode ? "Data cleared" : "Failed to clear the Address data");
        }
    }
}

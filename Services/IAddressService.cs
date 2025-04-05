using AddressList.Models;

namespace AddressList.Services
{
    public interface IAddressService
    {
        Task<List<Address>> GetAddressesAsync();
        Task<List<Address>> SearchAddressAsync(string aktenzeichen);
        Task SaveAddress(Address address);
        Task ClearAddressData();

    }
}

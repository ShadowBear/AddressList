using AddressList.Models;

namespace AddressList.Services
{
    public interface IAddressService
    {
        Task<List<Address>> GetAddressesAsync();
        Task SaveAddress(Address address);
    }
}

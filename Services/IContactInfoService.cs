using AddressList.Models;

namespace AddressList.Services
{
    public interface IContactInfoService
    {
        Task<List<ContactInfo>> GetContactInfosAsync();
    }
}

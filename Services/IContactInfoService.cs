using AddressList.Models;

namespace AddressList.Services
{
    public interface IContactInfoService
    {
        Task<List<ContactInfo>> GetContactInfosAsync();
        Task<List<ContactInfo>> GetContactInfosByFileId(int fileId);
    }
}

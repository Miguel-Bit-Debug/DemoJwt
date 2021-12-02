using Domain.Models;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAccountInfoRepository
    {
        Task<AccountInfoModel> FindAccountByEmailAsync(string email);
    }
}

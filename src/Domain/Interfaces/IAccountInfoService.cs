using Domain.Models;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAccountInfoService
    {
        Task<AccountInfoModel> FindAccountByEmail(string Avatar);
    }
}

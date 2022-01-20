using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Data;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class AccountInfoRepository : IAccountInfoRepository
    {
        private readonly UserManager<AccountModel> _userManager;

        public AccountInfoRepository(UserManager<AccountModel> userManager)
        {
            _userManager = userManager;
        }

        public async Task<AccountInfoModel> FindAccountByEmailAsync(string email)
        {
            if (email is null)
                return null;

            var user = await _userManager.FindByEmailAsync(email);
            var userInfos = new AccountInfoModel
            {
                Avatar = user.Avatar,
                Email = user.UserName,
                IsAdmin = user.IsAdmin
            };

            return userInfos;
        }
    }
}

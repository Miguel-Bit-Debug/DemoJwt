using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class AccountInfoService : IAccountInfoService
    {
        private readonly IAccountInfoRepository _repository;

        public AccountInfoService(IAccountInfoRepository repository)
        {
            _repository = repository;
        }

        public async Task<AccountInfoModel> FindAccountByEmail(string email)
        {
            var user = await _repository.FindAccountByEmailAsync(email);

            return user;
        }
    }
}

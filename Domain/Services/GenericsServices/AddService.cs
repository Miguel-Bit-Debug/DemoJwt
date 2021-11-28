using Domain.Interfaces.GenericsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.GenericsServices
{
    public class AddService<T> : IAddService<T> where T : class
    {
        private readonly IAddRepository<T> _repository;

        public AddService(IAddRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task Insert(T obj)
        {
            await _repository.InsertAsync(obj);
        }
    }
}

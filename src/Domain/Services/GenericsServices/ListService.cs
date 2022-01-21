using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.GenericsServices
{
    public class ListService<T> : IListServices<T>
    {
        private readonly IListRepository<T> _repository;

        public ListService(IListRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> List()
        {
            return await _repository.List();
        }
    }
}

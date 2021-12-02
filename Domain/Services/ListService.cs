using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    public class ListService : IListProductsServices
    {
        private readonly IListProductsRepository _repository;

        public ListService(IListProductsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ProductModel> List()
        {
            return _repository.List();
        }
    }
}

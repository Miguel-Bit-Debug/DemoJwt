using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IListProductsRepository
    {
        IEnumerable<ProductModel> List();
    }
}

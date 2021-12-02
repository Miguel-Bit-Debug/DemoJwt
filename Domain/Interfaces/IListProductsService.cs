using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IListProductsServices
    {
        IEnumerable<ProductModel> List();
    }
}

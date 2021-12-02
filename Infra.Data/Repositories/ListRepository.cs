using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Data;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Data.Repositories
{
    public class ListRepository : IListProductsRepository
    {
        private readonly AppDbContext _context;

        public ListRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductModel> List()
        {
            var products =  _context.Products.OrderBy(x => x.Name);
            return products;
        }
    }
}

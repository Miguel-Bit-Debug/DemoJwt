using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoJwt.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

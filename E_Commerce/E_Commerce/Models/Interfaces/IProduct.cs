using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    interface IProduct
    {
        public Task<List<Product>> GetProducts();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class ProductCart
    {
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}
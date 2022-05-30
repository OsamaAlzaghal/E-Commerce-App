using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public Payment Payment { get; set; }
        public List<ProductCart> ProductCarts { get; set; }
    }
}
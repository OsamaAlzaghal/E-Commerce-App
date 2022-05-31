using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    interface IPayment
    {
        public Task<List<Payment>> GetPayments();
        public Task<Payment> GetPayment(int id);
        
        // User user = new User();
        // Cart cart = new Cart();
        // user.cart = cart;
        // user.CartID = cart.ID;
    }
}
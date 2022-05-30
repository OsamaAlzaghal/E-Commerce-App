using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class PaymentService : IPayment
    {
        private readonly E_CommerceDbContext _context;

        public PaymentService(E_CommerceDbContext context)
        {
            _context = context;
        }

        public async Task<List<Payment>> GetPayments()
        {
            return await _context.Payments.Select(x => x).ToListAsync();
        }
    }
}

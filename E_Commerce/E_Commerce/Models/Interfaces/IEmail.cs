using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    public interface IEmail
    {
        public Task SendMail(string email, List<Product> products);
        public Task WelcomeMail(string email);
    }
}

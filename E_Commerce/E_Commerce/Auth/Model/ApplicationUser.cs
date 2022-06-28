using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Needs fixing, we used the Cookie approach instead just to try different methods.
        public string CartID { get; set; }
        public Cart Cart { get; set; }
    }
}
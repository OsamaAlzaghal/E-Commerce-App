using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace E_Commerce.Pages.Cart
{
    public class CartModel : PageModel
    {
        public string cart { get; set; }
        
        public async Task OnGet()
        {
            
        }
    }
}

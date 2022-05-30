using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public enum Type
    {
        Cash,
        Visa
    }
    public class Payment
    {
        public int ID { get; set; }
        public int CartID { get; set; }
        public Type Type { get; set; }
        public Cart Cart { get; set; }
    }
}
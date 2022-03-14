using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class CartItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Amount
        {
            get {
                return this.Price * this.Quantity; 
            }
        }
    }
}
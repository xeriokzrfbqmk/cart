using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class Cart
    {

        
        public Cart()
        {
            this.cartItems = new List<CartItem>();
        }

        public List<CartItem> cartItems;

        public decimal TotalAmount
        {
            get
            {
                decimal totalAmount = 0.0m;
                foreach (var cartItem in this.cartItems)
                {
                    totalAmount = totalAmount + cartItem.Amount;
                }
                return totalAmount;
            }
        }

         
    }
}
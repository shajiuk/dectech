using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecTech.Interface;

namespace DecTech.Models
{
    public class Milk : IShoppingCart
    {
        public Milk(int count, decimal price)
        {
            Count = count;
            Price = price;
        }

        public int Count { get; set; }
        public decimal Price { get; set ; }

        public decimal GetOffers()
        {
            var offerThreshhold = 4;
            var minusOffer = Count / offerThreshhold;
            
            var totalPrice = (Count - minusOffer) * Price;

            return totalPrice;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecTech.Interface;

namespace DecTech.Models
{
    public class Butter : IShoppingCart
    {
        public Butter(int count, decimal price)
        {
            Count = count;
            Price = price;
        }

        public int Count { get; set ; }
        public decimal Price { get; set; }

        public decimal GetOffers()
        {
            return Price * Count;

        }

    }
}

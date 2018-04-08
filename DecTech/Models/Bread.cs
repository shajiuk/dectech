using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecTech.Interface;

namespace DecTech.Models
{
    public class Bread: IShoppingCart    {
        public int Count { get; set; }
        public decimal Price { get; set; }

        private IShoppingCart _item;

        public Bread(int count, decimal price, IShoppingCart item)
        {
            Count = count;
            Price = price;
            _item = item;
        }

        public decimal GetOffers()
        {
            var wholeCount = (_item != null) ? _item.Count / 2 : 0;

            var offer = wholeCount * Price / 2;
            var numBreadFullPrice = Count - wholeCount;

            var total = numBreadFullPrice * Price + offer;

            return total;
        }

    }
}

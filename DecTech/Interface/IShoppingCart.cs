using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecTech.Interface
{
    public interface IShoppingCart
    {
        int Count { get; set; }
        decimal Price { get; set; }

        decimal GetOffers();

    }
}

using DecTech.Models;
using Microsoft.AspNetCore.Mvc;

namespace DecTech.Controllers
{
    [Produces("application/json")]
    [Route("api/ShoppingCart")]
    public class ShoppingCartController : Controller
    {
        [HttpPost()]
        public string Post([FromBody]Cart cart)
        {
            var total = 0.0M;

            // set to zero values if object is null
            var butter = (cart.butter != null) ? new Butter(cart.butter.Count, cart.butter.Price) : new Butter(0, 0.0M);
            var bread = (cart.bread != null) ? new Bread(cart.bread.Count, cart.bread.Price, butter) : new Bread(0, 0.0M, butter);
            var milk = (cart.milk != null) ? new Milk(cart.milk.Count, cart.milk.Price) : new Milk(0, 0.0M);

            // acculmulate the shopping total
            total += bread.GetOffers();
            total += butter.GetOffers();
            total += milk.GetOffers();

            return "Total: " + total;

        }
    }
}
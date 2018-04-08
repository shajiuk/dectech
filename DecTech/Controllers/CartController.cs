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

            var butter = new Butter(cart.butter.Count, cart.butter.Price);
            var bread = new Bread(cart.bread.Count, cart.bread.Price, butter);
            var milk = new Milk(cart.milk.Count, cart.milk.Price);

            total += bread.GetOffers();
            total += butter.GetOffers();
            total += milk.GetOffers();

            return "Total: " + total;

        }
    }
}
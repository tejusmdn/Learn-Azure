using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        /// <summary>
        /// Get a list of drinks that are available to order.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var drinks = new[] { "Cappuccino", "Mocha", "Flat White", "Espresso", "Hot Chocolate" };
            return Ok(drinks);
        }
    }
}

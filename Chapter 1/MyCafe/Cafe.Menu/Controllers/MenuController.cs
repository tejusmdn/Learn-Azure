using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Menu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        /// <summary>
        /// Get a list of all the drinks that are available to order.
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

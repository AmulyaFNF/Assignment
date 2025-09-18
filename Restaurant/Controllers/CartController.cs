using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantApi.Data;
using RestaurantApi.Model;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)

        {

            _context = context;

        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] List<CartItem> items)

        {

            _context.CartItems.AddRange(items);

            await _context.SaveChangesAsync();

            var total = items.Sum(i => i.Price * i.Quality);

            return Ok(new { message = "Order placed successfully", total });

        }

        [HttpGet]

        public async Task<IActionResult> Get()

        {

            var allItems = await _context.CartItems.ToListAsync();

            return Ok(allItems);

        }
    }
}







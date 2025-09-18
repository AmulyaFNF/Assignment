using Microsoft.EntityFrameworkCore;
using RestaurantApi.Model;

namespace RestaurantApi.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<CartItem> CartItems { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
    }
}

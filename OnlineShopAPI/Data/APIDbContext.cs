using Microsoft.EntityFrameworkCore;
using OnlineShopAPI.Models;

namespace OnlineShopAPI.Data
{
    public class APIDbContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
        public APIDbContext(DbContextOptions ops) : base(ops)
        {

        }
    }
}

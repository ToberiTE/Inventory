using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> opt) : base(opt)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
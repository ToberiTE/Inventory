using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class SqlInventoryRepo : IInventoryRepo
    {
        private readonly InventoryContext _context;

        public SqlInventoryRepo(InventoryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public void CreateProduct(Product prod)
        {
            if (prod == null)
            {
                throw new ArgumentNullException(nameof(prod));
            }
            _context.Products.Add(prod);
        }

        public void UpdateProduct(Product prod)
        {
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

    }
}
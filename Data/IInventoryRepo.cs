using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Models;

namespace Inventory.Data
{
    public interface IInventoryRepo
    {
        Task<IEnumerable<Product>> GetProducts();
        Product GetProductById(int id);
        void CreateProduct(Product prod);
        void UpdateProduct(Product prod);
        Task SaveChanges();
    }
}
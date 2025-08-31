using ApiPOS.AppCode.Models.Entities;
using ApiPOS.AppCode.DBContext;
using Microsoft.EntityFrameworkCore;

namespace ApiPOS.AppCode.Repositories
{

    public interface IProductRepository
    {
        Task<IEnumerable<Producto>> SearchByNameAsync(string name);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly AppDBContext _dbContext;

        public ProductRepository(AppDBContext context)
        {
            _dbContext = context; 
            }

        public async Task<IEnumerable<Producto>> SearchByNameAsync(string name)
        {
            try
            {
                var filteredProducts = await _dbContext.Productos
                    .Where(p => p.Nombre.Contains(name))
                    .ToListAsync();
                return filteredProducts;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

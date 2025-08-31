using ApiPOS.AppCode.Models.Entities;
using ApiPOS.AppCode.Repositories;

namespace ApiPOS.AppCode.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Producto>> SearchProductsByName(string name);
    }
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Producto>> SearchProductsByName(string name)
        {
           return await _productRepository.SearchByNameAsync(name);
        }
    }
}

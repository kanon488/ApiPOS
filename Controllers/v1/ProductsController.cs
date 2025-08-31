using ApiPOS.AppCode.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPOS.Controllers.v1
{
    [ApiController]
    [Route("posmobile/v1/[controller]")]

    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult> SearchByDescription([FromQuery] string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    return BadRequest("No se ingreso un parámetro de búsqueda");
                }

                var products = await _productService.SearchProductsByName(name);

                return Ok(products);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

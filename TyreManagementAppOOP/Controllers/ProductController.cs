using Microsoft.AspNetCore.Mvc;
using TyreManagementAppOOP.Repositories;

namespace TyreManagementAppOOP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// API for getting info on all products in the database
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllProductsCombined")]
        public async Task<IActionResult> GetAllProductsCombined()
        {
            return Ok(await _productRepository.GetAllProductsCombined());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TyreManagementAppOOP.Models;
using TyreManagementAppOOP.Repositories;

namespace TyreManagementAppOOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        // The layout for this controller, and all the others were influenced by the structure used in the controllers at my workplace.
        // I have altered the code as needed to suit my app, such as adding try catches or using async tasks


        private readonly SaleRepository _saleRepository;

        public SaleController(SaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        /// <summary>
        /// API for saving a new sale
        /// </summary>
        /// <returns></returns>
        [HttpPost("save")]
        public async Task<IActionResult> SaveSale(Sale sale)
        {
            try
            {
                return Ok(await _saleRepository.SaveSale(sale));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        ///// <summary>
        ///// API for editing an existing sale
        ///// </summary>
        ///// <returns></returns>
        //[HttpPost("edit")]
        //public async Task<IActionResult> EditeSale()
        //{
        //    try
        //    {
        //        return Ok(await _saleRepository.EditSale());
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}
    }
}

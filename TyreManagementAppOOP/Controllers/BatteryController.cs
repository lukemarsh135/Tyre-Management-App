using Microsoft.AspNetCore.Mvc;
using TyreManagementAppOOP.Models;
using TyreManagementAppOOP.Repositories;

namespace TyreManagementAppOOP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class BatteryController : ControllerBase
    {
        private readonly BatteryRepository _batteryRepository;

        public BatteryController(BatteryRepository batteryRepository)
        {
            _batteryRepository = batteryRepository;
        }

        /// <summary>
        /// API for getting details for a specific battery
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("getBatteryDetails")]
        public async Task<IActionResult> GetProductInformation(int Id)
        {
            return Ok(await _batteryRepository.GetProductInformation(Id));
        }

        /// <summary>
        /// API for adding a new battery
        /// </summary>
        /// <param name="battery"></param>
        /// <returns></returns>
        [HttpPost("addBattery")]
        public async Task<IActionResult> AddNewProduct(Battery battery)
        {
            try 
            {
                return Ok(await _batteryRepository.AddNewProduct(battery));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// API for updating a specific battery
        /// </summary>
        /// <param name="battery"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public async Task<IActionResult> UpdateDetails(Battery battery)
        {
            try 
            {
                return Ok(await _batteryRepository.UpdateDetails(battery));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// API for getting info for all battery
        /// </summary>
        /// <returns></returns>
        [HttpGet("getAllBatteryDetails")]
        public async Task<IActionResult> GetAllProductsInformation()
        {
            return Ok(await _batteryRepository.GetAllProductsInformation());
        }
    }
}

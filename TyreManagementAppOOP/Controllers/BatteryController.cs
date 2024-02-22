using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using TyreManagementAppOOP.Interfaces;
using System.Data.SqlClient;
using System.Data;
using TyreManagementAppOOP.Models;
using TyreManagementAppOOP.Data;
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
        /// API for getting info for specific battery
        /// </summary>
        /// <returns></returns>
        [HttpGet("getBatteryDetails")]
        public async Task<IActionResult> GetProductInformation(int Id)
        {
            return Ok(await _batteryRepository.GetProductInformation(Id));
        }

        /// <summary>
        /// API for adding a new battery
        /// </summary>
        /// <returns></returns>
        [HttpPost("addBattery")]
        public IActionResult AddNewProduct(IProduct battery)
        {
            // Add new tyre
            return Ok(battery);
        }

        /// <summary>
        /// API for updating a specific battery
        /// </summary>
        /// <returns></returns>
        [HttpPut("update")]
        public IActionResult UpdateDetails(IProduct battery)
        {
            
            return Ok(battery);
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

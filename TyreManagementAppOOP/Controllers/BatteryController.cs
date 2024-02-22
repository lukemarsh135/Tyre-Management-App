using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using TyreManagementAppOOP.Interfaces;
using System.Data.SqlClient;
using System.Data;
using TyreManagementAppOOP.Models;
using TyreManagementAppOOP.Data;

namespace TyreManagementAppOOP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class BatteryController : ControllerBase
    {
        private readonly Battery _battery;


        /// <summary>
        /// API for getting info for specific battery
        /// </summary>
        /// <returns></returns>
        [HttpGet("getBatteryDetails")]
        public IActionResult GetProductInformation(int Id)
        {
            return Ok(_battery.GetProductInformation(Id));
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
        public async Task<IEnumerable<Battery>> GetAllProductsInformation()
        {
            var query = ("SELECT * FROM Battery");

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Battery>(query);
        }

    }
}

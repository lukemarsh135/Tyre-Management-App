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
    public sealed class TyreController : ControllerBase
    {
        /// <summary>
        /// API for getting info for specific tyre
        /// </summary>
        /// <returns></returns>
        [HttpGet("getTyreDetails")]
        public async Task<IEnumerable<Tyre>> GetProductInformation(int Id)
        {
            // Parameterisation to prevent injection attacks
            var query = ("SELECT * FROM Tyre WHERE Id = @Id");
            var idParam = new SqlParameter("Id", Id);

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Tyre>(query, idParam);
        }

        /// <summary>
        /// API for adding a new tyre
        /// </summary>
        /// <returns></returns>
        [HttpPost("addTyre")]
        public IActionResult AddNewProduct(IProduct tyre)
        {
            // Add new tyre
            return Ok(tyre);
        }

        /// <summary>
        /// API for updating a specific tyre
        /// </summary>
        /// <returns></returns>
        [HttpPut("update")]
        public IActionResult UpdateDetails (IProduct tyre)
        {
            // Updating existing tyre
            return Ok(tyre);
        }

        /// <summary>
        /// API for getting info for all tyres
        /// </summary>
        /// <returns></returns>
        [HttpGet("getAllTyreDetails")]
        public async Task<IEnumerable<Tyre>> GetAllProductsInformation()
        {
            var query = ("SELECT * FROM Tyre");

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Tyre>(query);
        }
    }
}

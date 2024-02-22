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
    public sealed class TyreController : ControllerBase
    {
        private readonly TyreRepository _tyreRepository;

        public TyreController(TyreRepository tyreRepository)
        {
            _tyreRepository = tyreRepository;
        }
        /// <summary>
        /// API for getting info for specific tyre
        /// </summary>
        /// <returns></returns>
        [HttpGet("getTyreDetails")]
        public IActionResult GetProductInformation(int Id)
        {
            return Ok(_tyreRepository.GetProductInformation(Id));
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

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
        public async Task<IActionResult> GetProductInformation(int Id)
        {
            return Ok(await _tyreRepository.GetProductInformation(Id));
        }

        /// <summary>
        /// API for adding a new tyre
        /// </summary>
        /// <returns></returns>
        [HttpPost("addTyre")]
        public async Task<IActionResult> AddNewProduct(Tyre tyre)
        {
            try
            {
                return Ok(await _tyreRepository.AddNewProduct(tyre));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        /// <summary>
        /// API for updating a specific tyre
        /// </summary>
        /// <returns></returns>
        [HttpPut("update")]
        public async Task<IActionResult> UpdateDetails(Tyre tyre)
        {
            try
            {
               return Ok(await _tyreRepository.UpdateDetails(tyre)); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        /// <summary>
        /// API for getting info for all tyres
        /// </summary>
        /// <returns></returns>
        [HttpGet("getAllTyreDetails")]
        public async Task<IActionResult> GetAllProductsInformation()
        {
            return Ok(await _tyreRepository.GetAllProductsInformation());
        }
    }
}

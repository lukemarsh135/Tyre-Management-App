using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TyreManagementAppOOP.Models;
using TyreManagementAppOOP.Repositories;

namespace TyreManagementAppOOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        /// <summary>
        /// API for getting details for a all customers
        /// </summary>
        /// <returns></returns>
        [HttpGet("getAllCustomers")]
        public async Task<IActionResult> GetAllCustomerInformation()
        {
            return Ok(await _customerRepository.GetAllCustomerInformation());
        }

        /// <summary>
        /// API for updating a specific customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public async Task<IActionResult> UpdateCustomer(Customer customer)
        {
            try
            {
                return Ok(await _customerRepository.UpdateCustomer(customer));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// API for adding a new customer
        /// </summary>
        /// <param name="battery"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public async Task<IActionResult> AddNewCustomer(Customer customer)
        {
            try
            {
                return Ok(await _customerRepository.AddNewCustomer(customer));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// API for getting details for a specific customer
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("getCustomer")]
        public async Task<IActionResult> GetCustomerInformation(int Id)
        {
            return Ok(await _customerRepository.GetCustomerInformation(Id));
        }
    }
}

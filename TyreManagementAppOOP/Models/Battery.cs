using Microsoft.Data.SqlClient;
using TyreManagementAppOOP.Data;
using TyreManagementAppOOP.Interfaces;

namespace TyreManagementAppOOP.Models
{
    public class Battery : Product, IProduct
    {
        // Common product properties
        public int Id { get; set; }

        public string Model { get; set; }

        public int Quantity { get; set; }

        public string Brand { get; set; }

        public decimal Weight { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        // Unique battery properties
        public decimal Voltage { get; set; }

        public decimal Capacity { get; set; }

        public decimal startupPower { get; set; }


        public async Task<IEnumerable<Battery>> GetProductInformation(int id)
        {
            // Parameterisation to prevent injection attacks
            var query = ("SELECT * FROM Battery WHERE Id = @Id");
            var idParam = new SqlParameter("Id", id);

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Battery>(query, idParam);
            
        }

        public bool UpdateDetails(IProduct product)
        {
            // Update database
            return false;
        }

        public bool AddNewProduct(IProduct product)
        {
            return true;
        }

        public void GetAllProductsInformation()
        {
            // Get details from database for all batteries
        }
    }
}

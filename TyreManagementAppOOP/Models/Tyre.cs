using Microsoft.Data.SqlClient;
using TyreManagementAppOOP.Data;
using TyreManagementAppOOP.Interfaces;

namespace TyreManagementAppOOP.Models
{
    public class Tyre : Product, IProduct
    {
        // Common product properties
        public int Id { get; set; }

        public string Model { get; set; }

        public int Quantity { get; set; }

        public string Brand { get; set; }

        public decimal Weight { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        // Unique product properties
        public int Width { get; set; }

        public int aspectRatio { get; set; }

        public int Diameter { get; set; }

        public int loadRating { get; set; }

        public int speedRating { get; set; }

        public string Type { get; set; }

        public async Task<IEnumerable<Tyre>> GetProductInformation(int id)
        {
            // Parameterisation to prevent injection attacks
            var query = ("SELECT * FROM Tyre WHERE Id = @Id");
            var idParam = new SqlParameter("Id", id);

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Tyre>(query, idParam);
        }

        public bool UpdateDetails(IProduct product)
        {
            // Update database
            return true;
        }

        public bool AddNewProduct(IProduct product)
        {
            // Add new product to database
            return true;
        }

        public void GetAllProductsInformation()
        {
            // Get details from database for all tyres
        }
    }
}

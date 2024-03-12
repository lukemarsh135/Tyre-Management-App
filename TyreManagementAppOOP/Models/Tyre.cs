using Microsoft.Data.SqlClient;
using TyreManagementAppOOP.Controllers;
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

        public int AspectRatio { get; set; }

        public int Diameter { get; set; }

        public int LoadRating { get; set; }

        public string SpeedRating { get; set; }

        public string Type { get; set; }

        public void GetProductInformation(int id)
        {
            
        }

        public void UpdateDetails(IProduct product)
        {
            
        }

        public void AddNewProduct(IProduct product)
        {
            // Add new product to database
        }

        public void GetAllProductsInformation()
        {
            // Get details from database for all tyres
        }
    }
}

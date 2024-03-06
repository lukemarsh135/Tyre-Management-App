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

        public decimal StartupPower { get; set; }


        public void GetProductInformation(int id)
        {
           
        }

        public void UpdateDetails(IProduct product)
        {
            // Update database
        }

        public void AddNewProduct(IProduct product)
        {

        }

        public void GetAllProductsInformation()
        {
            
        }
    }
}

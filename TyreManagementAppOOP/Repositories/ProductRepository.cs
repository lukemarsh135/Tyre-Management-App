using Microsoft.Data.SqlClient;
using TyreManagementAppOOP.Data;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Repositories
{
    public class ProductRepository
    {
        public async Task<IEnumerable<Product>> GetAllProductsCombined()
        {
            var query = "SELECT * FROM Product";

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Product>(query);
        }
    }
}

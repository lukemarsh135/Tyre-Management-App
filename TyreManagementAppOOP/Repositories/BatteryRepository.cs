using Microsoft.Data.SqlClient;
using TyreManagementAppOOP.Data;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Repositories
{
    public class BatteryRepository
    {
        //private readonly Battery _battery;
        public async Task<IEnumerable<Battery>> GetProductInformation(int id)
        {
            // Parameterisation to prevent injection attacks
            var query = ("SELECT * FROM Battery WHERE Id = @Id");
            var idParam = new SqlParameter("Id", id);

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Battery>(query, idParam);
        }
    }
}

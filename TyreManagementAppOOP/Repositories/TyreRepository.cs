using Microsoft.Data.SqlClient;
using TyreManagementAppOOP.Data;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Repositories
{
    public class TyreRepository
    {
        private readonly Battery _battery;
        public async Task<IEnumerable<Tyre>> GetProductInformation(int id)
        {
            // Parameterisation to prevent injection attacks
            var query = ("SELECT * FROM Tyre WHERE Id = @Id");
            var idParam = new SqlParameter("Id", id);

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Tyre>(query, idParam);
        }
    }
}

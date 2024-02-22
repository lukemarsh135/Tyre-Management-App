using Microsoft.Data.SqlClient;
using TyreManagementAppOOP.Data;
using TyreManagementAppOOP.Interfaces;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Repositories
{
    public class TyreRepository
    {
        public async Task<IEnumerable<Tyre>> GetProductInformation(int id)
        {
            // Parameterisation to prevent injection attacks
            var query = "SELECT * FROM Tyre WHERE Id = @Id";
            var idParam = new SqlParameter("Id", id);

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Tyre>(query, idParam);
        }

        public async Task<IEnumerable<Tyre>> GetAllProductsInformation()
        {
            var query = "SELECT * FROM Tyre";

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Tyre>(query);
        }

        public async Task<int> AddNewProduct(Tyre tyre)
        {
            var query = @"
                INSERT INTO Tyre (Model, Quantity, Brand, Weight, Name, Price, Width, AspectRatio, Diameter, LoadRating, SpeedRating, Type)
                VALUES (@Model, @Quantity, @Brand, @Weight, @Name, @Price, @Width, @AspectRatio, @Diameter, @LoadRating, @SpeedRating, @Type)";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Model", tyre.Model),
                new SqlParameter("@Quantity", tyre.Quantity),
                new SqlParameter("@Brand", tyre.Brand),
                new SqlParameter("@Weight", tyre.Weight),
                new SqlParameter("@Name", tyre.Name),
                new SqlParameter("@Price", tyre.Price),
                new SqlParameter("@Width", tyre.Width),
                new SqlParameter("@AspectRatio", tyre.aspectRatio),
                new SqlParameter("@Diameter", tyre.Diameter),
                new SqlParameter("@LoadRating", tyre.loadRating),
                new SqlParameter("@SpeedRating", tyre.speedRating),
                new SqlParameter("@Type", tyre.Type)
            };

            return await DatabaseConnection.Instance.ExecuteNonQueryAsync(query, parameters);
        }

        public async Task<int> UpdateDetails(Tyre tyre)
        {
            var query = @"
                UPDATE Tyre
                SET Model = @Model,
                    Quantity = @Quantity,
                    Brand = @Brand,
                    Weight = @Weight,
                    Name = @Name,
                    Price = @Price,
                    Width = @Width,
                    AspectRatio = @AspectRatio,
                    Diameter = @Diameter,
                    LoadRating = @LoadRating,
                    SpeedRating = @SpeedRating,
                    Type = @Type
                WHERE Id = @Id";

            var parameters = new[]
            {
                new SqlParameter("@Model", tyre.Model),
                new SqlParameter("@Quantity", tyre.Quantity),
                new SqlParameter("@Brand", tyre.Brand),
                new SqlParameter("@Weight", tyre.Weight),
                new SqlParameter("@Name", tyre.Name),
                new SqlParameter("@Price", tyre.Price),
                new SqlParameter("@Width", tyre.Width),
                new SqlParameter("@AspectRatio", tyre.aspectRatio),
                new SqlParameter("@Diameter", tyre.Diameter),
                new SqlParameter("@LoadRating", tyre.loadRating),
                new SqlParameter("@SpeedRating", tyre.speedRating),
                new SqlParameter("@Type", tyre.Type),
                new SqlParameter("@Id", tyre.Id)
            };

            return await DatabaseConnection.Instance.ExecuteNonQueryAsync(query, parameters);
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
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

        public async Task<IEnumerable<Battery>> GetAllProductsInformation()
        {
            var query = ("SELECT * FROM Battery");

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Battery>(query);
        }

        public async Task<bool> AddNewProduct(Battery battery)
        {
            var query = @"
                INSERT INTO Battery (Model, Quantity, Brand, Weight, Name, Price, Voltage, Capacity, StartupPower)
                VALUES (@Model, @Quantity, @Brand, @Weight, @Name, @Price, @Voltage, @Capacity, @StartupPower)";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Model", battery.Model),
                new SqlParameter("@Quantity", battery.Quantity),
                new SqlParameter("@Brand", battery.Brand),
                new SqlParameter("@Weight", battery.Weight),
                new SqlParameter("@Name", battery.Name),
                new SqlParameter("@Price", battery.Price),
                new SqlParameter("@Voltage", battery.Voltage),
                new SqlParameter("@Capacity", battery.Capacity),
                new SqlParameter("@StartupPower", battery.startupPower),
            };

            return await DatabaseConnection.Instance.ExecuteNonQueryAsync(query, parameters) > 0;
        }

        public async Task<bool> UpdateDetails(Battery battery)
        {
            var query = @"
                UPDATE Battery
                SET Model = @Model,
                    Quantity = @Quantity,
                    Brand = @Brand,
                    Weight = @Weight,
                    Name = @Name,
                    Price = @Price,
                    Voltage = @Voltage,
                    Capacity = @Capacity,
                    StartupPower = @StartupPower
                WHERE Id = @Id";

            var parameters = new[]
            {
                new SqlParameter("@Model", battery.Model),
                new SqlParameter("@Quantity", battery.Quantity),
                new SqlParameter("@Brand", battery.Brand),
                new SqlParameter("@Weight", battery.Weight),
                new SqlParameter("@Name", battery.Name),
                new SqlParameter("@Price", battery.Price),
                new SqlParameter("@Voltage", battery.Voltage),
                new SqlParameter("@Capacity", battery.Capacity),
                new SqlParameter("@StartupPower", battery.startupPower),
                new SqlParameter("@Id", battery.Id)
            };

            if (await DatabaseConnection.Instance.ExecuteNonQueryAsync(query, parameters) > 0)
            {
                return true;
            }
            return false;
        }
    }
}

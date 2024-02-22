using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using TyreManagementAppOOP.Interfaces;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Data
{
    public class DatabaseConnection
    {

        // This code was influenced and adapted from the YouTube video https://www.youtube.com/watch?v=aU_hRoob82A and the following web pages on generic functions:
        // https://stackoverflow.com/questions/2144495/creating-a-generic-method-in-c-sharp, https://www.programiz.com/csharp-programming/generics. I also had
        // guidance from colleagues.
        // It taught me the fundamentals of implementing the singleton design pattern in in the context of a database connection, as well as generic function and 
        // how map values to the class fields


        private static readonly Lazy<DatabaseConnection> instance = new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        private readonly string connectionString = "Server=GBTK-MARSHALL\\SQLEXPRESS;Database=TyreManagementDatabase;Integrated Security=true;TrustServerCertificate=True;";

        public static DatabaseConnection Instance => instance.Value;

        private DatabaseConnection() 
        {
        }

        // For getting data from database
        public async Task<IEnumerable<T>> ExecuteQueryAsync<T>(string query, params SqlParameter[] parameters) where T : new()
        {
            using var connection = new SqlConnection(connectionString);

            await connection.OpenAsync();

            var resultList = new List<T>();

            using var command = new SqlCommand(query, connection);

            // Add parameters to the command if any
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            using var reader = await command.ExecuteReaderAsync();
            
            while (await reader.ReadAsync())
            {
                var obj = new T();
                MapData(reader, obj);
                resultList.Add(obj);
            }
            
        return resultList;

        }

        public async Task<int> ExecuteNonQueryAsync(string query, params SqlParameter[] parameters)
        {
            using var connection = new SqlConnection(connectionString);

            await connection.OpenAsync();

            using var command = new SqlCommand(query, connection);

            // Add parameters to the command if any
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            return await command.ExecuteNonQueryAsync();
        }


        // Adapted from https://mazeez.dev/posts/how-orms-work
        private void MapData<T>(SqlDataReader reader, T obj) where T : new()
        {
            var properties = typeof(T).GetProperties();

            // For each field in the class T  map the name to the reader and then 
            foreach (var property in properties)
            {
                
                if (HasColumn(reader, property.Name))
                {
                    // Retrieves value from current column
                    var value = reader[property.Name];
                    if (value != DBNull.Value)
                    {
                        property.SetValue(obj, value);
                    }
                }
            }
        }

        // Checks if column name corresponding to current property exists in the SqlDataReader by looping over each reader value
        // and checking if its name is equal to the column name
        private bool HasColumn(SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}

using Microsoft.Data.SqlClient;
using TyreManagementAppOOP.Data;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Repositories
{
    public class CustomerRepository
    {
        public async Task<IEnumerable<Customer>> GetAllCustomerInformation()
        {
            var query = ("SELECT * FROM Customer");

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Customer>(query);
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            var query = @"
                UPDATE Customer
                SET FirstName = @FirstName,
                    LastName = @LastName,
                    HouseOrApartmentNum = @HouseOrApartmentNum,
                    Street = @Street,
                    TownOrCity = @TownOrCity,
                    Postcode = @Postcode,
                    Phone = @Phone
                WHERE Id = @Id";

            var parameters = new[]
            {
                new SqlParameter("@Id", customer.Id),
                new SqlParameter("@FirstName", customer.FirstName),
                new SqlParameter("@LastName", customer.LastName),
                new SqlParameter("@HouseOrApartmentNum", customer.HouseOrApartmentNum),
                new SqlParameter("@Street", customer.Street),
                new SqlParameter("@TownOrCity", customer.TownOrCity),
                new SqlParameter("@Postcode", customer.Postcode),
                new SqlParameter("@Phone", customer.Phone),
            };

            if (await DatabaseConnection.Instance.ExecuteNonQueryAsync(query, parameters) > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> AddNewCustomer(Customer customer)
        {
            var query = @"
                INSERT INTO Customer (FirstName, LastName, HouseOrApartmentNum, Street, TownOrCity, Postcode, Phone)
                VALUES (@FirstName, @LastName, @HouseOrApartmentNum, @Street, @TownOrCity, @Postcode, @Phone)";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName", customer.FirstName),
                new SqlParameter("@LastName", customer.LastName),
                new SqlParameter("@HouseOrApartmentNum", customer.HouseOrApartmentNum),
                new SqlParameter("@Street", customer.Street),
                new SqlParameter("@TownOrCity", customer.TownOrCity),
                new SqlParameter("@Postcode", customer.Postcode),
                new SqlParameter("@Phone", customer.Phone),
                
            };

            return await DatabaseConnection.Instance.ExecuteNonQueryAsync(query, parameters) > 0;
        }

        public async Task<IEnumerable<Customer>> GetCustomerInformation(int id)
        {
            // Parameterisation to prevent injection attacks
            var query = ("SELECT * FROM Customer WHERE Id = @Id");
            var idParam = new SqlParameter("Id", id);

            return await DatabaseConnection.Instance.ExecuteQueryAsync<Customer>(query, idParam);
        }
    }
}

using TyreManagementAppOOP.Data;

namespace TyreManagementAppOOP.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string firstName { get; set; }

        public string? lastName { get; set; }

        public string? houseNumAndStreet { get; set; }

        public string? townOrCity { get; set; }

        public string? postcode { get; set; }

        public List<Transactions> orderHistory { get; set; }

        public string? Phone {  get; set; }

        public bool UpdateCustomer(string id)
        {
            // Update customer
            return true;
        }

        public bool AddNewCustomer(Customer customer) 
        {
            return true;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            // Get pervious sales from database
            return Enumerable.Empty<Customer>();
        }


    }
}

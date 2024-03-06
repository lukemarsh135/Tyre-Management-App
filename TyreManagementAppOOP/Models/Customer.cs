using TyreManagementAppOOP.Data;

namespace TyreManagementAppOOP.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string? LastName { get; set; }

        public string? HouseOrApartmentNum { get; set; }

        public string Street {  get; set; }

        public string? TownOrCity { get; set; }

        public string? Postcode { get; set; }

        //public List<Transactions> OrderHistory { get; set; }

        public string? Phone {  get; set; }

        public void UpdateCustomer(Customer customer)
        {
            
        }

        public void AddNewCustomer(Customer customer) 
        {
           
        }

        public void GetAllCustomers()
        {

        }

        public void GetCustomer(int id)
        {

        }
    }
}

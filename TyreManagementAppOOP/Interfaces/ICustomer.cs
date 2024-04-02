namespace TyreManagementAppOOP.Models
{
    public interface ICustomer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string? LastName { get; set; }

        public string? HouseOrApartmentNum { get; set; }

        public string Street { get; set; }

        public string? TownOrCity { get; set; }

        public string? Postcode { get; set; }

        public string? Phone { get; set; }

    }
}

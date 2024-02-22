namespace TyreManagementAppOOP.Models
{
    public class OrderLine
    {
        public int DocumenntId { get; set; }

        public int lineId { get; set; }

        public List<Product> productName { get; set; }

        public int ProductQuantity { get; set; }

        public double TotalCost { get; set; }
    }
}

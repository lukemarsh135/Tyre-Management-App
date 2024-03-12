namespace TyreManagementAppOOP.Models
{
    public class OrderLine
    {
        public int SaleId { get; set; }

        public int LineId { get; set; }

        public List<Product> Product { get; set; }
    }
}

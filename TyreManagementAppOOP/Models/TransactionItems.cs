namespace TyreManagementAppOOP.Models
{
    public class TransactionItem
    {
        public int TransactionItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal IndividualPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

namespace TyreManagementAppOOP.Models
{
    public class CombinedTransaction
    {
        // Template for returning transactions
        public int TransactionItemId { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal IndividualPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateAndTime { get; set; }
        public decimal TotalCost { get; set; }
    }
}

namespace TyreManagementAppOOP.Models
{
    public class Transactions
    {
        // A Transaction is dependant on Sale,
        // as a change in a sale will change the transactions

        public int SaleId { get; set; }

        public int CustomerId { get; set; }

        public DateTime DateAndTime { get; set; }

        public decimal TotalCost { get; set; }
    }
}

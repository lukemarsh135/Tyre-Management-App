using TyreManagementAppOOP.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

        public void GetAllTransactions()
        {
            
        }

        public void GetTransactionBySaleId(int id)
        {

        }

        public void GetTransactionByCustomer(int custId)
        {

        }

        public void TransactionOperations(ISavedSale command)
        {
            // Validate the command object 
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            command.Execute();
        }
    }
}

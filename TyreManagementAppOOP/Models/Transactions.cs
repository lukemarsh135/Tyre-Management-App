using TyreManagementAppOOP.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TyreManagementAppOOP.Models
{
    public class Transactions
    {
        // 'Transactions' aggregates 'Sale' by having  a list of 'sale' as its property
        public List<Sale> Sales { get; set; }

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

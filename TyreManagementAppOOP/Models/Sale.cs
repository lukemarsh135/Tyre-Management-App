using System.Diagnostics.Eventing.Reader;

namespace TyreManagementAppOOP.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public DateTime DateAndTime { get; set; }

        public decimal TotalCost { get; set; }

        // 'Sale' aggregates 'OrderLine' objects by having a property of type 'OrderLine'
        public OrderLine WorkOrderLines { get; set; }

        public int CustomerId { get; set; }

        public bool AddProductToOrder(Product product)
        {
            // logic to add product to order
            return true;
        }

        public bool CancelOrder(Sale sale)
        {
            // logic to cancel the order
            return true;
        }

        public bool ProceedToWorkOrder()
        {
            // logic to generate work order
            return true;
        }
    }
}

using TyreManagementAppOOP.Interfaces;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Actions
{
    public class SaleCompositeActions : ISale
    {
        public List<Product> Products { get; set; }


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

        public bool RemoveProduct(Product product)
        {
            // logic to removing project from order
            return true;
        }
    }
}

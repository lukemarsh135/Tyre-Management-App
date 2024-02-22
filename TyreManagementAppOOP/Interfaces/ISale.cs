using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Interfaces
{
    public interface ISale
    {
        bool AddProductToOrder(Product product);

        bool CancelOrder(Sale sale);

        bool ProceedToWorkOrder();

        bool RemoveProduct(Product product);
    }
}

using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Interfaces
{
    public interface IProduct
    {
        void GetProductInformation(int id);

        void UpdateDetails(IProduct product);

        void AddNewProduct(IProduct product);

        void GetAllProductsInformation();
    }
}

using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Interfaces
{
    public interface IProduct
    {
        void GetProductInformation(int id);

        bool UpdateDetails(IProduct product);

        bool AddNewProduct(IProduct product);

        void GetAllProductsInformation();
    }
}

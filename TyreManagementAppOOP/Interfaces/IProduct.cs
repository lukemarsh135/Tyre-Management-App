using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Interfaces
{
    public interface IProduct
    {
        Task<IEnumerable<T>> GetProductInformation<T>(int id);

        bool UpdateDetails(IProduct product);

        bool AddNewProduct(IProduct product);

        void GetAllProductsInformation();
    }
}

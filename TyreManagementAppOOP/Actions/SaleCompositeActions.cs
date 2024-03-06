using TyreManagementAppOOP.Interfaces;
using TyreManagementAppOOP.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TyreManagementAppOOP.Actions
{
    public class SaleCompositeActions : BaseSaleActions, ISale
    {
        public List<Product> productsInOrder { get; set; }

        public void SortProducts(List<Product> products)
        {
            // Sort products by some attribute (id, brand etc)
        }

        public void SaveSale(Order order)
        {
            BaseSaleActions baseSaleActions = new BaseSaleActions();

            baseSaleActions.SaveSale(order);
        }

    }
}

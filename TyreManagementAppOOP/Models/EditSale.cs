using TyreManagementAppOOP.Commands;
using TyreManagementAppOOP.Interfaces;

namespace TyreManagementAppOOP.Models
{
    public class EditSale : SavedSaleCommand
    {
        public EditSale(Sale sale) : base(sale) { }

        public override void Execute()
        {
            // Logic to edit a saved sale
        }
    }
}

using TyreManagementAppOOP.Interfaces;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Commands
{
    public abstract class SavedSaleCommand : ISavedSale
    {
        protected readonly Sale Sale;

        public SavedSaleCommand(Sale sale)
        {
            Sale = sale;
        }

        public abstract void Execute();
    }

}

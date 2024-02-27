using TyreManagementAppOOP.Interfaces;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Commands
{
    public abstract class WorkOrderCommand : IWorkOrder
    {
        protected readonly Sale Sale;

        public WorkOrderCommand(Sale sale)
        {
            Sale = sale;
        }

        public abstract void Execute();
    }

}

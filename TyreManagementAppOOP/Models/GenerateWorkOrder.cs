using TyreManagementAppOOP.Commands;
using TyreManagementAppOOP.Interfaces;

namespace TyreManagementAppOOP.Models
{
    public abstract class GenerateWorkOrder : WorkOrderCommand
    {
        public GenerateWorkOrder(Sale sale) : base(sale) { }

        public override void Execute()
        {
            // Logic to generate the work order based on Sale data
        }
    }
}

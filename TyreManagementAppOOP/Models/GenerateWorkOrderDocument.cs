using TyreManagementAppOOP.Commands;
using TyreManagementAppOOP.Interfaces;

namespace TyreManagementAppOOP.Models
{
    public class GenerateWorkOrderDocument : WorkOrderCommand
    {
        private readonly string _filePath;

        public GenerateWorkOrderDocument(Sale sale, string filePath) : base(sale)
        {
            _filePath = filePath;
        }

        public override void Execute()
        {
            // Logic to format and write work order data to a file
        }
    }
}

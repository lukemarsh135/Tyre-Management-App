using TyreManagementAppOOP.Commands;
using TyreManagementAppOOP.Interfaces;

namespace TyreManagementAppOOP.Models
{
    public class GenerateSaleDocument : SavedSaleCommand
    {
        private readonly string _filePath;

        public GenerateSaleDocument(Sale sale, string filePath) : base(sale)
        {
            _filePath = filePath;
        }

        public override void Execute()
        {
            // Logic to format and write sale data to a file
        }
    }
}

using TyreManagementAppOOP.Interfaces;

namespace TyreManagementAppOOP.Models
{
    public class GenerateSaleDocument 
    {
        private readonly string _filePath;

        public GenerateSaleDocument(Sale sale, string filePath) 
        {
            _filePath = filePath;
        }

        public void GenerateDocument(Sale sale)
        {
            string formattedData = FormatSaleData(sale);

            using (FileStream fs = File.Open(_filePath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(formattedData);
                }
            }
        }

        private string FormatSaleData(Sale sale)
        {
            // Build a string with sale information
            string data = $"Sale ID: {sale.SaleId}\n";
            data += $"Customer: {sale.CustomerId}\n";
            data += $"Date and time: {sale.DateAndTime}\n";

            return data;
        }
    }
}

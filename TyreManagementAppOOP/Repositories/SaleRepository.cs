﻿using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using TyreManagementAppOOP.Data;
using TyreManagementAppOOP.Models;

namespace TyreManagementAppOOP.Repositories
{
    public class SaleRepository
    {
        public async Task<bool> SaveSale(Sale sale)
        {
            // total cost 
            try
            {
                // Insert Sale record
                int saleId = await InsertSale(sale);

                // Insert Order Lines referencing the inserted Sale
                await InsertTransactionItems(sale.WorkOrderLines, saleId);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        private async Task<int> InsertSale(Sale sale)
        {
            var query = @"INSERT INTO Transactions (CustomerId, DateAndTime, TotalCost)
            OUTPUT INSERTED.SaleId
            VALUES (@customerId, @dateAndTime, @totalCost);";

            var parameters = new SqlParameter[]
            {
            new SqlParameter("@customerId", sale.CustomerId),
            new SqlParameter("@dateAndTime", sale.DateAndTime),
            new SqlParameter("@totalCost", sale.TotalCost),
            };

            int result =  Convert.ToInt16(await DatabaseConnection.Instance.ExecuteScalarAsync(query, parameters));

            if (result == 0)
            {
                throw new Exception("Failed to save sale.");  // Error if no rows inserted
            }

            return result;
        }

        private async Task InsertTransactionItems(OrderLine orderLine, int saleId)
        {
            var query = @"
            INSERT INTO TransactionItems (SaleId, ProductId, ProductName, IndividualPrice, Quantity, TotalPrice)
            VALUES (@SaleId, @ProductId, @ProductName, @IndividualPrice, @Quantity, @TotalPrice);
            ";

            foreach (var product in orderLine.Product)
            {
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@SaleId", saleId),
                    new SqlParameter("@ProductId", product.Id),
                    new SqlParameter("@ProductName", product.Name),
                    new SqlParameter("@IndividualPrice", product.Price),
                    new SqlParameter("@Quantity", product.Quantity),
                    new SqlParameter("@TotalPrice", product.Quantity * product.Price)
                };

                await DatabaseConnection.Instance.ExecuteNonQueryAsync(query, parameters);
            }   
        }
    }
}

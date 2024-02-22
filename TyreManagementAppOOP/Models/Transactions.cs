﻿using TyreManagementAppOOP.Interfaces;

namespace TyreManagementAppOOP.Models
{
    public class Transactions
    {
        // 'Transactions' aggregates 'Sale' by having  a list of 'sale' as its property
        public List<Sale> Sales { get; set; }

        public IEnumerable<Sale> GetPreviousSales()
        {
            // Get pervious sales from database
            return Enumerable.Empty<Sale>();
        }
    }
}
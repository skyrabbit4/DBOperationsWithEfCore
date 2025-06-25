using System.Collections.Generic;

namespace DBOperationsWithEfCore.Data
{
    public class BookPrice
    {
        // PK for this table
        public int Id { get; set; }

        // FK → Books.Id
        public int BookId { get; set; }

        // The price – use decimal for currency values
        public decimal Amount { get; set; }

        // FK → CurrencyTypes.Id  (your CurrencyType/master table)
        public int CurrencyId { get; set; }

        // Navigation properties
        public Book Book { get; set; }
        public Currency Currency { get; set; }
    }
}

namespace DBOperationsWithEfCore.Data
{
    public class Currency
    {
        public int Id { get; set; }

        public string Title  { get; set; }


        public string Description { get; set; }   // e.g. "US Dollar"

        public ICollection<BookPrice> BookPrices { get; set; }
    }
}

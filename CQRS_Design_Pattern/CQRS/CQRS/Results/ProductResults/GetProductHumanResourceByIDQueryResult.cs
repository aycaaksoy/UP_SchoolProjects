namespace CQRS.CQRS.Results.ProductResults
{
    public class GetProductHumanResourceByIDQueryResult
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal SalePrice { get; set; }
    }
}

using CQRS.CQRS.Queries.ProductQueries;
using CQRS.CQRS.Results.ProductResults;
using CQRS.DAL.Context;

namespace CQRS.CQRS.Handlers.ProductHandlers
{
    public class GetProductHumanResoruceByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductHumanResoruceByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public GetProductHumanResourceByIDQueryResult Handle(GetProductHumanResourceByIDQuery query)
        {
            var values = _productContext.Products.Find(query.id);
            return new GetProductHumanResourceByIDQueryResult
            {
                ProductId = values.ProductId,
                Brand = values.Brand,
                Name = values.Name,
                SalePrice = values.SalePrice
            };
        }
    }
}

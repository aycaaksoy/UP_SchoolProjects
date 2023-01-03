using CQRS.CQRS.Queries.ProductQueries;
using CQRS.CQRS.Results.ProductResults;
using CQRS.DAL.Context;

namespace CQRS.CQRS.Handlers.ProductHandlers
{
    public class GetProductAccountantByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccountantByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductAccountantByIDQueryResult Handle(GetProductAccountantByIDQuery query)
        {
            var values = _productContext.Products.Find(query.id);
            return new GetProductAccountantByIDQueryResult
            {
                ProductID = values.ProductId,
                Brand = values.Brand,
                Description = values.Description,
                Name = values.Name,
                PurchasePrice = values.PurchasePrice,
                SalePrice = values.SalePrice,
                Stock = values.Stock,
                Tax = values.Tax
            };
        }

    }
}

using CQRS.CQRS.Queries.ProductQueries;
using CQRS.CQRS.Results.ProductResults;
using CQRS.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CQRS.CQRS.Handlers.ProductHandlers
{
    public class GetProductAccountantQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccountantQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductByAccountantQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x =>
              new GetProductByAccountantQueryResult
              {
                  ProductId = x.ProductId,
                  Brand = x.Brand,
                  Name = x.Name,
                  PurchasePrice = x.PurchasePrice,
                  SalePrice = x.SalePrice,
                  Stock = x.Stock,
                  Tax = x.Tax
              }).AsNoTracking().ToList();
            return values;
        }
    }
}

using CQRS.CQRS.Results.ProductResults;
using CQRS.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CQRS.CQRS.Handlers.ProductHandlers
{
    public class GetProductByWarehouseQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductByWarehouseQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductByWarehouseQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new GetProductByWarehouseQueryResult
            {
                ProductID = x.ProductId,
                Name = x.Name,
                Storage = x.Storage
            }).AsNoTracking().ToList();
            return values;
        }
    }
}

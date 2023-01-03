using CQRS.CQRS.Commands.ProductCommands;
using CQRS.DAL.Context;
using CQRS.DAL.Entities;

namespace CQRS.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public void Handle(CreateProductCommand command)
        {
            _productContext.Products.Add(new Product
            {
                Brand = command.Brand,
                Cost = command.Cost,
                Stock = command.Stock,
                Tax = command.Tax,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                Name = command.Name,
                Size = command.Size,
                ProduceDate = command.ProduceofDate,
                EndOfDate = command.EndofDate,
                Status = true
            });
            _productContext.SaveChanges();
        }
    }
}

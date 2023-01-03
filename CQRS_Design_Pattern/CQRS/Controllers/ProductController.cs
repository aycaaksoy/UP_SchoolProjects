using CQRS.CQRS.Commands.ProductCommands;
using CQRS.CQRS.Handlers.ProductHandlers;
using CQRS.CQRS.Queries.ProductQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductAccountantQueryHandler _getProductAccounterQueryHandler;
        private readonly GetProductByWarehouseQueryHandler _getProductStoragerQueryHandler;
        private readonly GetProductHumanResoruceByIDQueryHandler _getProductHumanResoruceByIDQueryHandler;
        private readonly GetProductAccountantByIDQueryHandler _getProductAccounterByIDQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;

        public ProductController(GetProductAccountantQueryHandler getProductAccounterQueryHandler, GetProductByWarehouseQueryHandler getProductStoragerQueryHandler, GetProductHumanResoruceByIDQueryHandler getProductHumanResoruceByIDQueryHandler, GetProductAccountantByIDQueryHandler getProductAccounterByIDQueryHandler, CreateProductCommandHandler createProductCommandHandler)
        {
            _getProductAccounterQueryHandler = getProductAccounterQueryHandler;
            _getProductStoragerQueryHandler = getProductStoragerQueryHandler;
            _getProductHumanResoruceByIDQueryHandler = getProductHumanResoruceByIDQueryHandler;
            _getProductAccounterByIDQueryHandler = getProductAccounterByIDQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductAccounterQueryHandler.Handle();
            return View(values);
        }

        public IActionResult AccounterIndexByID(int id)
        {
            var values = _getProductAccounterByIDQueryHandler.Handle(new GetProductAccountantByIDQuery(id));
            return View(values);
        }

        public IActionResult StoragerIndex()
        {
            var values = _getProductStoragerQueryHandler.Handle();
            return View(values);
        }
        public IActionResult GetHumanResourceIndex(int id)
        {
            var values = _getProductHumanResoruceByIDQueryHandler.Handle(new GetProductHumanResourceByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}

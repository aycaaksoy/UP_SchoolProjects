using CRM.Business.Layer.Abstract;
using CRM.Entity.Layer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CRM.UI.Layer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AdminCustomerController : Controller
    {

        private readonly ICustomerService _customerService;

        public AdminCustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerList()
        {
            var jsonCustomer = JsonConvert.SerializeObject(_customerService.TGetList());
            return Json(jsonCustomer);  
        }

        [HttpPost]  
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.TInsert(customer);
            var values = JsonConvert.SerializeObject(customer);
            return Json(values);
        }

        public IActionResult GetByID(int CustomerID)
        {
            var values= _customerService.TGetById(CustomerID);
            var jsonValues=JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        public IActionResult DeleteCustomer(int id)
        {
            var values = _customerService.TGetById(id);
            _customerService.TDelete(values);
            return Json(values);
        }
        public IActionResult UpdateCustomer(Customer customer)
        {
             _customerService.TUpdate(customer);
            var values = JsonConvert.SerializeObject(customer);
            return Json(values);
        }
    }
}

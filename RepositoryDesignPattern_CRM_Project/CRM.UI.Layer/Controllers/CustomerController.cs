using CRM.DataAccess.Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRM.UI.Layer.Controllers
{
    public class CustomerController: Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Customers.ToList();
            return View(values);
        }
    }
}

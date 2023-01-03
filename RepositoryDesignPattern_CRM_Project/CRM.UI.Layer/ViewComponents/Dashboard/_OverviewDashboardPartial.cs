using CRM.DataAccess.Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRM.UI.Layer.ViewComponents.Dashboard
{
    public class _OverviewDashboardPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (var context = new Context())
            {
                ViewBag.EmployeeCount = context.Employees.Count();
                ViewBag.EmployeeGenderWomanCount = context.Users.Where(x => x.Gender == "Kadın").Count();
                int id = context.Users.Max(x => x.Id);
                ViewBag.LastUser = context.Users.Where(x => x.Id == id).Select(x => x.Name + " " + x.Surname).FirstOrDefault();             

            }

            return View();
        }
    }
}

using CRM.UI.Layer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRM.UI.Layer.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class ChartController : Controller
    {

        List<DepartmentSalary> departmentSalaries = new List<DepartmentSalary>();

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult DepartmantChart()
        {
            departmentSalaries.Add(new DepartmentSalary
            {
                departmentName = "Muhasebe",
                salaryAvg = 10000

            });

            departmentSalaries.Add(new DepartmentSalary
            {
                departmentName = "IT",
                salaryAvg = 20000

            });
            departmentSalaries.Add(new DepartmentSalary
            {
                departmentName = "Satıs",
                salaryAvg = 12000

            });
            return Json(new { jsonList = departmentSalaries });
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_1_Portfolio.Models.Entities;

namespace MVC_1_Portfolio.Controllers
{
    public class StatisticsController : Controller
    {
        UpSchoolPortfolioEntities1 db = new UpSchoolPortfolioEntities1();



        public ActionResult Index()
        {
            // number of all testimonials
            ViewBag.v1 = db.Testimonials.Count();

            // number of all testimonials in city Jorvik
            ViewBag.v2 = db.Testimonials.Where(x => x.City == "Jorvik").Count();
            

            // number of people whose profession are NOT king
            ViewBag.v3 = db.Testimonials.Where(x => x.Profession != "King").Count();

            // name of the person whose city is Wessex
            ViewBag.v4 = db.Testimonials.Where(x => x.City == "Wessex").Select(y => y.Name_Surname).FirstOrDefault();

            // Average balance of all records
            ViewBag.v5 = db.Testimonials.Average(x => x.Balance);

            return View();
        }
    }
}
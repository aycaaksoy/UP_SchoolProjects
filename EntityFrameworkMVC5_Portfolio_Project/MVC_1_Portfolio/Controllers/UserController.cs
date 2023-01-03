using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_1_Portfolio.Models.Entities;

namespace MVC_1_Portfolio.Controllers
{
    public class UserController : Controller
    {
        UpSchoolPortfolioEntities1 db = new UpSchoolPortfolioEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            return PartialView();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult AboutPartial()
        {
            var values = db.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult ServicePartial()
        {
            var values = db.Services.ToList();
            return PartialView(values);
        }

    }
}
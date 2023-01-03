using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_1_Portfolio.Models.Entities;
namespace MVC_1_Portfolio.Controllers
{
    public class MemberController : Controller
    {
       UpSchoolPortfolioEntities1 db = new UpSchoolPortfolioEntities1();
        public ActionResult Index()
        {
            var email= Session["MemberEmail"] .ToString();
            var values = db.Members.Where(x => x.MemberEmail == email).FirstOrDefault();
            ViewBag.name = values.MemberName;
            ViewBag.surname = values.MemberSurname;
            ViewBag.id = values.MemberID;
            return View();
            
        }
    }
}
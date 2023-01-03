using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MVC_1_Portfolio.Models.Entities;

namespace MVC_1_Portfolio.Controllers
{
   
    public class LoginController : Controller
    {
        UpSchoolPortfolioEntities1 db = new UpSchoolPortfolioEntities1();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Member p)
        {
            var values = db.Members.FirstOrDefault(x=>x.MemberEmail== p.MemberEmail && x.MemberPassword == p.MemberPassword);

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.MemberEmail, false);
                Session["MemberEmail"]= p.MemberEmail;
                return RedirectToAction("Index","About");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
    } 
}
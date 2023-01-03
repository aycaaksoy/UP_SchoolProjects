using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MVC_1_Portfolio.Models.Entities;

namespace MVC_1_Portfolio.Controllers
{
    public class AboutController : Controller
    {
        UpSchoolPortfolioEntities1 db = new UpSchoolPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.Abouts.ToList();
            return View(values);

        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            db.Abouts.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteAbout(int id)
        {
            var values = db.Abouts.Find(id);
            db.Abouts.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.Abouts.Find(id);
            return View(values);

        }



        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            var values = db.Abouts.Find(p.AboutID);
            values.Description = p.Description;
            values.Name_Surname = p.Name_Surname;
            values.ImageUrl = p.ImageUrl;
            values.Title = p.Title;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
  
}
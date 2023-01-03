using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_1_Portfolio.Models.Entities;

namespace MVC_1_Portfolio.Controllers
{
    public class MessageController : Controller
    {
        UpSchoolPortfolioEntities1 db = new UpSchoolPortfolioEntities1();
        public ActionResult Index()
        {   
            return View();
        }

        public ActionResult Inbox()
        {
            var email = Session["MemberEmail"].ToString();
            var values = db.Messages.Where(x => x.ReceiverEmail == email).ToList();
            return View();
        }

        public ActionResult Outbox()
        {
            var email = Session["MemberEmail"].ToString();
            var values = db.Messages.Where(x => x.SenderEmail == email).ToList();
            return View();
        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Message p)
        {
            var email = Session["MemberEmail"].ToString();
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.SenderEmail = email;
            p.SenderNameSurname = db.Members.Where(x => x.MemberEmail == email).Select(y => y.MemberName + " " + y.MemberSurname).FirstOrDefault();
            p.ReceiverNameSurname = db.Members.Where(x => x.MemberEmail == p.ReceiverEmail).Select(y => y.MemberName + " " + y.MemberSurname).FirstOrDefault();
            db.Messages.Add(p);
            db.SaveChanges();
            return RedirectToAction("Outbox");
        }


        public ActionResult IMessageDetails()
        {
            return View();
        }

    }
}
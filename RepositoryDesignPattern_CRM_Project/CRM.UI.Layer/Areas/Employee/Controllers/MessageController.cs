using CRM.Business.Layer.Abstract;
using CRM.DataAccess.Layer.Concrete;
using CRM.Entity.Layer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using CRM.UI.Layer.Areas.Employee.Models;
using MimeKit;
using System.Net.Mail;
using MailKit.Net.Smtp;

namespace CRM.UI.Layer.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(IMessageService messageService, UserManager<AppUser> userManager)
        {
            _messageService = messageService;
            _userManager = userManager;
        }

        

        [HttpGet]
        public async Task<IActionResult> SendMessage()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message message)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            

            message.SenderEmail = user.Email;
            message.SenderName = user.Name + " " + user.Surname;
            _messageService.TInsert(message);
            return View("SendMessage");
        }

        // ugvuhkbkmqsaqycn // email key
        [HttpGet]
        public async Task<IActionResult> SendEMail()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendEmail(MailRequest mailRequest)
        {

            MimeMessage mimeMessage = new MimeMessage();
            //mail sender name and mail
            MailboxAddress mailBoxAddressFrom = new MailboxAddress("aycaaksoy", "aa.halki2000@gmail.com");
            mimeMessage.From.Add(mailBoxAddressFrom);

            //mail receiver info
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverEmail);
            mimeMessage.To.Add(mailboxAddressTo);

            //message itself
            var bodyBuilder = new BodyBuilder();
            //content
            bodyBuilder.TextBody = mailRequest.EmailContent;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            //subject
            mimeMessage.Subject = mailRequest.EmailSubject;
            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            // ugvuhkbkmqsaqycn // email key 2nd parameter
            client.Authenticate("aa.halki2000@gmail.com", "ugvuhkbkmqsaqycn");           
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }

    }
}

using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripProject.Models;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult SendMail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMail(MailRequestModel mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressfrom = new MailboxAddress("TripProject","ketenci2554@gmail.com");
            mimeMessage.From.Add(mailboxAddressfrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("user", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var BodyBuilder = new BodyBuilder();
            BodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = BodyBuilder.ToMessageBody();
            mimeMessage.Subject = mailRequest.Subject;



            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("ketenci2554@gmail.com", "mxsncuaaucgaoqxw");

            
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            return View();
        }
    }
}

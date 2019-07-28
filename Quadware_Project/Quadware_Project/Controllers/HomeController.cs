using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

namespace Quadware_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult ContactarEmail(string correo, string mensaje)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("contacto@quadware.mx", "falta contraseña");
                smtpClient.Port = 587; //falta puerto
                smtpClient.Host = "falta el host";
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("contacto@quadware.mx");
                mail.To.Add(correo);
                mail.Subject = "Algo";
                mail.IsBodyHtml = true;
                mail.Body = "";

                smtpClient.Send(mail);
            }
            catch (SmtpException e)
            {
                return Json("Error 500 internal: " + e.Message.ToString());
            }

            return Json(String.Format("Ok"));
        }
    }
}
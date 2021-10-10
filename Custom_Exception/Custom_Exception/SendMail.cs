using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Exception
{
    public class SendMail
    {
         HasNumber hasNumber = new HasNumber();

        public string SendErrorMail()
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("ake0are@gmail.com");
            mail.From = new MailAddress("ake0are@gmail.com");
            mail.Subject = "You Have a Mail";
            mail.Body = "Dear user, you have a mail from" + "A.Kadir" + ".<br/>" + hasNumber.Message;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("ake0are@gmail.com", "ake0are0123*");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
               return "Your mail send successfuly";

            }
            catch (Exception ex)
            {
                return $"Can not send mail because ; {ex.Message}";
            }

        }
    }
}

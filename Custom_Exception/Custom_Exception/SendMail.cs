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
            mail.To.Add("Your e-mail here");
            mail.From = new MailAddress("Your e-mail here");
            mail.Subject = "You Have a Mail";
            mail.Body = "Dear user, you have a mail from" + "Jane.Doe" + ".<br/>" + hasNumber.Message;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("Your e-mail here", "Your e-mail password here*");
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

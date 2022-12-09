using Microsoft.VisualBasic.Logging;
using System;
using System.Net.Mail;
using System.Net;

namespace CallOpenerConfigurator
{
    class Mail
    {
        public static bool sendEmail(string to, string subject, string story, string path = null)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpClient = new SmtpClient("mail.your-server.de");
                mail.From = new MailAddress("scs@tecomatic.net");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = story;
                if (path != null && File.Exists(path))
                {
                    Attachment attachment;
                    attachment = new Attachment(path);
                    mail.Attachments.Add(attachment);
                }
                SmtpClient.Port = 587;
                SmtpClient.Credentials = new NetworkCredential("scs@tecomatic.net", "25c3yFeA5RTyLA10");
                SmtpClient.EnableSsl = true;
                SmtpClient.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                LogFile.New("error-mail", ex.Message.ToString());
                return false;
            }
        }
    }
}

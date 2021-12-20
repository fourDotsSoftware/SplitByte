using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Web;
using System.Net.Mail;

namespace SplitByte
{
    class MailHelper
    {
        public static bool SendEmail(string from,string to,string body, string subject, string server, string login, string password,int port,bool ssl,bool send_as_html,List<string> attached_files)
        {
            try
            {
                MailMessage mailmsg = new MailMessage();
                mailmsg.Subject = subject.Replace("[EMAIL]", to);
                mailmsg.Body = body.Replace("[EMAIL]", to);
                mailmsg.BodyEncoding = Encoding.Default;
                mailmsg.IsBodyHtml = send_as_html;
                mailmsg.From = new MailAddress(from);
                mailmsg.To.Add(new MailAddress(to));

                for (int k = 0; k < attached_files.Count; k++)
                {
                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(attached_files[k]);
                    mailmsg.Attachments.Add(attachment);
                }

                System.Net.Mail.SmtpClient Smtp = new SmtpClient();
                Smtp.Host = server;
                Smtp.EnableSsl = ssl;
                Smtp.Port = port;
                Smtp.Credentials = new System.Net.NetworkCredential(login, password);
                Smtp.Send(mailmsg);                
                
            }
            catch (Exception ex)
            {
                Module.ShowError(ex);
                throw (ex);
                return false;
            }


            return true;
        }

    }

    public class MailDetails
    {
        public string fromDisplayName = "";
        public string from="";
        public string to="";
        public string body="";
        public string subject="";
        public DateTime date=DateTime.MinValue;
    }
}

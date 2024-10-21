using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Week4_AbstractClassesAndInterfaces.Example1
{
    public class EmailLog:Log
    {
        public string Recipient { get; set; }
        public string From { get; set; }
        public string SmtpId { get; set; }
        public string SmtpPassword { get; set; }

        public string Smtp { get; set; }


        public override void Save() //this is never going to work unless you provide actual details and with google it requires more permissions
        {
            MailMessage mm = new MailMessage(From, Recipient);
            SmtpClient smtp = new SmtpClient(Smtp);
            smtp.Credentials = new NetworkCredential(SmtpId, SmtpPassword);

            mm.Subject = "Log #id " + Id;
            mm.Body = this.ToString();

            smtp.Send(mm);
        }
    }
}

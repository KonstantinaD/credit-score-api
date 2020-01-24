using System.Net;
using System.Net.Mail;

namespace _13_Moq_Employee_MainCode
{
    public class EmailSender
    {
        private string recepient;
        private string sender;
        private string subject;
        private string body;
        private string host = "mail.fdm.com";
        private string username;
        private string password;

        public virtual bool SendEmail()
        {
            MailMessage mail = new MailMessage(recepient, sender, subject, body);

            SmtpClient client = new SmtpClient(host);

            client.Credentials = new NetworkCredential(username, password);

            client.Send(mail);

            return true;
        }
    }
}

using Northwind.Application.Interfaces;
using Northwind.Application.Notifications.Models;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Northwind.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {	
        	var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(message.From,message.To)
            };
            using (var mailMessage = new MailMessage(message.From, message.To)
            {
                Subject = message.Subject,
                Body = message.Body
            })
            {
                smtp.Send(mailMessage);
            }



            return Task.CompletedTask;
        }
    }
}

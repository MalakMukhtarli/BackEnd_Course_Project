using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace BackEndFinalProject.Helpers
{
    public class EmailHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email">To whom it will be sent</param>
        /// <param name="subject">email subject</param>
        /// <param name="message">text to be sent</param>
        /// <returns></returns>
        public static async Task SendEmailToAllAsync(IEnumerable<string> emails, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("BackendFinalProject Admin", ""));

            foreach (var mail in emails)
            {
                emailMessage.To.Add(new MailboxAddress("", mail));
            }
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 465, true);
                await client.AuthenticateAsync("m.muxtarli.m@gmail.com", "123");
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}

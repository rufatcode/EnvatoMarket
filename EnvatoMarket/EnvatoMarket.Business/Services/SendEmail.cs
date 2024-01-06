using System;
using System.Net;
using System.Net.Mail;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Models;
using Microsoft.AspNetCore.Identity;

namespace EnvatoMarket.Business.Services
{
	public class SendEmail:ISendEmail
	{
		public SendEmail()
		{
		}

        public void Send(string from, string displayName, string to, string messageBody, string subject)
        {
			try
			{
                MailMessage mailMessage = new();
                mailMessage.From = new MailAddress(from, "Allup");
                mailMessage.To.Add(new MailAddress(to));
                mailMessage.Subject = subject;
                mailMessage.Body = messageBody;
                mailMessage.IsBodyHtml = true;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 587;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("rufatri@code.edu.az", "bazi tvxk bnta hymo");
                smtpClient.Send(mailMessage);
            }
			catch (Exception ex)
			{
                throw new Exception("something went wrong");
			}
        }
        public void SendWithAtachment(string from, string displayName, string to, string messageBody, string subject, Attachment item = null)
        {
            try
            {
                MailMessage mailMessage = new();
                mailMessage.From = new MailAddress(from, "Allup");
                mailMessage.To.Add(new MailAddress(to));
                mailMessage.Subject = subject;
                mailMessage.Body = messageBody;
                mailMessage.IsBodyHtml = true;
                mailMessage.Attachments.Add(item);
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 587;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("rufatri@code.edu.az", "bazi tvxk bnta hymo");
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}


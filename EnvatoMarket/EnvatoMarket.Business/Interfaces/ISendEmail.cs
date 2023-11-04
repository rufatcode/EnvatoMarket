using System;
using System.Net.Mail;

namespace EnvatoMarket.Business.Interfaces
{
	public interface ISendEmail
	{
		public void Send(string from,string displayName,string to,string messageBody,string subject);
		public void SendWithAtachment(string from,string displayName,string to,string messageBody,string subject, Attachment item = null);
    }
}


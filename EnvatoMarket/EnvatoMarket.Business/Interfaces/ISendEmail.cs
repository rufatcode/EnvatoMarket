using System;
namespace EnvatoMarket.Business.Interfaces
{
	public interface ISendEmail
	{
		public void Send(string from,string displayName,string to,string messageBody,string subject);
	}
}


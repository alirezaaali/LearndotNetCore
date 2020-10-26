using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Priciples
{
	public interface ILogger
	{
		void Log(string message);
	}
	public class DLogger: ILogger
	{
		public void Log(string message)
		{
			System.IO.File.WriteAllText("c:\\log.txt", message);
		}
	}
	public class SQlLogger: ILogger
	{
		public void Log(string message)
		{
			//Log into SQL DB
		}
	}

	class DIP
	{
		public ILogger _log { get; set; }
		public void AddCustomer(Customer c)
		{
			try
			{
				//Add Some customer to DB

			}
			catch (Exception ex)
			{
				//wrong - NO SRP
				//System.IO.File.WriteAllText("c:\\log.txt", ex.Message);

				//Correct SRP
				//Logger.Logit(ex.Message);
				_log.Log(ex.Message);


			}

		}
	}
}

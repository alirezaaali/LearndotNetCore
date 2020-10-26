using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Priciples
{
	public class Logger
	{
		public static void Logit(string message)
		{
			System.IO.File.WriteAllText("c:\\log.txt", message);
		}
	}


	class SRP
	{
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
				Logger.Logit(ex.Message);


			}

		}
	}
}

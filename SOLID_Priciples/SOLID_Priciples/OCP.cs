using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Priciples
{
	
	public abstract class OCPCustomer
	{
		public int ID { get; set; }
		public string FName { get; set; }
		public abstract int Discount(int amount);
	}

	public class SilverCustomet : OCPCustomer
	{
		public override int Discount(int amount)
		{
			return amount - 10;
		}
	}
	public class GoldCustomet : OCPCustomer
	{
		public override int Discount(int amount)
		{
			return amount - 20;
		}
	}
	public class BronzeCustomet : OCPCustomer
	{
		public override int Discount(int amount)
		{
			return amount - 5;
		}
	}


}

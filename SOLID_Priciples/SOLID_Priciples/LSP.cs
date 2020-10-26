using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Priciples
{
	public abstract class FourSqouar
	{

	}
	// Wrong Liskov - Because they are different in deep
	public class Rectangle : FourSqouar
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public void Draw ()
		{
			Console.WriteLine($"{Width},{Height}");
		}

	}
	public class Square: FourSqouar
	{

	}
	public class Diamond : FourSqouar
	{

	}
	
	class LSP
	{
	}
}

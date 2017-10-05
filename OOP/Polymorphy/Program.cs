using System;

namespace Polymorphy
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			IOS iphone7 = new IOS("iphone 7", 64, 10.1);
			Android sgs7 = new Android("Galaxy S7", 128, "Samsung");

			iphone7.call(011782255368);
			sgs7.call(017885541, "Berlin");

			Console.Read();
		}
	}
}

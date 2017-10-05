using System;

namespace Polymorphy
{
	public class IOS : Mobile
	{
		double version;

		public IOS(string model, int memory, double version):base(model, memory)
		{
			this.version = version;
		}

		public void call(long recipient)
		{
			Console.WriteLine("Ich rufe " + recipient + " an!");
		}
	}
}

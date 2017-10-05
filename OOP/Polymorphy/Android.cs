using System;

namespace Polymorphy
{
	public class Android : Mobile
	{
		string manufacturer;

		public Android(string model, int memory, string manufacturer):base(model, memory)
		{
			this.manufacturer = manufacturer;
		}

		public void call(long recipient, string position) {
			Console.WriteLine("Ich rufe " + recipient + " an! Dieser befindet sich in " + position);
		}
	}
}

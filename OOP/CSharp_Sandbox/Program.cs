using System;
namespace Classes {
	class Program
	{
		static Auto bmw_01 = new Auto("BMW", "3er", 130);
		static Auto audi_01 = new Auto("Audi", "A4", 140);

		public static void Main(string[] args) {
			bmw_01.setColor("rot");
			bmw_01.printInformation();

			audi_01.printInformation();

			Console.Read();
		}
	}
}

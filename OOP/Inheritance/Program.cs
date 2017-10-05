using System;

namespace Inheritance
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Employee michael = new Employee("Michael", "Meyer", 3400);
			Superior frank = new Superior("Porsche", "Frank", "Witzel", 7600);
			Trainee fritz = new Trainee(30,6, "Fritz", "Baum", 1400);


			michael.working();
			frank.rule(michael);
			fritz.lerning();
			fritz.working();

			Console.Read();
		}
	}
}
